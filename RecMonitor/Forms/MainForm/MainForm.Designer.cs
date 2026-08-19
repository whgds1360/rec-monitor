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
        TitleBar = new Panel();
        TitleBarLabel = new Label();
        MinimizedButton = new Button();
        CloseButton = new Button();
        GPU = new Panel();
        GPUTemp = new Label();
        GPULoad = new Label();
        GPUImg = new Label();
        CPU = new Panel();
        CPULoad = new Label();
        CPUTemp = new Label();
        CPUImg = new Label();
        RAM = new Panel();
        RAMView = new Label();
        RAMLoad = new Label();
        RAMImg = new Label();
        SSD = new Panel();
        SSDImg = new Label();
        panel1 = new Panel();
        TitleBar.SuspendLayout();
        GPU.SuspendLayout();
        CPU.SuspendLayout();
        RAM.SuspendLayout();
        SSD.SuspendLayout();
        SuspendLayout();
        // 
        // TitleBar
        // 
        TitleBar.Controls.Add(TitleBarLabel);
        TitleBar.Controls.Add(MinimizedButton);
        TitleBar.Controls.Add(CloseButton);
        TitleBar.Location = new Point(0, 0);
        TitleBar.Name = "TitleBar";
        TitleBar.Size = new Size(550, 30);
        TitleBar.TabIndex = 0;
        // 
        // TitleBarLabel
        // 
        TitleBarLabel.AutoSize = true;
        TitleBarLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        TitleBarLabel.ForeColor = Color.PeachPuff;
        TitleBarLabel.Location = new Point(5, 5);
        TitleBarLabel.Name = "TitleBarLabel";
        TitleBarLabel.Size = new Size(141, 20);
        TitleBarLabel.TabIndex = 0;
        TitleBarLabel.Text = "Resources monitor";
        // 
        // MinimizedButton
        // 
        MinimizedButton.Location = new Point(500, 5);
        MinimizedButton.Name = "MinimizedButton";
        MinimizedButton.Size = new Size(20, 20);
        MinimizedButton.TabIndex = 1;
        MinimizedButton.BackColor = Color.DarkGray;
        MinimizedButton.Click += MinimizedHandeler;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(525, 5);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(20, 20);
        CloseButton.TabIndex = 0;
        CloseButton.BackColor = Color.DarkGray;
        CloseButton.Click += CloseHandler;
        // 
        // GPU
        // 
        GPU.BorderStyle = BorderStyle.FixedSingle;
        GPU.Controls.Add(GPUTemp);
        GPU.Controls.Add(GPULoad);
        GPU.Controls.Add(GPUImg);
        GPU.Location = new Point(0, 100);
        GPU.Name = "GPU";
        GPU.Size = new Size(150, 70);
        GPU.TabIndex = 1;
        // 
        // GPUTemp
        // 
        GPUTemp.AutoSize = true;
        GPUTemp.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
        GPUTemp.Location = new Point(80, 41);
        GPUTemp.Name = "GPUTemp";
        GPUTemp.Size = new Size(41, 19);
        GPUTemp.TabIndex = 2;
        GPUTemp.Text = "68 °C";
        // 
        // GPULoad
        // 
        GPULoad.AutoSize = true;
        GPULoad.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        GPULoad.Location = new Point(76, 10);
        GPULoad.Name = "GPULoad";
        GPULoad.Size = new Size(52, 25);
        GPULoad.TabIndex = 1;
        GPULoad.Text = "83 %";
        // 
        // GPUImg
        // 
        GPUImg.BackColor = Color.Red;
        GPUImg.Location = new Point(5, 10);
        GPUImg.Name = "GPUImg";
        GPUImg.Size = new Size(50, 50);
        GPUImg.TabIndex = 1;
        // 
        // CPU
        // 
        CPU.BackColor = Color.FromArgb(64, 64, 64);
        CPU.BorderStyle = BorderStyle.FixedSingle;
        CPU.Controls.Add(CPULoad);
        CPU.Controls.Add(CPUTemp);
        CPU.Controls.Add(CPUImg);
        CPU.Location = new Point(0, 30);
        CPU.Name = "CPU";
        CPU.Size = new Size(150, 70);
        CPU.TabIndex = 2;
        // 
        // CPULoad
        // 
        CPULoad.AutoSize = true;
        CPULoad.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        CPULoad.Location = new Point(76, 10);
        CPULoad.Name = "CPULoad";
        CPULoad.Size = new Size(51, 25);
        CPULoad.TabIndex = 1;
        CPULoad.Text = "40 %";
        // 
        // CPUTemp
        // 
        CPUTemp.AutoSize = true;
        CPUTemp.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
        CPUTemp.Location = new Point(80, 41);
        CPUTemp.Name = "CPUTemp";
        CPUTemp.Size = new Size(41, 19);
        CPUTemp.TabIndex = 0;
        CPUTemp.Text = "38 °C";
        // 
        // CPUImg
        // 
        CPUImg.BackColor = Color.Red;
        CPUImg.Location = new Point(5, 10);
        CPUImg.Name = "CPUImg";
        CPUImg.Size = new Size(50, 50);
        CPUImg.TabIndex = 0;
        // 
        // RAM
        // 
        RAM.BorderStyle = BorderStyle.FixedSingle;
        RAM.Controls.Add(RAMView);
        RAM.Controls.Add(RAMLoad);
        RAM.Controls.Add(RAMImg);
        RAM.Location = new Point(0, 170);
        RAM.Name = "RAM";
        RAM.Size = new Size(150, 70);
        RAM.TabIndex = 2;
        // 
        // RAMView
        // 
        RAMView.AutoSize = true;
        RAMView.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
        RAMView.Location = new Point(60, 41);
        RAMView.Name = "RAMView";
        RAMView.Size = new Size(84, 19);
        RAMView.TabIndex = 3;
        RAMView.Text = "11,7 / 15,3 ГБ";
        // 
        // RAMLoad
        // 
        RAMLoad.AutoSize = true;
        RAMLoad.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        RAMLoad.Location = new Point(76, 10);
        RAMLoad.Name = "RAMLoad";
        RAMLoad.Size = new Size(46, 25);
        RAMLoad.TabIndex = 3;
        RAMLoad.Text = "77 %";
        // 
        // RAMImg
        // 
        RAMImg.BackColor = Color.Red;
        RAMImg.Location = new Point(5, 10);
        RAMImg.Name = "RAMImg";
        RAMImg.Size = new Size(50, 50);
        RAMImg.TabIndex = 2;
        // 
        // SSD
        // 
        SSD.BorderStyle = BorderStyle.FixedSingle;
        SSD.Controls.Add(SSDImg);
        SSD.Location = new Point(0, 240);
        SSD.Name = "SSD";
        SSD.Size = new Size(150, 70);
        SSD.TabIndex = 2;
        // 
        // SSDImg
        // 
        SSDImg.BackColor = Color.Red;
        SSDImg.Location = new Point(5, 10);
        SSDImg.Name = "SSDImg";
        SSDImg.Size = new Size(50, 50);
        SSDImg.TabIndex = 3;
        // 
        // panel1
        // 
        panel1.Location = new Point(150, 30);
        panel1.Name = "panel1";
        panel1.Size = new Size(400, 280);
        panel1.TabIndex = 3;
        // 
        // MainForm
<<<<<<< HEAD
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
=======
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
>>>>>>> 8b1a561 (Пофиксил проблему когда мониторинг перекрывался другими приложениями)
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(64, 64, 64);
        ClientSize = new Size(550, 310);
        Controls.Add(panel1);
        Controls.Add(SSD);
        Controls.Add(RAM);
        Controls.Add(CPU);
        Controls.Add(GPU);
        Controls.Add(TitleBar);
        ForeColor = SystemColors.Control;
        FormBorderStyle = FormBorderStyle.None;
        MaximumSize = new Size(550, 310);
        MinimumSize = new Size(550, 310);
        Name = "MainForm";
<<<<<<< HEAD
        Text = "MainForm";
        TitleBar.ResumeLayout(false);
        TitleBar.PerformLayout();
        GPU.ResumeLayout(false);
        GPU.PerformLayout();
        CPU.ResumeLayout(false);
        CPU.PerformLayout();
        RAM.ResumeLayout(false);
        RAM.PerformLayout();
        SSD.ResumeLayout(false);
=======
        Opacity = 0.9D;
        StartPosition = FormStartPosition.Manual;
        Text = "System monitor";
        TopMost = true;
>>>>>>> 8b1a561 (Пофиксил проблему когда мониторинг перекрывался другими приложениями)
        ResumeLayout(false);
    }

    #endregion

    private Panel TitleBar;
    private Panel GPU;
    private Panel CPU;
    private Panel RAM;
    private Panel SSD;
    private Panel panel1;
    private Button MinimizedButton;
    private Button CloseButton;
    private Label CPUImg;
    private Label GPUImg;
    private Label RAMImg;
    private Label SSDImg;
    public Label CPUTemp;
    public Label GPULoad;
    public Label GPUTemp;
    public Label CPULoad;
    public Label RAMView;
    public Label RAMLoad;
    private Label TitleBarLabel;
}
