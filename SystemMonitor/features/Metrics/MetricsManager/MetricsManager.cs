using System.Timers;
using System.Collections.Generic;
using System;

namespace SystemMonitor.features.Metric;
internal class MetricManager
{
    private MetricCollector metricCollectors = new MetricCollector();
    private Timer _timer;
    private Dictionary<string, List<float>> CpuData = new Dictionary<string, List<float>>();
    private Dictionary<string, List<float>> GpuData = new Dictionary<string, List<float>>();
    private Dictionary<string, List<float>> RamData = new Dictionary<string, List<float>>();

    public MetricManager()
    {
        // Инициализация таймера
        _timer = new Timer(100); // Интервал в миллисекундах (1000 = 1 секунда)
        _timer.Elapsed += getRetrievalData; // Подписываемся на событие
        _timer.AutoReset = true; // Повторять автоматически
        _timer.Start(); // Запускаем
    }

    private void getRetrievalData(object? sednder, EventArgs e)
    {
        var data = metricCollectors.GetMetricInfo();

        CpuData["Load"].Add(data?["СPU"]["Load"]?? 0);
        CpuData["Temp"].Add(data?["СPU"]["Temp"]?? 0);
        CpuData["Freq"].Add(data?["СPU"]["Freq"]?? 0);

        GpuData["Load"].Add(data?["GPU"]["Load"]?? 0);
        GpuData["Temp"].Add(data?["GPU"]["Temp"]?? 0);
        GpuData["Freq"].Add(data?["GPU"]["Freq"]?? 0);

        RamData["Load"].Add(data?["RAM"]["Load"]?? 0);
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
}