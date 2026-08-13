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
        MinimizedButton = new Button();
        CloseButton = new Button();
        GPU = new Panel();
        label1 = new Label();
        GPUImg = new Label();
        CPU = new Panel();
        CPUTemp = new Label();
        CPUImg = new Label();
        RAM = new Panel();
        RAMImg = new Label();
        SSD = new Panel();
        SSDImg = new Label();
        panel1 = new Panel();
        label2 = new Label();
        label3 = new Label();
        TitleBar.SuspendLayout();
        GPU.SuspendLayout();
        CPU.SuspendLayout();
        RAM.SuspendLayout();
        SSD.SuspendLayout();
        SuspendLayout();
        // 
        // TitleBar
        // 
        TitleBar.Controls.Add(MinimizedButton);
        TitleBar.Controls.Add(CloseButton);
        TitleBar.Location = new Point(0, 0);
        TitleBar.Name = "TitleBar";
        TitleBar.Size = new Size(550, 30);
        TitleBar.TabIndex = 0;
        // 
        // MinimizedButton
        // 
        MinimizedButton.Location = new Point(500, 5);
        MinimizedButton.Name = "MinimizedButton";
        MinimizedButton.Size = new Size(20, 20);
        MinimizedButton.TabIndex = 1;
        MinimizedButton.UseVisualStyleBackColor = true;
        // 
        // CloseButton
        // 
        CloseButton.Location = new Point(525, 5);
        CloseButton.Name = "CloseButton";
        CloseButton.Size = new Size(20, 20);
        CloseButton.TabIndex = 0;
        CloseButton.UseVisualStyleBackColor = true;
        // 
        // GPU
        // 
        GPU.BorderStyle = BorderStyle.FixedSingle;
        GPU.Controls.Add(label3);
        GPU.Controls.Add(label1);
        GPU.Controls.Add(GPUImg);
        GPU.Location = new Point(0, 100);
        GPU.Name = "GPU";
        GPU.Size = new Size(150, 70);
        GPU.TabIndex = 1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(76, 10);
        label1.Name = "label1";
        label1.Size = new Size(51, 25);
        label1.TabIndex = 1;
        label1.Text = "48 %";
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
        CPU.Controls.Add(label2);
        CPU.Controls.Add(CPUTemp);
        CPU.Controls.Add(CPUImg);
        CPU.Location = new Point(0, 30);
        CPU.Name = "CPU";
        CPU.Size = new Size(150, 70);
        CPU.TabIndex = 2;
        // 
        // CPUTemp
        // 
        CPUTemp.AutoSize = true;
        CPUTemp.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
        CPUTemp.Location = new Point(80, 41);
        CPUTemp.Name = "CPUTemp";
        CPUTemp.Size = new Size(41, 19);
        CPUTemp.TabIndex = 0;
        CPUTemp.Text = "68 °C";
        CPUTemp.Click += label1_Click_1;
        // 
        // CPUImg
        // 
        CPUImg.BackColor = Color.Red;
        CPUImg.Location = new Point(5, 10);
        CPUImg.Name = "CPUImg";
        CPUImg.Size = new Size(50, 50);
        CPUImg.TabIndex = 0;
        CPUImg.Click += label1_Click;
        // 
        // RAM
        // 
        RAM.BorderStyle = BorderStyle.FixedSingle;
        RAM.Controls.Add(RAMImg);
        RAM.Location = new Point(0, 170);
        RAM.Name = "RAM";
        RAM.Size = new Size(150, 70);
        RAM.TabIndex = 2;
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
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        label2.Location = new Point(76, 10);
        label2.Name = "label2";
        label2.Size = new Size(51, 25);
        label2.TabIndex = 1;
        label2.Text = "40 %";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
        label3.Location = new Point(80, 41);
        label3.Name = "label3";
        label3.Size = new Size(41, 19);
        label3.TabIndex = 2;
        label3.Text = "68 °C";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
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
        Text = "MainForm";
        TitleBar.ResumeLayout(false);
        GPU.ResumeLayout(false);
        GPU.PerformLayout();
        CPU.ResumeLayout(false);
        CPU.PerformLayout();
        RAM.ResumeLayout(false);
        SSD.ResumeLayout(false);
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
    private Label CPUTemp;
    private Label label1;
    private Label label3;
    private Label label2;
}
