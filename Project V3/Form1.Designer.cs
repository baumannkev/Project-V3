
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
            this.panelMedia.SuspendLayout();
            this.panelData.SuspendLayout();
            this.panelView.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackImage = "https://ak.picdn.net/shutterstock/videos/1018878754/thumb/1.jpg";
            this.chart1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chart1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipY;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.ScaleView.SmallScrollSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea1.AxisX.ScaleView.Zoomable = false;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            legend1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            legend1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            legend1.IsTextAutoFit = false;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.Maroon;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(62, 24);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))))};
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "DFT";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(949, 311);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            this.chart2.BackImage = "https://ak.picdn.net/shutterstock/videos/1018878754/thumb/1.jpg";
            this.chart2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Bottom;
            this.chart2.BorderlineWidth = 5;
            this.chart2.BorderSkin.BorderWidth = 10;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.AxisX.LineColor = System.Drawing.Color.Snow;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.AxisX.ScaleView.SmallScrollSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea2.AxisX.ScaleView.Zoomable = false;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.AxisY.LineColor = System.Drawing.Color.Snow;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Snow;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BorderWidth = 10;
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            legend2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            legend2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            legend2.IsTextAutoFit = false;
            legend2.ItemColumnSeparatorColor = System.Drawing.Color.Maroon;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(62, 21);
            this.chart2.Margin = new System.Windows.Forms.Padding(2);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart2.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(247)))), ((int)(((byte)(5)))))};
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Freq";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(949, 322);
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
            this.lengthTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lengthTitle.Name = "lengthTitle";
            this.lengthTitle.Size = new System.Drawing.Size(108, 29);
            this.lengthTitle.TabIndex = 10;
            this.lengthTitle.Text = "Samples";
            this.lengthTitle.Click += new System.EventHandler(this.sampleLabel_Click);
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.startLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.startLabel.Location = new System.Drawing.Point(0, 150);
            this.startLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(62, 29);
            this.startLabel.TabIndex = 12;
            this.startLabel.Text = "Start";
            // 
            // panelDFT
            // 
            this.panelDFT.AutoScroll = true;
            this.panelDFT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelDFT.Controls.Add(this.chart1);
            this.panelDFT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDFT.Location = new System.Drawing.Point(265, 405);
            this.panelDFT.Margin = new System.Windows.Forms.Padding(2);
            this.panelDFT.Name = "panelDFT";
            this.panelDFT.Padding = new System.Windows.Forms.Padding(10);
            this.panelDFT.Size = new System.Drawing.Size(1045, 356);
            this.panelDFT.TabIndex = 14;
            // 
            // panelSamples
            // 
            this.panelSamples.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelSamples.Controls.Add(this.panel1);
            this.panelSamples.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSamples.Location = new System.Drawing.Point(1310, 0);
            this.panelSamples.Margin = new System.Windows.Forms.Padding(2);
            this.panelSamples.Name = "panelSamples";
            this.panelSamples.Size = new System.Drawing.Size(161, 761);
            this.panelSamples.TabIndex = 15;
            this.panelSamples.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.startLabel);
            this.panel1.Controls.Add(this.endLabel);
            this.panel1.Controls.Add(this.lengthOfData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.sampUpDown);
            this.panel1.Controls.Add(this.lengthTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 208);
            this.panel1.TabIndex = 14;
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.endLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.endLabel.Location = new System.Drawing.Point(0, 179);
            this.endLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(56, 29);
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
            this.lengthOfData.Location = new System.Drawing.Point(0, 86);
            this.lengthOfData.Margin = new System.Windows.Forms.Padding(2);
            this.lengthOfData.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.lengthOfData.Name = "lengthOfData";
            this.lengthOfData.Size = new System.Drawing.Size(161, 28);
            this.lengthOfData.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(0, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Length";
            this.label1.Click += new System.EventHandler(this.sampleLabel_Click);
            // 
            // sampUpDown
            // 
            this.sampUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.sampUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sampUpDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.sampUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sampUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.sampUpDown.Location = new System.Drawing.Point(0, 29);
            this.sampUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.sampUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.sampUpDown.Name = "sampUpDown";
            this.sampUpDown.Size = new System.Drawing.Size(161, 28);
            this.sampUpDown.TabIndex = 13;
            // 
            // panelFreq
            // 
            this.panelFreq.AutoScroll = true;
            this.panelFreq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelFreq.Controls.Add(this.chart2);
            this.panelFreq.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFreq.Location = new System.Drawing.Point(265, 0);
            this.panelFreq.Margin = new System.Windows.Forms.Padding(2);
            this.panelFreq.Name = "panelFreq";
            this.panelFreq.Padding = new System.Windows.Forms.Padding(10);
            this.panelFreq.Size = new System.Drawing.Size(1045, 368);
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
            this.triangleWindowBtn.Margin = new System.Windows.Forms.Padding(2);
            this.triangleWindowBtn.Name = "triangleWindowBtn";
            this.triangleWindowBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.triangleWindowBtn.Size = new System.Drawing.Size(248, 50);
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
            this.rectWindowBtn.Location = new System.Drawing.Point(0, 50);
            this.rectWindowBtn.Margin = new System.Windows.Forms.Padding(2);
            this.rectWindowBtn.Name = "rectWindowBtn";
            this.rectWindowBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.rectWindowBtn.Size = new System.Drawing.Size(248, 50);
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
            this.welchWindowBtn.Location = new System.Drawing.Point(0, 100);
            this.welchWindowBtn.Margin = new System.Windows.Forms.Padding(2);
            this.welchWindowBtn.Name = "welchWindowBtn";
            this.welchWindowBtn.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.welchWindowBtn.Size = new System.Drawing.Size(248, 50);
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
            this.panelWindows.Location = new System.Drawing.Point(0, 664);
            this.panelWindows.Name = "panelWindows";
            this.panelWindows.Size = new System.Drawing.Size(248, 160);
            this.panelWindows.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
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
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 761);
            this.panel2.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(2, 672);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(7, 57);
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
            this.btnWindow.Location = new System.Drawing.Point(0, 614);
            this.btnWindow.Margin = new System.Windows.Forms.Padding(2);
            this.btnWindow.Name = "btnWindow";
            this.btnWindow.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnWindow.Size = new System.Drawing.Size(248, 50);
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
            this.panelMedia.Location = new System.Drawing.Point(0, 414);
            this.panelMedia.Name = "panelMedia";
            this.panelMedia.Size = new System.Drawing.Size(248, 200);
            this.panelMedia.TabIndex = 7;
            // 
            // btnRec
            // 
            this.btnRec.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRec.FlatAppearance.BorderSize = 0;
            this.btnRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRec.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.btnRec.Location = new System.Drawing.Point(0, 150);
            this.btnRec.Margin = new System.Windows.Forms.Padding(2);
            this.btnRec.Name = "btnRec";
            this.btnRec.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRec.Size = new System.Drawing.Size(248, 50);
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
            this.btnStopRec.Location = new System.Drawing.Point(0, 100);
            this.btnStopRec.Margin = new System.Windows.Forms.Padding(2);
            this.btnStopRec.Name = "btnStopRec";
            this.btnStopRec.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnStopRec.Size = new System.Drawing.Size(248, 50);
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
            this.btnPause.Location = new System.Drawing.Point(0, 50);
            this.btnPause.Margin = new System.Windows.Forms.Padding(2);
            this.btnPause.Name = "btnPause";
            this.btnPause.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPause.Size = new System.Drawing.Size(248, 50);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Pause";
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
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPlay.Size = new System.Drawing.Size(248, 50);
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
            this.btnMedia.Location = new System.Drawing.Point(0, 364);
            this.btnMedia.Margin = new System.Windows.Forms.Padding(2);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMedia.Size = new System.Drawing.Size(248, 50);
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
            this.panelData.Location = new System.Drawing.Point(0, 209);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(248, 155);
            this.panelData.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.btnClear.Location = new System.Drawing.Point(0, 100);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnClear.Size = new System.Drawing.Size(248, 50);
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
            this.filterAudio.Location = new System.Drawing.Point(0, 50);
            this.filterAudio.Margin = new System.Windows.Forms.Padding(2);
            this.filterAudio.Name = "filterAudio";
            this.filterAudio.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.filterAudio.Size = new System.Drawing.Size(248, 50);
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
            this.btnDFT.Margin = new System.Windows.Forms.Padding(2);
            this.btnDFT.Name = "btnDFT";
            this.btnDFT.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDFT.Size = new System.Drawing.Size(248, 50);
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
            this.btnData.Location = new System.Drawing.Point(0, 159);
            this.btnData.Margin = new System.Windows.Forms.Padding(2);
            this.btnData.Name = "btnData";
            this.btnData.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnData.Size = new System.Drawing.Size(248, 50);
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
            this.panelView.Location = new System.Drawing.Point(0, 50);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(248, 109);
            this.panelView.TabIndex = 5;
            // 
            // btnZoom
            // 
            this.btnZoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnZoom.FlatAppearance.BorderSize = 0;
            this.btnZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoom.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.btnZoom.Location = new System.Drawing.Point(0, 50);
            this.btnZoom.Margin = new System.Windows.Forms.Padding(2);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnZoom.Size = new System.Drawing.Size(248, 50);
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
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSelect.Size = new System.Drawing.Size(248, 50);
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
            this.btnView.Margin = new System.Windows.Forms.Padding(2);
            this.btnView.Name = "btnView";
            this.btnView.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnView.Size = new System.Drawing.Size(248, 50);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View";
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            this.btnView.Leave += new System.EventHandler(this.btnView_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1471, 761);
            this.Controls.Add(this.panelFreq);
            this.Controls.Add(this.panelDFT);
            this.Controls.Add(this.panelSamples);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wave Analyzer";
            this.Load += new System.EventHandler(this.Form1_Load);
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
            this.panelMedia.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            this.panelView.ResumeLayout(false);
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
    }
}

