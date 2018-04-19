namespace Test_001
{
    partial class SystemWatch
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemWatch));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_GPU_Temp = new System.Windows.Forms.Label();
            this.label_GPU_Load = new System.Windows.Forms.Label();
            this.CPU_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_CPU_Load = new System.Windows.Forms.Label();
            this.CPU_Chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_CPU_Temp = new System.Windows.Forms.Label();
            this.GPU_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GPU_Chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_Chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPU_Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPU_Chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_GPU_Temp
            // 
            this.label_GPU_Temp.AutoSize = true;
            this.label_GPU_Temp.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_GPU_Temp.Location = new System.Drawing.Point(0, 418);
            this.label_GPU_Temp.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_GPU_Temp.Name = "label_GPU_Temp";
            this.label_GPU_Temp.Size = new System.Drawing.Size(96, 22);
            this.label_GPU_Temp.TabIndex = 3;
            this.label_GPU_Temp.Text = "GPU Temp";
            this.label_GPU_Temp.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_GPU_Load
            // 
            this.label_GPU_Load.AutoSize = true;
            this.label_GPU_Load.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_GPU_Load.Location = new System.Drawing.Point(0, 627);
            this.label_GPU_Load.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_GPU_Load.Name = "label_GPU_Load";
            this.label_GPU_Load.Size = new System.Drawing.Size(90, 22);
            this.label_GPU_Load.TabIndex = 4;
            this.label_GPU_Load.Text = "GPU Load";
            this.label_GPU_Load.Click += new System.EventHandler(this.label3_Click);
            // 
            // CPU_Chart
            // 
            this.CPU_Chart.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 15;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Maroon;
            chartArea1.AxisX.LabelStyle.IntervalOffset = 0D;
            chartArea1.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.ScaleView.Zoomable = false;
            chartArea1.AxisX.Title = "Time";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.IntervalOffset = 0D;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.IsSameFontSizeForAllAxes = true;
            chartArea1.Name = "ChartArea1";
            this.CPU_Chart.ChartAreas.Add(chartArea1);
            this.CPU_Chart.Cursor = System.Windows.Forms.Cursors.No;
            this.CPU_Chart.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.CPU_Chart.Legends.Add(legend1);
            this.CPU_Chart.Location = new System.Drawing.Point(0, 22);
            this.CPU_Chart.Margin = new System.Windows.Forms.Padding(0, 6, 5, 6);
            this.CPU_Chart.Name = "CPU_Chart";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.BorderColor = System.Drawing.Color.Red;
            series1.BorderWidth = 10;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Color = System.Drawing.Color.Gray;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsVisibleInLegend = false;
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.MarkerBorderWidth = 5;
            series1.Name = "Series1";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.CPU_Chart.Series.Add(series1);
            this.CPU_Chart.Size = new System.Drawing.Size(1206, 187);
            this.CPU_Chart.TabIndex = 2;
            this.CPU_Chart.Text = "CPU Temp";
            this.CPU_Chart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label_CPU_Load
            // 
            this.label_CPU_Load.AutoSize = true;
            this.label_CPU_Load.BackColor = System.Drawing.Color.Transparent;
            this.label_CPU_Load.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_CPU_Load.ForeColor = System.Drawing.Color.Gray;
            this.label_CPU_Load.Location = new System.Drawing.Point(0, 209);
            this.label_CPU_Load.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_CPU_Load.Name = "label_CPU_Load";
            this.label_CPU_Load.Size = new System.Drawing.Size(89, 22);
            this.label_CPU_Load.TabIndex = 6;
            this.label_CPU_Load.Text = "CPU Load";
            this.label_CPU_Load.Click += new System.EventHandler(this.label5_Click);
            // 
            // CPU_Chart2
            // 
            this.CPU_Chart2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelAutoFitMaxFontSize = 15;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Maroon;
            chartArea2.AxisX.LabelStyle.IntervalOffset = 0D;
            chartArea2.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisX.ScaleView.Zoomable = false;
            chartArea2.AxisX.Title = "Time";
            chartArea2.AxisX.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.LabelStyle.IntervalOffset = 0D;
            chartArea2.AxisY.MajorTickMark.Enabled = false;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.Maximum = 100D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.BackColor = System.Drawing.Color.White;
            chartArea2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.IsSameFontSizeForAllAxes = true;
            chartArea2.Name = "ChartArea1";
            this.CPU_Chart2.ChartAreas.Add(chartArea2);
            this.CPU_Chart2.Cursor = System.Windows.Forms.Cursors.No;
            this.CPU_Chart2.Dock = System.Windows.Forms.DockStyle.Top;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.CPU_Chart2.Legends.Add(legend2);
            this.CPU_Chart2.Location = new System.Drawing.Point(0, 231);
            this.CPU_Chart2.Margin = new System.Windows.Forms.Padding(0, 6, 5, 6);
            this.CPU_Chart2.Name = "CPU_Chart2";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series2.BorderColor = System.Drawing.Color.Red;
            series2.BorderWidth = 10;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Color = System.Drawing.Color.Gray;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsVisibleInLegend = false;
            series2.LabelBackColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.MarkerBorderWidth = 5;
            series2.Name = "Series1";
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.CPU_Chart2.Series.Add(series2);
            this.CPU_Chart2.Size = new System.Drawing.Size(1206, 187);
            this.CPU_Chart2.TabIndex = 8;
            this.CPU_Chart2.Text = "CPU Load";
            this.CPU_Chart2.Click += new System.EventHandler(this.CPU_Chart2_Click);
            // 
            // label_CPU_Temp
            // 
            this.label_CPU_Temp.AutoSize = true;
            this.label_CPU_Temp.BackColor = System.Drawing.Color.Transparent;
            this.label_CPU_Temp.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_CPU_Temp.ForeColor = System.Drawing.Color.Gray;
            this.label_CPU_Temp.Location = new System.Drawing.Point(0, 0);
            this.label_CPU_Temp.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_CPU_Temp.Name = "label_CPU_Temp";
            this.label_CPU_Temp.Size = new System.Drawing.Size(95, 22);
            this.label_CPU_Temp.TabIndex = 1;
            this.label_CPU_Temp.Text = "CPU Temp";
            // 
            // GPU_Chart
            // 
            this.GPU_Chart.BackSecondaryColor = System.Drawing.Color.White;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelAutoFitMaxFontSize = 15;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Maroon;
            chartArea3.AxisX.LabelStyle.IntervalOffset = 0D;
            chartArea3.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea3.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisX.MajorTickMark.Enabled = false;
            chartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.DimGray;
            chartArea3.AxisX.ScaleView.Zoomable = false;
            chartArea3.AxisX.Title = "Time";
            chartArea3.AxisX.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.LabelStyle.IntervalOffset = 0D;
            chartArea3.AxisY.MajorTickMark.Enabled = false;
            chartArea3.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea3.AxisY.Maximum = 100D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.BackColor = System.Drawing.Color.White;
            chartArea3.BackSecondaryColor = System.Drawing.Color.White;
            chartArea3.BorderColor = System.Drawing.Color.Transparent;
            chartArea3.IsSameFontSizeForAllAxes = true;
            chartArea3.Name = "ChartArea1";
            this.GPU_Chart.ChartAreas.Add(chartArea3);
            this.GPU_Chart.Cursor = System.Windows.Forms.Cursors.No;
            this.GPU_Chart.Dock = System.Windows.Forms.DockStyle.Top;
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.GPU_Chart.Legends.Add(legend3);
            this.GPU_Chart.Location = new System.Drawing.Point(0, 440);
            this.GPU_Chart.Margin = new System.Windows.Forms.Padding(0, 6, 5, 6);
            this.GPU_Chart.Name = "GPU_Chart";
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series3.BorderColor = System.Drawing.Color.Red;
            series3.BorderWidth = 10;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.Color = System.Drawing.Color.Gray;
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.IsVisibleInLegend = false;
            series3.LabelBackColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.MarkerBorderWidth = 5;
            series3.Name = "Series1";
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.GPU_Chart.Series.Add(series3);
            this.GPU_Chart.Size = new System.Drawing.Size(1206, 187);
            this.GPU_Chart.TabIndex = 9;
            this.GPU_Chart.Text = "CPU Temp";
            // 
            // GPU_Chart2
            // 
            this.GPU_Chart2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea4.AxisX.IsLabelAutoFit = false;
            chartArea4.AxisX.LabelAutoFitMaxFontSize = 15;
            chartArea4.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Maroon;
            chartArea4.AxisX.LabelStyle.IntervalOffset = 0D;
            chartArea4.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea4.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.AxisX.MajorTickMark.Enabled = false;
            chartArea4.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.DimGray;
            chartArea4.AxisX.ScaleView.Zoomable = false;
            chartArea4.AxisX.Title = "Time";
            chartArea4.AxisX.TitleAlignment = System.Drawing.StringAlignment.Near;
            chartArea4.AxisX.TitleFont = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisY.IsLabelAutoFit = false;
            chartArea4.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisY.LabelStyle.IntervalOffset = 0D;
            chartArea4.AxisY.MajorTickMark.Enabled = false;
            chartArea4.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea4.AxisY.Maximum = 100D;
            chartArea4.AxisY.Minimum = 0D;
            chartArea4.BackColor = System.Drawing.Color.White;
            chartArea4.BackSecondaryColor = System.Drawing.Color.White;
            chartArea4.BorderColor = System.Drawing.Color.Transparent;
            chartArea4.IsSameFontSizeForAllAxes = true;
            chartArea4.Name = "ChartArea1";
            this.GPU_Chart2.ChartAreas.Add(chartArea4);
            this.GPU_Chart2.Cursor = System.Windows.Forms.Cursors.No;
            this.GPU_Chart2.Dock = System.Windows.Forms.DockStyle.Top;
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.GPU_Chart2.Legends.Add(legend4);
            this.GPU_Chart2.Location = new System.Drawing.Point(0, 649);
            this.GPU_Chart2.Margin = new System.Windows.Forms.Padding(0, 6, 5, 6);
            this.GPU_Chart2.Name = "GPU_Chart2";
            series4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series4.BorderColor = System.Drawing.Color.Red;
            series4.BorderWidth = 10;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series4.Color = System.Drawing.Color.Gray;
            series4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.IsVisibleInLegend = false;
            series4.LabelBackColor = System.Drawing.Color.White;
            series4.Legend = "Legend1";
            series4.MarkerBorderWidth = 5;
            series4.Name = "Series1";
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.GPU_Chart2.Series.Add(series4);
            this.GPU_Chart2.Size = new System.Drawing.Size(1206, 187);
            this.GPU_Chart2.TabIndex = 10;
            this.GPU_Chart2.Text = "CPU Temp";
            // 
            // SystemWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 863);
            this.Controls.Add(this.GPU_Chart2);
            this.Controls.Add(this.label_GPU_Load);
            this.Controls.Add(this.GPU_Chart);
            this.Controls.Add(this.label_GPU_Temp);
            this.Controls.Add(this.CPU_Chart2);
            this.Controls.Add(this.label_CPU_Load);
            this.Controls.Add(this.CPU_Chart);
            this.Controls.Add(this.label_CPU_Temp);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "SystemWatch";
            this.Text = "SystemWatch";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CPU_Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_Chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPU_Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPU_Chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_GPU_Temp;
        private System.Windows.Forms.Label label_GPU_Load;
        private System.Windows.Forms.DataVisualization.Charting.Chart CPU_Chart;
        private System.Windows.Forms.Label label_CPU_Load;
        private System.Windows.Forms.DataVisualization.Charting.Chart CPU_Chart2;
        private System.Windows.Forms.Label label_CPU_Temp;
        private System.Windows.Forms.DataVisualization.Charting.Chart GPU_Chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart GPU_Chart2;
    }
}

