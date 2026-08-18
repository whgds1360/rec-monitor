namespace RecMonitor;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
        SuspendLayout();
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(64, 64, 64);
        ClientSize = new Size(481, 232);
        ForeColor = Color.Transparent;
        FormBorderStyle = FormBorderStyle.None;
        Location = new Point(0, 0);
        Margin = new Padding(3, 2, 3, 2);
        MaximumSize = new Size(481, 232);
        MinimumSize = new Size(481, 232);
        Name = "MainForm";
        Text = "MainForm";
        ResumeLayout(false);
    }

    #endregion
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
}
