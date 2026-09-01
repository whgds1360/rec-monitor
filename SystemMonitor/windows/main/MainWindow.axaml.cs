using Avalonia.Controls;
using System;
using System.Timers;
using SystemMonitor.features.Metric;

namespace SystemMonitor;

public partial class MainWindow : Window
{   
    private MetricManager metricManager;
    Timer _timer;

    public MainWindow()
    {
        InitializeComponent();

        // Инициализация таймера
        _timer = new Timer(1000); // Интервал в миллисекундах (1000 = 1 секунда)
        _timer.Elapsed += UpdateLabels; // Подписываемся на событие
        _timer.AutoReset = true; // Повторять автоматически
        _timer.Start(); // Запускаем
    }

    private void UpdateLabels(object? sender, EventArgs e)
    {
        metricManager = new MetricManager();
        metricManager.GetData();

        

        metricManager.ClearData();
    }

    private float executeData()
    {
        
    }


}