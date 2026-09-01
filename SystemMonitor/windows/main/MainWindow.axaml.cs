using Avalonia.Controls;
using System;
using System.Collections.Generic;
using System.Timers;
using SystemMonitor.features.Metric;

namespace SystemMonitor;

public partial class MainWindow : Window
{   
    private MetricManager? metricManager;
    Timer _timer;

    public MainWindow()
    {
        InitializeComponent();

        metricManager = new MetricManager();
        metricManager.StartCollection(); 

        // Инициализация таймера
        _timer = new Timer(1000); // Интервал в миллисекундах (1000 = 1 секунда)
        _timer.Elapsed += UpdateLabels; // Подписываемся на событие
        _timer.AutoReset = true; // Повторять автоматически
        _timer.Start(); // Запускаем
    }

    private void UpdateLabels(object? sender, EventArgs e)
    {
        var data = metricManager?.GetData();

        if (data is null) return;

        var cpuLoad = executeData(data["CPU"]["Load"]);
        var cpuTemp = executeData(data["CPU"]["Temp"]);
        var cpuFreq = executeData(data["CPU"]["Freq"]);

        var gpuLoad = executeData(data["GPU"]["Load"]);
        var gpuTemp = executeData(data["GPU"]["Temp"]);
        var gpuFreq = executeData(data["GPU"]["Freq"]);

        var ramLoad = executeData(data["RAM"]["Load"]);

        CpuLoad.Content = cpuLoad;
        CpuTemp.Content = cpuTemp;
        CpuFreq.Content = cpuFreq;

        GpuLoad.Content = gpuLoad;
        GpuTemp.Content = gpuTemp;
        GpuFreq.Content = gpuFreq;

        RamLoad.Content = ramLoad;

        metricManager?.ClearData();
    }

    private string executeData(List<float> data)
    {
        float helpCount = 0;
        foreach (float value in data)
        {
            helpCount += value;
        }
        
        return ((int)(helpCount/data.Count)).ToString();
    }

    protected override void OnClosed(EventArgs e)
    {
        base.OnClosed(e);
        _timer?.Stop();
        _timer?.Dispose();
        metricManager?.Disponse();
    }
}