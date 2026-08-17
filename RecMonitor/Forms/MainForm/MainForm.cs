using RecMonitor.Services.Metric;

namespace RecMonitor;

internal partial class MainForm : Form
{
    private System.Windows.Forms.Timer? _timer;
    private RecMonitor.Services.Metric.MetricManager _metricManager = new MetricManager();

    public MainForm()
    {
        InitializeComponent();
        TimerInit();
    }

    private void TimerInit()
    {
        _timer = new System.Windows.Forms.Timer();
        _timer.Interval = 100;
        _timer.Tick += TimerTick;
        _timer.Start();
    }

    private void TimerTick(object? sender, EventArgs e)
    {
        var data = _metricManager.GetMetricInfo();
        if (data == null) return;

        var cpu = data["CPU"] as Dictionary<string, float?>;
        var gpu = data["GPU"] as Dictionary<string, float?>;
        var ram = data["RAM"] as Dictionary<string, float?>;

        this.CPULoad.Text = cpu.GetValueOrDefault("Load")?.ToString() ?? "0";
        this.CPUTemp.Text = cpu.GetValueOrDefault("Temp")?.ToString() ?? "0";
        //this.CPULoad.Text = cpu["Load"].ToString();

        this.GPULoad.Text = gpu.GetValueOrDefault("Load")?.ToString() ?? "0";
        this.GPUTemp.Text = gpu.GetValueOrDefault("Temp")?.ToString() ?? "0";
        //this.CPULoad.Text = gpu["Load"].ToString();

        this.RAMLoad.Text = ram.GetValueOrDefault("Load")?.ToString() ?? "0";
        //this.CPULoad.Text = ram["Load"].ToString();
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        _timer?.Stop();
        _timer?.Dispose();
        base.OnFormClosing(e);
    }
}
