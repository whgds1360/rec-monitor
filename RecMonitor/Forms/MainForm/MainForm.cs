using RecMonitor.Services.Metric;
using AcrylicUI.Forms;

namespace RecMonitor;

internal partial class MainForm : AcrylicForm
{
    private System.Windows.Forms.Timer? _timer;
    private MetricManager _metricManager = new MetricManager();

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

        this.CPULoad.Text = (Convert.ToInt32(cpu?.GetValueOrDefault("Load"))).ToString();
        this.CPUTemp.Text = (Convert.ToUInt32(cpu?.GetValueOrDefault("Temp"))).ToString();
        this.CPUFreq.Text = (Convert.ToUInt32(cpu?.GetValueOrDefault("Freq"))).ToString();

        this.GPULoad.Text = (Convert.ToInt32(gpu?.GetValueOrDefault("Load"))).ToString();
        this.GPUTemp.Text = (Convert.ToInt32(gpu?.GetValueOrDefault("Temp"))).ToString();
        this.GPUFreq.Text = (Convert.ToInt32(gpu?.GetValueOrDefault("Freq"))).ToString();

        this.RAMLoad.Text = (Convert.ToUInt32(ram?.GetValueOrDefault("Load"))).ToString();
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        _timer?.Stop();
        _timer?.Dispose();
        base.OnFormClosing(e);
    }

    private void acrylicLabel1_Click(object sender, EventArgs e)
    {

    }
}
