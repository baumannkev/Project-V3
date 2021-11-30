namespace Project_V3
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.saveWavFile = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.lengthTitle = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.panelDFT = new System.Windows.Forms.Panel();
            this.panelSamples = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSelected = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.lengthOfData = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.sampUpDown = new System.Windows.Forms.NumericUpDown();
            this.panelFreq = new System.Windows.Forms.Panel();
            this.triangleWindowBtn = new System.Windows.Forms.Button();
            this.rectWindowBtn = new System.Windows.Forms.Button();
            this.welchWindowBtn = new System.Windows.Forms.Button();
            this.panelWindows = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelSampleRate = new System.Windows.Forms.Panel();
            this.btn44100 = new System.Windows.Forms.Button();
            this.btn22050 = new System.Windows.Forms.Button();
            this.btn11025 = new System.Windows.Forms.Button();
            this.btnSampleRate = new System.Windows.Forms.Button();
            this.panelThreads = new System.Windows.Forms.Panel();
            this.btnThread4 = new System.Windows.Forms.Button();
            this.btnThread3 = new System.Windows.Forms.Button();
            this.btnThread2 = new System.Windows.Forms.Button();
            this.btnThread1 = new System.Windows.Forms.Button();
            this.btnThreads = new System.Windows.Forms.Button();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.btnMaxAmp = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnWindow = new System.Windows.Forms.Button();
            this.panelMedia = new System.Windows.Forms.Panel();
            this.btnRec = new System.Windows.Forms.Button();
            this.btnStopRec = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.panelData = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.filterAudio = new System.Windows.Forms.Button();
            this.btnDFT = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.panelView = new System.Windows.Forms.Panel();
            this.btnZoom = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panelDFT.SuspendLayout();
            this.panelSamples.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthOfData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampUpDown)).BeginInit();
            this.panelFreq.SuspendLayout();
            this.panelWindows.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelSampleRate.SuspendLayout();
            this.panelThreads.SuspendLayout();
            this.panelEdit.SuspendLayout();
            this.panelMedia.SuspendLayout();
            this.panelData.SuspendLayout();
            this.panelView.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackImage = "https://ak.picdn.net/shutterstock/videos/1018878754/thumb/1.jpg";
            this.chart1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chart1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipY;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorTickMark.Enabled = true;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.ScaleView.SmallScrollSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea1.AxisX.ScaleView.Zoomable = false;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MinorTickMark.Enabled = true;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorX.LineColor = System.Drawing.Color.Green;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            legend1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            legend1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            legend1.IsTextAutoFit = false;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.Maroon;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(15, 15);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))))};
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "DFT";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1042, 424);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            this.chart2.BackImage = "https://ak.picdn.net/shutterstock/videos/1018878754/thumb/1.jpg";
            this.chart2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Bottom;
            this.chart2.BorderlineWidth = 5;
            this.chart2.BorderSkin.BorderWidth = 10;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.AxisX.LineColor = System.Drawing.Color.Snow;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.AxisX.MinorTickMark.Enabled = true;
            chartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.AxisX.ScaleView.SmallScrollSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea2.AxisX.ScaleView.Zoomable = false;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.AxisY.LineColor = System.Drawing.Color.Snow;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Snow;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.AxisY.MinorTickMark.Enabled = true;
            chartArea2.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BorderWidth = 10;
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.CursorX.LineColor = System.Drawing.Color.Green;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            legend2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            legend2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            legend2.IsTextAutoFit = false;
            legend2.ItemColumnSeparatorColor = System.Drawing.Color.Maroon;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(15, 15);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart2.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(247)))), ((int)(((byte)(5)))))};
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Freq";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(1045, 425);
            this.chart2.TabIndex = 4;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // saveWavFile
            // 
            this.saveWavFile.Filter = "Wav File|*.wav|Wave File|*.wave";
            this.saveWavFile.Title = "Save Wav File";
            // 
            // lengthTitle
            // 
            this.lengthTitle.AutoSize = true;
            this.lengthTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lengthTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.lengthTitle.Location = new System.Drawing.Point(0, 0);
            this.lengthTitle.Name = "lengthTitle";
            this.lengthTitle.Size = new System.Drawing.Size(157, 40);
            this.lengthTitle.TabIndex = 10;
            this.lengthTitle.Text = "Samples";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.startLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.startLabel.Location = new System.Drawing.Point(0, 319);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(93, 40);
            this.startLabel.TabIndex = 12;
            this.startLabel.Text = "Start";
            // 
            // panelDFT
            // 
            this.panelDFT.AutoScroll = true;
            this.panelDFT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelDFT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelDFT.Controls.Add(this.chart1);
            this.panelDFT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDFT.Location = new System.Drawing.Point(3, 476);
            this.panelDFT.Name = "panelDFT";
            this.panelDFT.Padding = new System.Windows.Forms.Padding(15);
            this.panelDFT.Size = new System.Drawing.Size(1072, 454);
            this.panelDFT.TabIndex = 14;
            // 
            // panelSamples
            // 
            this.panelSamples.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelSamples.Controls.Add(this.panel1);
            this.panelSamples.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSamples.Location = new System.Drawing.Point(2018, 0);
            this.panelSamples.Name = "panelSamples";
            this.panelSamples.Size = new System.Drawing.Size(242, 1474);
            this.panelSamples.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelSelected);
            this.panel1.Controls.Add(this.startLabel);
            this.panel1.Controls.Add(this.endLabel);
            this.panel1.Controls.Add(this.lengthOfData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.sampUpDown);
            this.panel1.Controls.Add(this.lengthTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 399);
            this.panel1.TabIndex = 14;
            // 
            // labelSelected
            // 
            this.labelSelected.AutoSize = true;
            this.labelSelected.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.labelSelected.Location = new System.Drawing.Point(0, 279);
            this.labelSelected.Name = "labelSelected";
            this.labelSelected.Size = new System.Drawing.Size(0, 40);
            this.labelSelected.TabIndex = 14;
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.endLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.endLabel.Location = new System.Drawing.Point(0, 359);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(81, 40);
            this.endLabel.TabIndex = 10;
            this.endLabel.Text = "End";
            // 
            // lengthOfData
            // 
            this.lengthOfData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.lengthOfData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lengthOfData.Dock = System.Windows.Forms.DockStyle.Top;
            this.lengthOfData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthOfData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.lengthOfData.Location = new System.Drawing.Point(0, 120);
            this.lengthOfData.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.lengthOfData.Name = "lengthOfData";
            this.lengthOfData.Size = new System.Drawing.Size(242, 40);
            this.lengthOfData.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(0, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "Length";
            // 
            // sampUpDown
            // 
            this.sampUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.sampUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sampUpDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.sampUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sampUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.sampUpDown.Location = new System.Drawing.Point(0, 40);
            this.sampUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.sampUpDown.Name = "sampUpDown";
            this.sampUpDown.Size = new System.Drawing.Size(242, 40);
            this.sampUpDown.TabIndex = 13;
            // 
            // panelFreq
            // 
            this.panelFreq.AutoScroll = true;
            this.panelFreq.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelFreq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelFreq.Controls.Add(this.chart2);
            this.panelFreq.Location = new System.Drawing.Point(413, 21);
            this.panelFreq.Name = "panelFreq";
            this.panelFreq.Padding = new System.Windows.Forms.Padding(15);
            this.panelFreq.Size = new System.Drawing.Size(1075, 455);
            this.panelFreq.TabIndex = 16;
            // 
            // triangleWindowBtn
            // 
            this.triangleWindowBtn.AutoSize = true;
            this.triangleWindowBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.triangleWindowBtn.FlatAppearance.BorderSize = 0;
            this.triangleWindowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.triangleWindowBtn.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.triangleWindowBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.triangleWindowBtn.Location = new System.Drawing.Point(0, 0);
            this.triangleWindowBtn.Name = "triangleWindowBtn";
            this.triangleWindowBtn.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.triangleWindowBtn.Size = new System.Drawing.Size(372, 77);
            this.triangleWindowBtn.TabIndex = 17;
            this.triangleWindowBtn.Text = "Triangle";
            this.triangleWindowBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.triangleWindowBtn.UseVisualStyleBackColor = true;
            this.triangleWindowBtn.Click += new System.EventHandler(this.triangleWindowBtn_Click);
            // 
            // rectWindowBtn
            // 
            this.rectWindowBtn.AutoSize = true;
            this.rectWindowBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.rectWindowBtn.FlatAppearance.BorderSize = 0;
            this.rectWindowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectWindowBtn.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rectWindowBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.rectWindowBtn.Location = new System.Drawing.Point(0, 77);
            this.rectWindowBtn.Name = "rectWindowBtn";
            this.rectWindowBtn.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.rectWindowBtn.Size = new System.Drawing.Size(372, 77);
            this.rectWindowBtn.TabIndex = 18;
            this.rectWindowBtn.Text = "Rectangle";
            this.rectWindowBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rectWindowBtn.UseVisualStyleBackColor = true;
            this.rectWindowBtn.Click += new System.EventHandler(this.rectWindowBtn_Click);
            // 
            // welchWindowBtn
            // 
            this.welchWindowBtn.AutoSize = true;
            this.welchWindowBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.welchWindowBtn.FlatAppearance.BorderSize = 0;
            this.welchWindowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.welchWindowBtn.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welchWindowBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.welchWindowBtn.Location = new System.Drawing.Point(0, 154);
            this.welchWindowBtn.Name = "welchWindowBtn";
            this.welchWindowBtn.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.welchWindowBtn.Size = new System.Drawing.Size(372, 77);
            this.welchWindowBtn.TabIndex = 19;
            this.welchWindowBtn.Text = "Welch";
            this.welchWindowBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.welchWindowBtn.UseVisualStyleBackColor = true;
            this.welchWindowBtn.Click += new System.EventHandler(this.welchWindowBtn_Click);
            // 
            // panelWindows
            // 
            this.panelWindows.Controls.Add(this.welchWindowBtn);
            this.panelWindows.Controls.Add(this.rectWindowBtn);
            this.panelWindows.Controls.Add(this.triangleWindowBtn);
            this.panelWindows.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWindows.Location = new System.Drawing.Point(0, 1022);
            this.panelWindows.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelWindows.Name = "panelWindows";
            this.panelWindows.Size = new System.Drawing.Size(372, 246);
            this.panelWindows.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.panelSampleRate);
            this.panel2.Controls.Add(this.btnSampleRate);
            this.panel2.Controls.Add(this.panelThreads);
            this.panel2.Controls.Add(this.btnThreads);
            this.panel2.Controls.Add(this.panelEdit);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.pnlNav);
            this.panel2.Controls.Add(this.panelWindows);
            this.panel2.Controls.Add(this.btnWindow);
            this.panel2.Controls.Add(this.panelMedia);
            this.panel2.Controls.Add(this.btnMedia);
            this.panel2.Controls.Add(this.panelData);
            this.panel2.Controls.Add(this.btnData);
            this.panel2.Controls.Add(this.panelView);
            this.panel2.Controls.Add(this.btnView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 1474);
            this.panel2.TabIndex = 0;
            // 
            // panelSampleRate
            // 
            this.panelSampleRate.Controls.Add(this.btn44100);
            this.panelSampleRate.Controls.Add(this.btn22050);
            this.panelSampleRate.Controls.Add(this.btn11025);
            this.panelSampleRate.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSampleRate.Location = new System.Drawing.Point(0, 1854);
            this.panelSampleRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSampleRate.Name = "panelSampleRate";
            this.panelSampleRate.Size = new System.Drawing.Size(372, 168);
            this.panelSampleRate.TabIndex = 26;
            // 
            // btn44100
            // 
            this.btn44100.AutoSize = true;
            this.btn44100.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn44100.FlatAppearance.BorderSize = 0;
            this.btn44100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn44100.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn44100.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.btn44100.Location = new System.Drawing.Point(0, 82);
            this.btn44100.Name = "btn44100";
            this.btn44100.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.btn44100.Size = new System.Drawing.Size(372, 43);
            this.btn44100.TabIndex = 19;
            this.btn44100.Text = "44100 Hz";
            this.btn44100.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn44100.UseVisualStyleBackColor = true;
            this.btn44100.Click += new System.EventHandler(this.btn44100_Click);
            // 
            // btn22050
            // 
            this.btn22050.AutoSize = true;
            this.btn22050.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn22050.FlatAppearance.BorderSize = 0;
            this.btn22050.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn22050.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn22050.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.btn22050.Location = new System.Drawing.Point(0, 44);
            this.btn22050.Name = "btn22050";
            this.btn22050.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.btn22050.Size = new System.Drawing.Size(372, 38);
            this.btn22050.TabIndex = 18;
            this.btn22050.Text = "22050 Hz";
            this.btn22050.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn22050.UseVisualStyleBackColor = true;
            this.btn22050.Click += new System.EventHandler(this.btn22050_Click);
            // 
            // btn11025
            // 
            this.btn11025.AutoSize = true;
            this.btn11025.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn11025.FlatAppearance.BorderSize = 0;
            this.btn11025.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn11025.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn11025.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.btn11025.Location = new System.Drawing.Point(0, 0);
            this.btn11025.Name = "btn11025";
            this.btn11025.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.btn11025.Size = new System.Drawing.Size(372, 44);
            this.btn11025.TabIndex = 17;
            this.btn11025.Text = "11025 Hz";
            this.btn11025.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn11025.UseVisualStyleBackColor = true;
            this.btn11025.Click += new System.EventHandler(this.btn11025_Click);
            // 
            // btnSampleRate
            // 
            this.btnSampleRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnSampleRate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSampleRate.FlatAppearance.BorderSize = 0;
            this.btnSampleRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSampleRate.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSampleRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.btnSampleRate.Location = new System.Drawing.Point(0, 1777);
            this.btnSampleRate.Name = "btnSampleRate";
            this.btnSampleRate.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSampleRate.Size = new System.Drawing.Size(372, 77);
            this.btnSampleRate.TabIndex = 25;
            this.btnSampleRate.Text = "Sample Rate";
            this.btnSampleRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSampleRate.UseVisualStyleBackColor = false;
            this.btnSampleRate.Click += new System.EventHandler(this.btnSampleRate_Click);
            // 
            // panelThreads
            // 
            this.panelThreads.Controls.Add(this.btnThread4);
            this.panelThreads.Controls.Add(this.btnThread3);
            this.panelThreads.Controls.Add(this.btnThread2);
            this.panelThreads.Controls.Add(this.btnThread1);
            this.panelThreads.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThreads.Location = new System.Drawing.Point(0, 1590);
            this.panelThreads.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelThreads.Name = "panelThreads";
            this.panelThreads.Size = new System.Drawing.Size(372, 187);
            this.panelThreads.TabIndex = 24;
            // 
            // btnThread4
            // 
            this.btnThread4.AutoSize = true;
            this.btnThread4.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThread4.FlatAppearance.BorderSize = 0;
            this.btnThread4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThread4.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThread4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.btnThread4.Location = new System.Drawing.Point(0, 125);
            this.btnThread4.Name = "btnThread4";
            this.btnThread4.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.btnThread4.Size = new System.Drawing.Size(372, 38);
            this.btnThread4.TabIndex = 20;
            this.btnThread4.Text = "4";
            this.btnThread4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThread4.UseVisualStyleBackColor = true;
            this.btnThread4.Click += new System.EventHandler(this.btnThread4_Click);
            // 
            // btnThread3
            // 
            this.btnThread3.AutoSize = true;
            this.btnThread3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThread3.FlatAppearance.BorderSize = 0;
            this.btnThread3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThread3.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThread3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.btnThread3.Location = new System.Drawing.Point(0, 82);
            this.btnThread3.Name = "btnThread3";
            this.btnThread3.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.btnThread3.Size = new System.Drawing.Size(372, 43);
            this.btnThread3.TabIndex = 19;
            this.btnThread3.Text = "3";
            this.btnThread3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThread3.UseVisualStyleBackColor = true;
            this.btnThread3.Click += new System.EventHandler(this.btnThread3_Click);
            // 
            // btnThread2
            // 
            this.btnThread2.AutoSize = true;
            this.btnThread2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThread2.FlatAppearance.BorderSize = 0;
            this.btnThread2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThread2.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThread2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.btnThread2.Location = new System.Drawing.Point(0, 44);
            this.btnThread2.Name = "btnThread2";
            this.btnThread2.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.btnThread2.Size = new System.Drawing.Size(372, 38);
            this.btnThread2.TabIndex = 18;
            this.btnThread2.Text = "2";
            this.btnThread2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThread2.UseVisualStyleBackColor = true;
            this.btnThread2.Click += new System.EventHandler(this.btnThread2_Click);
            // 
            // btnThread1
            // 
            this.btnThread1.AutoSize = true;
            this.btnThread1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThread1.FlatAppearance.BorderSize = 0;
            this.btnThread1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThread1.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThread1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.btnThread1.Location = new System.Drawing.Point(0, 0);
            this.btnThread1.Name = "btnThread1";
            this.btnThread1.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.btnThread1.Size = new System.Drawing.Size(372, 44);
            this.btnThread1.TabIndex = 17;
            this.btnThread1.Text = "1";
            this.btnThread1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThread1.UseVisualStyleBackColor = true;
            this.btnThread1.Click += new System.EventHandler(this.btnThread1_Click);
            // 
            // btnThreads
            // 
            this.btnThreads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnThreads.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThreads.FlatAppearance.BorderSize = 0;
            this.btnThreads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThreads.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThreads.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.btnThreads.Location = new System.Drawing.Point(0, 1513);
            this.btnThreads.Name = "btnThreads";
            this.btnThreads.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnThreads.Size = new System.Drawing.Size(372, 77);
            this.btnThreads.TabIndex = 23;
            this.btnThreads.Text = "Threads";
            this.btnThreads.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThreads.UseVisualStyleBackColor = false;
            this.btnThreads.Click += new System.EventHandler(this.btnThreads_Click);
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.btnMaxAmp);
            this.panelEdit.Controls.Add(this.btnReverse);
            this.panelEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEdit.Location = new System.Drawing.Point(0, 1345);
            this.panelEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(372, 168);
            this.panelEdit.TabIndex = 22;
            // 
            // btnMaxAmp
            // 
            this.btnMaxAmp.AutoSize = true;
            this.btnMaxAmp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaxAmp.FlatAppearance.BorderSize = 0;
            this.btnMaxAmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxAmp.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaxAmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.btnMaxAmp.Location = new System.Drawing.Point(0, 77);
            this.btnMaxAmp.Name = "btnMaxAmp";
            this.btnMaxAmp.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.btnMaxAmp.Size = new System.Drawing.Size(372, 77);
            this.btnMaxAmp.TabIndex = 18;
            this.btnMaxAmp.Text = "Amplify";
            this.btnMaxAmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaxAmp.UseVisualStyleBackColor = true;
            this.btnMaxAmp.Click += new System.EventHandler(this.btnMaxAmp_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.AutoSize = true;
            this.btnReverse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReverse.FlatAppearance.BorderSize = 0;
            this.btnReverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReverse.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReverse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.btnReverse.Location = new System.Drawing.Point(0, 0);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.btnReverse.Size = new System.Drawing.Size(372, 77);
            this.btnReverse.TabIndex = 17;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.btnEdit.Location = new System.Drawing.Point(0, 1268);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnEdit.Size = new System.Drawing.Size(372, 77);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Edit Wave";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.Leave += new System.EventHandler(this.btnEdit_Leave);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(3, 1521);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(10, 88);
            this.pnlNav.TabIndex = 3;
            // 
            // btnWindow
            // 
            this.btnWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnWindow.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWindow.FlatAppearance.BorderSize = 0;
            this.btnWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWindow.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.btnWindow.Location = new System.Drawing.Point(0, 945);
            this.btnWindow.Name = "btnWindow";
            this.btnWindow.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnWindow.Size = new System.Drawing.Size(372, 77);
            this.btnWindow.TabIndex = 2;
            this.btnWindow.Text = "Windows";
            this.btnWindow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWindow.UseVisualStyleBackColor = false;
            this.btnWindow.Click += new System.EventHandler(this.btnWindow_Click);
            this.btnWindow.Leave += new System.EventHandler(this.btnWindow_Leave);
            // 
            // panelMedia
            // 
            this.panelMedia.Controls.Add(this.btnRec);
            this.panelMedia.Controls.Add(this.btnStopRec);
            this.panelMedia.Controls.Add(this.btnPause);
            this.panelMedia.Controls.Add(this.btnPlay);
            this.panelMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMedia.Location = new System.Drawing.Point(0, 637);
            this.panelMedia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMedia.Name = "panelMedia";
            this.panelMedia.Size = new System.Drawing.Size(372, 308);
            this.panelMedia.TabIndex = 7;
            // 
            // btnRec
            // 
            this.btnRec.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRec.FlatAppearance.BorderSize = 0;
            this.btnRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRec.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.btnRec.Location = new System.Drawing.Point(0, 231);
            this.btnRec.Name = "btnRec";
            this.btnRec.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.btnRec.Size = new System.Drawing.Size(372, 77);
            this.btnRec.TabIndex = 2;
            this.btnRec.Text = "Record";
            this.btnRec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRec.UseVisualStyleBackColor = true;
            this.btnRec.Click += new System.EventHandler(this.btnRec_Click);
            this.btnRec.Leave += new System.EventHandler(this.btnRec_Leave);
            // 
            // btnStopRec
            // 
            this.btnStopRec.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStopRec.Enabled = false;
            this.btnStopRec.FlatAppearance.BorderSize = 0;
            this.btnStopRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopRec.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopRec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.btnStopRec.Location = new System.Drawing.Point(0, 154);
            this.btnStopRec.Name = "btnStopRec";
            this.btnStopRec.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.btnStopRec.Size = new System.Drawing.Size(372, 77);
            this.btnStopRec.TabIndex = 2;
            this.btnStopRec.Text = "Stop Recording";
            this.btnStopRec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStopRec.UseVisualStyleBackColor = true;
            this.btnStopRec.Click += new System.EventHandler(this.btnStopRec_Click);
            this.btnStopRec.Leave += new System.EventHandler(this.btnStopRec_Leave);
            // 
            // btnPause
            // 
            this.btnPause.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPause.Enabled = false;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.btnPause.Location = new System.Drawing.Point(0, 77);
            this.btnPause.Name = "btnPause";
            this.btnPause.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.btnPause.Size = new System.Drawing.Size(372, 77);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Stop";
            this.btnPause.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            this.btnPause.Leave += new System.EventHandler(this.btnPause_Leave);
            // 
            // btnPlay
            // 
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlay.Enabled = false;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.btnPlay.Location = new System.Drawing.Point(0, 0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.btnPlay.Size = new System.Drawing.Size(372, 77);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.Leave += new System.EventHandler(this.btnPlay_Leave);
            // 
            // btnMedia
            // 
            this.btnMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedia.FlatAppearance.BorderSize = 0;
            this.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedia.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.btnMedia.Location = new System.Drawing.Point(0, 560);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMedia.Size = new System.Drawing.Size(372, 77);
            this.btnMedia.TabIndex = 2;
            this.btnMedia.Text = "Media";
            this.btnMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedia.UseVisualStyleBackColor = false;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            this.btnMedia.Leave += new System.EventHandler(this.btnMedia_Leave);
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.btnClear);
            this.panelData.Controls.Add(this.filterAudio);
            this.panelData.Controls.Add(this.btnDFT);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelData.Location = new System.Drawing.Point(0, 322);
            this.panelData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(372, 238);
            this.panelData.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.btnClear.Location = new System.Drawing.Point(0, 154);
            this.btnClear.Name = "btnClear";
            this.btnClear.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.btnClear.Size = new System.Drawing.Size(372, 77);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.Leave += new System.EventHandler(this.btnClear_Leave);
            // 
            // filterAudio
            // 
            this.filterAudio.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterAudio.FlatAppearance.BorderSize = 0;
            this.filterAudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterAudio.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterAudio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.filterAudio.Location = new System.Drawing.Point(0, 77);
            this.filterAudio.Name = "filterAudio";
            this.filterAudio.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.filterAudio.Size = new System.Drawing.Size(372, 77);
            this.filterAudio.TabIndex = 3;
            this.filterAudio.Text = "Lowpass Filter";
            this.filterAudio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filterAudio.UseVisualStyleBackColor = true;
            this.filterAudio.Click += new System.EventHandler(this.filterAudio_Click);
            // 
            // btnDFT
            // 
            this.btnDFT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDFT.FlatAppearance.BorderSize = 0;
            this.btnDFT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDFT.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDFT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDFT.Location = new System.Drawing.Point(0, 0);
            this.btnDFT.Name = "btnDFT";
            this.btnDFT.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.btnDFT.Size = new System.Drawing.Size(372, 77);
            this.btnDFT.TabIndex = 1;
            this.btnDFT.Text = "Discrete Fourier Transform";
            this.btnDFT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDFT.UseVisualStyleBackColor = true;
            this.btnDFT.Click += new System.EventHandler(this.btnDFT_Click);
            this.btnDFT.Leave += new System.EventHandler(this.btnDFT_Leave);
            // 
            // btnData
            // 
            this.btnData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnData.FlatAppearance.BorderSize = 0;
            this.btnData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnData.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.btnData.Location = new System.Drawing.Point(0, 245);
            this.btnData.Name = "btnData";
            this.btnData.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnData.Size = new System.Drawing.Size(372, 77);
            this.btnData.TabIndex = 2;
            this.btnData.Text = "Data";
            this.btnData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnData.UseVisualStyleBackColor = false;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            this.btnData.Leave += new System.EventHandler(this.btnData_Leave);
            // 
            // panelView
            // 
            this.panelView.Controls.Add(this.btnZoom);
            this.panelView.Controls.Add(this.btnSelect);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelView.Location = new System.Drawing.Point(0, 77);
            this.panelView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(372, 168);
            this.panelView.TabIndex = 5;
            // 
            // btnZoom
            // 
            this.btnZoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnZoom.FlatAppearance.BorderSize = 0;
            this.btnZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoom.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.btnZoom.Location = new System.Drawing.Point(0, 77);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.btnZoom.Size = new System.Drawing.Size(372, 77);
            this.btnZoom.TabIndex = 2;
            this.btnZoom.Text = "Zoom";
            this.btnZoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZoom.UseVisualStyleBackColor = true;
            this.btnZoom.Click += new System.EventHandler(this.btnZoom_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.btnSelect.Location = new System.Drawing.Point(0, 0);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.btnSelect.Size = new System.Drawing.Size(372, 77);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            this.btnSelect.Leave += new System.EventHandler(this.btnSelect_Leave);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.btnView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.btnView.Location = new System.Drawing.Point(0, 0);
            this.btnView.Name = "btnView";
            this.btnView.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnView.Size = new System.Drawing.Size(372, 77);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View";
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            this.btnView.Leave += new System.EventHandler(this.btnView_Leave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelDFT, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(413, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.75377F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.24623F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1078, 933);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(2260, 1474);
            this.Controls.Add(this.panelFreq);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelSamples);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1414, 893);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wave Analyzer";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panelDFT.ResumeLayout(false);
            this.panelSamples.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthOfData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampUpDown)).EndInit();
            this.panelFreq.ResumeLayout(false);
            this.panelWindows.ResumeLayout(false);
            this.panelWindows.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelSampleRate.ResumeLayout(false);
            this.panelSampleRate.PerformLayout();
            this.panelThreads.ResumeLayout(false);
            this.panelThreads.PerformLayout();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.panelMedia.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            this.panelView.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.SaveFileDialog saveWavFile;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        public System.Windows.Forms.Label lengthTitle;
        private System.Windows.Forms.Panel panelDFT;
        public System.Windows.Forms.Label endLabel;
        public System.Windows.Forms.Label startLabel;
        public System.Windows.Forms.Panel panelSamples;
        private System.Windows.Forms.Panel panelFreq;
        private System.Windows.Forms.NumericUpDown sampUpDown;
        private System.Windows.Forms.NumericUpDown lengthOfData;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button triangleWindowBtn;
        private System.Windows.Forms.Button rectWindowBtn;
        private System.Windows.Forms.Button welchWindowBtn;
        private System.Windows.Forms.Panel panelWindows;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel panelMedia;
        private System.Windows.Forms.Button btnRec;
        private System.Windows.Forms.Button btnStopRec;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button filterAudio;
        private System.Windows.Forms.Button btnDFT;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Button btnZoom;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnWindow;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Button btnMaxAmp;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panelThreads;
        private System.Windows.Forms.Button btnThread3;
        private System.Windows.Forms.Button btnThread2;
        private System.Windows.Forms.Button btnThread1;
        private System.Windows.Forms.Button btnThreads;
        private System.Windows.Forms.Button btnThread4;
        private System.Windows.Forms.Panel panelSampleRate;
        private System.Windows.Forms.Button btn44100;
        private System.Windows.Forms.Button btn22050;
        private System.Windows.Forms.Button btn11025;
        private System.Windows.Forms.Button btnSampleRate;
        public System.Windows.Forms.Label labelSelected;
    }
}