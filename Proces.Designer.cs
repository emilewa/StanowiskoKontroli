namespace Projekt6
{
    partial class Proces
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proces));
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.IblRAM = new System.Windows.Forms.Label();
            this.progressBarRAM = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarCPU = new System.Windows.Forms.ProgressBar();
            this.IblCPU = new System.Windows.Forms.Label();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Zaloguj = new System.Windows.Forms.Button();
            this.timer_alarm1 = new System.Windows.Forms.Timer(this.components);
            this.timer_alarm2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.komunikat = new System.Windows.Forms.Label();
            this.wentylator1 = new System.Windows.Forms.Button();
            this.wentylator2 = new System.Windows.Forms.Button();
            this.wentylator3 = new System.Windows.Forms.Button();
            this.wentylator4 = new System.Windows.Forms.Button();
            this.wentylator5 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer_wentylatory = new System.Windows.Forms.Timer(this.components);
            this.przeciazenie = new System.Windows.Forms.Button();
            this.komunikatprzeciazenie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Pamięć";
            this.pRAM.CounterName = "Zadeklarowane bajty w użyciu (%)";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 22F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "RAM:";
            // 
            // IblRAM
            // 
            this.IblRAM.AutoSize = true;
            this.IblRAM.BackColor = System.Drawing.Color.Transparent;
            this.IblRAM.Font = new System.Drawing.Font("Segoe UI Black", 22F, System.Drawing.FontStyle.Bold);
            this.IblRAM.ForeColor = System.Drawing.Color.White;
            this.IblRAM.Location = new System.Drawing.Point(497, 54);
            this.IblRAM.Name = "IblRAM";
            this.IblRAM.Size = new System.Drawing.Size(63, 41);
            this.IblRAM.TabIndex = 3;
            this.IblRAM.Text = "0%";
            // 
            // progressBarRAM
            // 
            this.progressBarRAM.Location = new System.Drawing.Point(94, 57);
            this.progressBarRAM.Name = "progressBarRAM";
            this.progressBarRAM.Size = new System.Drawing.Size(397, 38);
            this.progressBarRAM.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "CPU:";
            // 
            // progressBarCPU
            // 
            this.progressBarCPU.Location = new System.Drawing.Point(94, 13);
            this.progressBarCPU.Name = "progressBarCPU";
            this.progressBarCPU.Size = new System.Drawing.Size(398, 38);
            this.progressBarCPU.TabIndex = 7;
            // 
            // IblCPU
            // 
            this.IblCPU.AutoSize = true;
            this.IblCPU.BackColor = System.Drawing.Color.Transparent;
            this.IblCPU.Font = new System.Drawing.Font("Segoe UI Black", 22F, System.Drawing.FontStyle.Bold);
            this.IblCPU.ForeColor = System.Drawing.Color.White;
            this.IblCPU.Location = new System.Drawing.Point(497, 13);
            this.IblCPU.Name = "IblCPU";
            this.IblCPU.Size = new System.Drawing.Size(63, 41);
            this.IblCPU.TabIndex = 8;
            this.IblCPU.Text = "0%";
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Procesor";
            this.pCPU.CounterName = "Czas procesora (%)";
            this.pCPU.InstanceName = "_Total";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(7, 101);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "RAM";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(485, 239);
            this.chart1.TabIndex = 9;
            // 
            // Zaloguj
            // 
            this.Zaloguj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Zaloguj.Location = new System.Drawing.Point(644, 9);
            this.Zaloguj.Name = "Zaloguj";
            this.Zaloguj.Size = new System.Drawing.Size(128, 49);
            this.Zaloguj.TabIndex = 10;
            this.Zaloguj.Text = "Wyloguj";
            this.Zaloguj.UseVisualStyleBackColor = true;
            this.Zaloguj.Click += new System.EventHandler(this.Zaloguj_Click);
            // 
            // timer_alarm1
            // 
            this.timer_alarm1.Interval = 1000;
            this.timer_alarm1.Tick += new System.EventHandler(this.timer_alarm1_Tick);
            // 
            // timer_alarm2
            // 
            this.timer_alarm2.Interval = 1000;
            this.timer_alarm2.Tick += new System.EventHandler(this.timer_alarm2_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(644, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 138);
            this.button1.TabIndex = 11;
            this.button1.Text = "Alarm !!!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(644, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 47);
            this.label3.TabIndex = 12;
            this.label3.Text = "00:00";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(389, 484);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(249, 65);
            this.button2.TabIndex = 13;
            this.button2.Text = "Akceptuj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // komunikat
            // 
            this.komunikat.AutoSize = true;
            this.komunikat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.komunikat.Location = new System.Drawing.Point(12, 484);
            this.komunikat.Name = "komunikat";
            this.komunikat.Size = new System.Drawing.Size(98, 20);
            this.komunikat.TabIndex = 14;
            this.komunikat.Text = "Komunikat:";
            // 
            // wentylator1
            // 
            this.wentylator1.BackColor = System.Drawing.Color.Transparent;
            this.wentylator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wentylator1.BackgroundImage")));
            this.wentylator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wentylator1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.wentylator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.wentylator1.Location = new System.Drawing.Point(12, 361);
            this.wentylator1.Name = "wentylator1";
            this.wentylator1.Size = new System.Drawing.Size(75, 68);
            this.wentylator1.TabIndex = 15;
            this.wentylator1.Text = "1";
            this.wentylator1.UseVisualStyleBackColor = false;
            // 
            // wentylator2
            // 
            this.wentylator2.BackColor = System.Drawing.Color.Transparent;
            this.wentylator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wentylator2.BackgroundImage")));
            this.wentylator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wentylator2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.wentylator2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.wentylator2.Location = new System.Drawing.Point(114, 361);
            this.wentylator2.Name = "wentylator2";
            this.wentylator2.Size = new System.Drawing.Size(75, 68);
            this.wentylator2.TabIndex = 16;
            this.wentylator2.Text = "2";
            this.wentylator2.UseVisualStyleBackColor = false;
            // 
            // wentylator3
            // 
            this.wentylator3.BackColor = System.Drawing.Color.Transparent;
            this.wentylator3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wentylator3.BackgroundImage")));
            this.wentylator3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wentylator3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.wentylator3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.wentylator3.Location = new System.Drawing.Point(214, 361);
            this.wentylator3.Name = "wentylator3";
            this.wentylator3.Size = new System.Drawing.Size(75, 68);
            this.wentylator3.TabIndex = 17;
            this.wentylator3.Text = "3";
            this.wentylator3.UseVisualStyleBackColor = false;
            // 
            // wentylator4
            // 
            this.wentylator4.BackColor = System.Drawing.Color.Transparent;
            this.wentylator4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wentylator4.BackgroundImage")));
            this.wentylator4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wentylator4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.wentylator4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.wentylator4.Location = new System.Drawing.Point(316, 361);
            this.wentylator4.Name = "wentylator4";
            this.wentylator4.Size = new System.Drawing.Size(75, 68);
            this.wentylator4.TabIndex = 18;
            this.wentylator4.Text = "4";
            this.wentylator4.UseVisualStyleBackColor = false;
            // 
            // wentylator5
            // 
            this.wentylator5.BackColor = System.Drawing.Color.Transparent;
            this.wentylator5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wentylator5.BackgroundImage")));
            this.wentylator5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wentylator5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.wentylator5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.wentylator5.Location = new System.Drawing.Point(417, 361);
            this.wentylator5.Name = "wentylator5";
            this.wentylator5.Size = new System.Drawing.Size(75, 68);
            this.wentylator5.TabIndex = 19;
            this.wentylator5.Text = "5";
            this.wentylator5.UseVisualStyleBackColor = false;
            // 
            // timer_wentylatory
            // 
            this.timer_wentylatory.Interval = 2000;
            this.timer_wentylatory.Tick += new System.EventHandler(this.timer_wentylatory_Tick);
            // 
            // przeciazenie
            // 
            this.przeciazenie.BackColor = System.Drawing.Color.Transparent;
            this.przeciazenie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.przeciazenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przeciazenie.Location = new System.Drawing.Point(510, 101);
            this.przeciazenie.Name = "przeciazenie";
            this.przeciazenie.Size = new System.Drawing.Size(262, 49);
            this.przeciazenie.TabIndex = 20;
            this.przeciazenie.UseVisualStyleBackColor = false;
            // 
            // komunikatprzeciazenie
            // 
            this.komunikatprzeciazenie.AutoSize = true;
            this.komunikatprzeciazenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.komunikatprzeciazenie.Location = new System.Drawing.Point(507, 163);
            this.komunikatprzeciazenie.Name = "komunikatprzeciazenie";
            this.komunikatprzeciazenie.Size = new System.Drawing.Size(0, 25);
            this.komunikatprzeciazenie.TabIndex = 21;
            // 
            // Proces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.komunikatprzeciazenie);
            this.Controls.Add(this.przeciazenie);
            this.Controls.Add(this.wentylator5);
            this.Controls.Add(this.wentylator4);
            this.Controls.Add(this.wentylator3);
            this.Controls.Add(this.wentylator2);
            this.Controls.Add(this.wentylator1);
            this.Controls.Add(this.komunikat);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Zaloguj);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.IblCPU);
            this.Controls.Add(this.progressBarCPU);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarRAM);
            this.Controls.Add(this.IblRAM);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Proces";
            this.Text = "Proces";
            this.Load += new System.EventHandler(this.Proces_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IblRAM;
        private System.Windows.Forms.ProgressBar progressBarRAM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarCPU;
        private System.Windows.Forms.Label IblCPU;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Zaloguj;
        private System.Windows.Forms.Timer timer_alarm1;
        private System.Windows.Forms.Timer timer_alarm2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label komunikat;
        private System.Windows.Forms.Button wentylator1;
        private System.Windows.Forms.Button wentylator2;
        private System.Windows.Forms.Button wentylator3;
        private System.Windows.Forms.Button wentylator4;
        private System.Windows.Forms.Button wentylator5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer timer_wentylatory;
        private System.Windows.Forms.Button przeciazenie;
        private System.Windows.Forms.Label komunikatprzeciazenie;
    }
}