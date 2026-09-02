using System.Timers;
using System.Collections.Generic;
using System;

namespace SystemMonitor.features.Metric;
internal class MetricManager
{
    private MetricCollector metricCollectors = new MetricCollector();
    private Timer? _timer;
    private Dictionary<string, List<float>> CpuData = new Dictionary<string, List<float>>();
    private Dictionary<string, List<float>> GpuData = new Dictionary<string, List<float>>();
    private Dictionary<string, List<float>> RamData = new Dictionary<string, List<float>>();

    public MetricManager()
    {
        // Инициализация словарей
        CpuData["Load"] = new List<float>();
        CpuData["Temp"] = new List<float>();
        CpuData["Freq"] = new List<float>();
        
        GpuData["Load"] = new List<float>();
        GpuData["Temp"] = new List<float>();
        GpuData["Freq"] = new List<float>();
        
        RamData["Load"] = new List<float>();
    }

    public void StartCollection()
    {
        _timer = new Timer(100);
        _timer.Elapsed += getRetrievalData;
        _timer.AutoReset = true;
        _timer.Start();
    }

    private void getRetrievalData(object? sender, EventArgs e)
    {
        var data = metricCollectors.GetMetricInfo();
        
        if (data is null)
            return;

        CpuData["Load"].Add(data["CPU"]["Load"] ?? 0);
        CpuData["Temp"].Add(data["CPU"]["Temp"] ?? 0);
        CpuData["Freq"].Add(data["CPU"]["Freq"] ?? 0);

        GpuData["Load"].Add(data["GPU"]["Load"] ?? 0);
        GpuData["Temp"].Add(data["GPU"]["Temp"] ?? 0);
        GpuData["Freq"].Add(data["GPU"]["Freq"] ?? 0);

        RamData["Load"].Add(data["RAM"]["Load"] ?? 0);
    }

    public Dictionary<string, Dictionary<string, List<float>>> GetData()
    {
        return new Dictionary<string, Dictionary<string, List<float>>>
        {
            ["CPU"] = CpuData,
            ["GPU"] = GpuData,
            ["RAM"] = RamData
        };
    }

    public void ClearData()
    {
        CpuData["Load"].Clear();
        CpuData["Temp"].Clear();
        CpuData["Freq"].Clear();

        GpuData["Load"].Clear();
        GpuData["Temp"].Clear();
        GpuData["Freq"].Clear();

        RamData["Load"].Clear();
    }

    public void Disponse()
    {
        _timer?.Stop();
        _timer?.Dispose();
    }
}