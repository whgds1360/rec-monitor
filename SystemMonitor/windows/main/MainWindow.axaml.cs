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

        // Инициализация таймера
        _timer = new Timer(1000); // Интервал в миллисекундах (1000 = 1 секунда)
        _timer.Elapsed += UpdateLabels; // Подписываемся на событие
        _timer.AutoReset = true; // Повторять автоматически
        _timer.Start(); // Запускаем
    }

    private void UpdateLabels(object? sender, EventArgs e)
    {
        metricManager = new MetricManager();
        var data = metricManager.GetData();

        var cpuLoad = executeData(data["CPU"]["Load"]);
        var cpuTemp = executeData(data["CPU"]["Temp"]);
        var cpuFreq = executeData(data["CPU"]["Freq"]);

        var gpuLoad = executeData(data["GPU"]["Load"]);
        var gpuTemp = executeData(data["GPU"]["Temp"]);
        var gpuFreq = executeData(data["GPU"]["Freq"]);

        var ramLoad = executeData(data["RAM"]["Load"]);

        CpuLoad.Content = cpuLoad;
        CpuLoad.Content = cpuTemp;
        CpuLoad.Content = cpuFreq;

        GpuLoad.Content = gpuLoad;
        GpuLoad.Content = gpuTemp;
        GpuLoad.Content = gpuFreq;

        RamLoad.Content = ramLoad;

        metricManager.ClearData();
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
}