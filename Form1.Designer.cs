namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.njCompolet1 = new OMRON.Compolet.CIP.NJCompolet(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_get_names = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_changevalue = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.prog_bar_btn1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // njCompolet1
            // 
            this.njCompolet1.Active = false;
            this.njCompolet1.ConnectionType = OMRON.Compolet.CIP.ConnectionType.UCMM;
            this.njCompolet1.DontFragment = false;
            this.njCompolet1.HeartBeatTimer = 0;
            this.njCompolet1.LocalPort = 2;
            this.njCompolet1.PeerAddress = "";
            this.njCompolet1.ReceiveTimeLimit = ((long)(750));
            this.njCompolet1.RoutePath = "";
            this.njCompolet1.UseRoutePath = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 424);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(690, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 33);
            this.label1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 31);
            this.label3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(294, 321);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 31);
            this.label4.TabIndex = 7;
            // 
            // chart1
            // 
            chartArea6.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea6.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea6.AxisX.IsMarginVisible = false;
            chartArea6.AxisX.Title = "Time";
            chartArea6.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea6.AxisY.Maximum = 100D;
            chartArea6.AxisY.Minimum = 0D;
            chartArea6.AxisY.Title = "Temp";
            chartArea6.Name = "TempGraph";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(22, 585);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series6.BorderWidth = 2;
            series6.ChartArea = "TempGraph";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.IsValueShownAsLabel = true;
            series6.Legend = "Legend1";
            series6.Name = "Temperature";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(1564, 467);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            title6.DockedToChartArea = "TempGraph";
            title6.Name = "Temp Thing";
            this.chart1.Titles.Add(title6);
            // 
            // btn_get_names
            // 
            this.btn_get_names.AutoSize = true;
            this.btn_get_names.Location = new System.Drawing.Point(1178, 6);
            this.btn_get_names.Margin = new System.Windows.Forms.Padding(4);
            this.btn_get_names.Name = "btn_get_names";
            this.btn_get_names.Size = new System.Drawing.Size(408, 44);
            this.btn_get_names.TabIndex = 9;
            this.btn_get_names.Text = "Update Tags";
            this.btn_get_names.UseVisualStyleBackColor = true;
            this.btn_get_names.Click += new System.EventHandler(this.btn_getvars);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1336, 513);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 31);
            this.textBox1.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(1178, 98);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(404, 404);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_changevalue
            // 
            this.btn_changevalue.Location = new System.Drawing.Point(1176, 513);
            this.btn_changevalue.Margin = new System.Windows.Forms.Padding(4);
            this.btn_changevalue.Name = "btn_changevalue";
            this.btn_changevalue.Size = new System.Drawing.Size(152, 31);
            this.btn_changevalue.TabIndex = 12;
            this.btn_changevalue.Text = "Set Val";
            this.btn_changevalue.UseVisualStyleBackColor = true;
            this.btn_changevalue.Click += new System.EventHandler(this.btn_changevalue_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1308, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Available Tags";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // prog_bar_btn1
            // 
            this.prog_bar_btn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.prog_bar_btn1.BackColor = System.Drawing.Color.Fuchsia;
            this.prog_bar_btn1.Location = new System.Drawing.Point(22, 491);
            this.prog_bar_btn1.Maximum = 32767;
            this.prog_bar_btn1.Name = "prog_bar_btn1";
            this.prog_bar_btn1.Size = new System.Drawing.Size(670, 53);
            this.prog_bar_btn1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prog_bar_btn1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1608, 1073);
            this.Controls.Add(this.prog_bar_btn1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_changevalue);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_get_names);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OMRON.Compolet.CIP.NJCompolet njCompolet1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btn_get_names;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_changevalue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ProgressBar prog_bar_btn1;
    }
}

