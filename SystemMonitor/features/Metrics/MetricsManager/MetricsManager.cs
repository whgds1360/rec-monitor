using System.Timers;
using System.Collections.Generic;
using System;

namespace SystemMonitor.features.Metric;
internal class MetricManager
{
    private static MetricCollector metricCollectors = new MetricCollector();
    private Timer _timer;
    private static Dictionary<string, List<float>> CpuData = new Dictionary<string, List<float>>();
    private static Dictionary<string, List<float>> GpuData = new Dictionary<string, List<float>>();
    private static Dictionary<string, List<float>> RamData = new Dictionary<string, List<float>>();

    public MetricManager()
    {
        // Инициализация таймера
        _timer = new Timer(100); // Интервал в миллисекундах (1000 = 1 секунда)
        _timer.Elapsed += getRetrievalData; // Подписываемся на событие
        _timer.AutoReset = true; // Повторять автоматически
        _timer.Start(); // Запускаем
    }

    private static void getRetrievalData(object? sednder, EventArgs e)
    {
        var data = metricCollectors.GetMetricInfo();

        CpuData["Load"].Add(data?["Сpu"]["Load"]?? 0);
        CpuData["Temp"].Add(data?["Сpu"]["Temp"]?? 0);
        CpuData["Freq"].Add(data?["Сpu"]["Freq"]?? 0);

        CpuData["Load"].Add(data?["Gpu"]["Load"]?? 0);
        CpuData["Temp"].Add(data?["Gpu"]["Temp"]?? 0);
        CpuData["Freq"].Add(data?["Gpu"]["Freq"]?? 0);

        CpuData["Load"].Add(data?["Ram"]["Load"]?? 0);
    }
}