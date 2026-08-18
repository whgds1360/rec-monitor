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
        BackGround = new AcrylicUI.Controls.AcrylicLabel();
        CPULoad = new AcrylicUI.Controls.AcrylicTransparentLabel();
        GPULoad = new AcrylicUI.Controls.AcrylicTransparentLabel();
        RAMLoad = new AcrylicUI.Controls.AcrylicTransparentLabel();
        CPUTemp = new AcrylicUI.Controls.AcrylicLabel();
        CPUFreq = new AcrylicUI.Controls.AcrylicLabel();
        GPUTemp = new AcrylicUI.Controls.AcrylicLabel();
        GPUFreq = new AcrylicUI.Controls.AcrylicLabel();
        SuspendLayout();
        // 
        // BackGround
        // 
        BackGround.Dock = DockStyle.Fill;
        BackGround.ForeColor = Color.FromArgb(192, 192, 192);
        BackGround.Image = Properties.Resources.photo_2026_08_18_07_14_171;
        BackGround.Location = new Point(0, 0);
        BackGround.Name = "BackGround";
        BackGround.Size = new Size(249, 450);
        BackGround.TabIndex = 0;
        // 
        // CPULoad
        // 
        CPULoad.Font = new Font("Impact", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        CPULoad.ForeColor = Color.LightSkyBlue;
        CPULoad.Location = new Point(70, 100);
        CPULoad.Name = "CPULoad";
        CPULoad.Size = new Size(62, 42);
        CPULoad.TabIndex = 1;
        CPULoad.TabStop = false;
        CPULoad.Text = "100";
        CPULoad.TextAlign = ContentAlignment.TopLeft;
        // 
        // GPULoad
        // 
        GPULoad.Font = new Font("Impact", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        GPULoad.ForeColor = Color.Violet;
        GPULoad.Location = new Point(70, 221);
        GPULoad.Name = "GPULoad";
        GPULoad.Size = new Size(62, 42);
        GPULoad.TabIndex = 2;
        GPULoad.TabStop = false;
        GPULoad.Text = "100";
        GPULoad.TextAlign = ContentAlignment.TopLeft;
        // 
        // RAMLoad
        // 
        RAMLoad.Font = new Font("Impact", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        RAMLoad.ForeColor = Color.LightGreen;
        RAMLoad.Location = new Point(70, 340);
        RAMLoad.Name = "RAMLoad";
        RAMLoad.Size = new Size(62, 42);
        RAMLoad.TabIndex = 3;
        RAMLoad.TabStop = false;
        RAMLoad.Text = "100";
        RAMLoad.TextAlign = ContentAlignment.TopLeft;
        // 
        // CPUTemp
        // 
        CPUTemp.AutoSize = true;
        CPUTemp.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        CPUTemp.ForeColor = Color.LightSkyBlue;
        CPUTemp.Location = new Point(170, 98);
        CPUTemp.Name = "CPUTemp";
        CPUTemp.Size = new Size(27, 20);
        CPUTemp.TabIndex = 4;
        CPUTemp.Text = "60";
        // 
        // CPUFreq
        // 
        CPUFreq.AutoSize = true;
        CPUFreq.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        CPUFreq.ForeColor = Color.LightSkyBlue;
        CPUFreq.Location = new Point(170, 123);
        CPUFreq.Name = "CPUFreq";
        CPUFreq.Size = new Size(28, 20);
        CPUFreq.TabIndex = 5;
        CPUFreq.Text = "4,2";
        // 
        // GPUTemp
        // 
        GPUTemp.AutoSize = true;
        GPUTemp.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        GPUTemp.ForeColor = Color.Violet;
        GPUTemp.Location = new Point(170, 219);
        GPUTemp.Name = "GPUTemp";
        GPUTemp.Size = new Size(26, 20);
        GPUTemp.TabIndex = 6;
        GPUTemp.Text = "46";
        // 
        // GPUFreq
        // 
        GPUFreq.AutoSize = true;
        GPUFreq.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        GPUFreq.ForeColor = Color.Violet;
        GPUFreq.Location = new Point(170, 244);
        GPUFreq.Name = "GPUFreq";
        GPUFreq.Size = new Size(26, 20);
        GPUFreq.TabIndex = 7;
        GPUFreq.Text = "2,7";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(64, 64, 64);
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(249, 450);
        Controls.Add(GPUFreq);
        Controls.Add(GPUTemp);
        Controls.Add(CPUFreq);
        Controls.Add(CPUTemp);
        Controls.Add(RAMLoad);
        Controls.Add(GPULoad);
        Controls.Add(CPULoad);
        Controls.Add(BackGround);
        ForeColor = Color.Transparent;
        FormBorderStyle = FormBorderStyle.None;
        IsAcrylic = false;
        Location = new Point(0, 0);
        Margin = new Padding(3, 2, 3, 2);
        Name = "MainForm";
        Opacity = 0.9D;
        StartPosition = FormStartPosition.Manual;
        Text = "System monitor";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private AcrylicUI.Controls.AcrylicLabel BackGround;
    private AcrylicUI.Controls.AcrylicTransparentLabel CPULoad;
    private AcrylicUI.Controls.AcrylicTransparentLabel GPULoad;
    private AcrylicUI.Controls.AcrylicTransparentLabel RAMLoad;
    private AcrylicUI.Controls.AcrylicLabel CPUTemp;
    private AcrylicUI.Controls.AcrylicLabel CPUFreq;
    private AcrylicUI.Controls.AcrylicLabel GPUTemp;
    private AcrylicUI.Controls.AcrylicLabel GPUFreq;
}
