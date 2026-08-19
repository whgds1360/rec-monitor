using AcrylicUI.Forms;
using RecMonitor.Services.Metric;

namespace RecMonitor;

internal partial class MainForm : AcrylicForm
{
    private List<float> CpuLoad = new List<float>();
    private List<float> CpuTemp = new List<float>();
    private List<float> CpuFreq = new List<float>();

    private List<float> GpuLoad = new List<float>();
    private List<float> GpuTemp = new List<float>();
    private List<float> GpuFreq = new List<float>();

    private List<float> RamLoad = new List<float>();

    private System.Windows.Forms.Timer? _main_timer;
    private System.Windows.Forms.Timer? _get_data_timer;
    private MetricManager _metricManager = new MetricManager();

    public MainForm()
    {
        InitializeComponent();
        InitTimers();
    }

    private void InitTimers()
    {
        _main_timer = new System.Windows.Forms.Timer();
        _main_timer.Interval = 1000;
        _main_timer.Tick += MainTimerTick;
        _main_timer.Start();

        _get_data_timer = new System.Windows.Forms.Timer();
        _get_data_timer.Interval = 100;
        _get_data_timer.Tick += DataTimerTick;
        _get_data_timer.Start();
    }

    private void DataTimerTick(object? sender, EventArgs e)
    {
        var data = _metricManager.GetMetricInfo();
        if (data == null) return;

        var cpu = data["CPU"] as Dictionary<string, float?>;
        var gpu = data["GPU"] as Dictionary<string, float?>;
        var ram = data["RAM"] as Dictionary<string, float?>;

        if (cpu != null)
        {
            AddIfNotNull(CpuLoad, cpu.GetValueOrDefault("Load"));
            AddIfNotNull(CpuTemp, cpu.GetValueOrDefault("Temp"));
            AddIfNotNull(CpuFreq, cpu.GetValueOrDefault("Freq"));
        }

        if (gpu != null)
        {
            AddIfNotNull(GpuLoad, gpu.GetValueOrDefault("Load"));
            AddIfNotNull(GpuTemp, gpu.GetValueOrDefault("Temp"));
            AddIfNotNull(GpuFreq, gpu.GetValueOrDefault("Freq"));
        }

        if (ram != null)
        {
            AddIfNotNull(RamLoad, ram.GetValueOrDefault("Load"));
        }
    }

    private void MainTimerTick(object? sender, EventArgs e)
    {
        float avgCpuLoad = CpuLoad.Count > 0 ? CpuLoad.Average() : 0;
        float avgCpuTemp = CpuTemp.Count > 0 ? CpuTemp.Average() : 0;
        float avgCpuFreq = CpuFreq.Count > 0 ? CpuFreq.Average() : 0;

        float avgGpuLoad = GpuLoad.Count > 0 ? GpuLoad.Average() : 0;
        float avgGpuTemp = GpuTemp.Count > 0 ? GpuTemp.Average() : 0;
        float avgGpuFreq = GpuFreq.Count > 0 ? GpuFreq.Average() : 0;

        float avgRamLoad = RamLoad.Count > 0 ? RamLoad.Average() : 0;

        this.CPULoad.Text = ((int)avgCpuLoad).ToString();
        this.CPUTemp.Text = ((int)avgCpuTemp).ToString();
        this.CPUFreq.Text = ((int)avgCpuFreq).ToString();

        this.GPULoad.Text = ((int)avgGpuLoad).ToString();
        this.GPUTemp.Text = ((int)avgGpuTemp).ToString();
        this.GPUFreq.Text = ((int)avgGpuFreq).ToString();

        this.RAMLoad.Text = ((int)avgRamLoad).ToString();

        CpuLoad.Clear();
        CpuTemp.Clear();
        CpuFreq.Clear();
        GpuLoad.Clear();
        GpuTemp.Clear();
        GpuFreq.Clear();
        RamLoad.Clear();
    }

    private static void AddIfNotNull(List<float> list, float? value)
    {
        if (value.HasValue)
        {
            list.Add(value.Value);
        }
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        _main_timer?.Stop();
        _main_timer?.Dispose();
        _get_data_timer?.Stop();
        _get_data_timer?.Dispose();
        base.OnFormClosing(e);
    }
}