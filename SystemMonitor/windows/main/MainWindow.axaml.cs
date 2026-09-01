using Avalonia.Controls;
using System;
using Avalonia.Threading;
using System.Collections.Generic;
using System.Timers;
using SystemMonitor.features.Metric;

namespace SystemMonitor;

public partial class MainWindow : Window
{   
    private MetricManager? metricManager;
    DispatcherTimer? _timer;

    public MainWindow()
    {
        InitializeComponent();

        metricManager = new MetricManager();
        metricManager.StartCollection(); 

        _timer = new DispatcherTimer();
        _timer.Interval = TimeSpan.FromSeconds(1);
        _timer.Tick += UpdateLabels;
        _timer.Start();
    }

    private void UpdateLabels(object? sender, EventArgs e)
    {   
        System.Diagnostics.Debug.WriteLine("Главный таймер сработал!");

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

        System.Diagnostics.Debug.WriteLine("Главный таймер сработал!");
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
        metricManager?.Disponse();
    }
}