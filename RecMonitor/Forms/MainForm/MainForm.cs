<<<<<<< HEAD
=======
using AcrylicUI.Forms;
using RecMonitor.Services.Metric;

>>>>>>> 8b1a561 (Пофиксил проблему когда мониторинг перекрывался другими приложениями)
namespace RecMonitor;

internal partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        this.Load += SubscribeHandler!;
    }

    private void SubscribeHandler(object sender, EventArgs e)
    {  
        foreach (Control element in TitleBar.Controls)
        {
            if (element is Button button)
            {
                button.MouseEnter += EnterHandler!;
                button.MouseLeave += LeaveHandler!;
            }
        }
    }

    private void EnterHandler(object sender, EventArgs e)
    {
        switch (sender)
        {
            case Button btn when btn == CloseButton:
                CloseButton.BackColor = Color.LightGray;
                break;

            case Button btn when btn == MinimizedButton:
                MinimizedButton.BackColor = Color.LightGray;
                break;
        }
    }

    private void LeaveHandler(object sender, EventArgs e)
    {
        if (sender is Button button)
        {
            button.BackColor = Color.DarkGray;
        }
    }

    private void MinimizedHandeler(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }

    private void CloseHandler(object sender, EventArgs e)
    {
        this.Close();
    }
}
