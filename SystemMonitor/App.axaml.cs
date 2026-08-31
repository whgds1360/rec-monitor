using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.Platform;

namespace SystemMonitor;

public partial class App : Application
{
    private TrayIcon? _trayIcon {get; set;}

    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow();
            
            CreateIcon(desktop:desktop);
        }

        base.OnFrameworkInitializationCompleted();
    }

    private void CreateIcon(IClassicDesktopStyleApplicationLifetime desktop)
    {
        try
        {
            var iconUri = new Uri("avares://SystemMonitor/assets/icon/logo.ico");
            var icon = AssetLoader.Open(iconUri);

            var exitItem = new NativeMenuItem {Header = "Выйти"};
            exitItem.Click += AppExitHandler;

            var trayMenu = new NativeMenu();
            trayMenu.Items.Add(exitItem);

            _trayIcon = new TrayIcon
            {
              Icon = new WindowIcon(icon),
              ToolTipText = "System Monitor",
              Menu = trayMenu,
              IsVisible = true   
            };

            TrayIcon.SetIcons(this, new TrayIcons {_trayIcon});
        }
        catch (Exception error)
        {
            System.Diagnostics.Debug.WriteLine($"Ошибка при создании иконки в трее: {error}");
        }
    }
    private void AppExitHandler(object? sender, EventArgs e)
    {   
        // Проверка на то что программа запущенна на настольной ОС (т.к. на телефоне нету окон)
        if (Current?.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.Shutdown();
        }
    }
}