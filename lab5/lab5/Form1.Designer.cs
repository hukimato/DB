namespace lab5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lab2DataSet = new lab5.lab2DataSet();
            this.facultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBFULLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FULL = new lab5.DB_FULL();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.studentTableAdapter = new lab5.lab2DataSetTableAdapters.StudentTableAdapter();
            this.lab2DataSet1 = new lab5.lab2DataSet1();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter1 = new lab5.lab2DataSet1TableAdapters.StudentTableAdapter();
            this.lab2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter2 = new lab5.DB_FULLTableAdapters.StudentTableAdapter();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.stGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.st_GroupTableAdapter = new lab5.DB_FULLTableAdapters.St_GroupTableAdapter();
            this.stGroupBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.facultyTableAdapter = new lab5.DB_FULLTableAdapters.FacultyTableAdapter();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classTableAdapter = new lab5.DB_FULLTableAdapters.ClassTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFULLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FULL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stGroupBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart1
            // 
            this.Chart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea1.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea1);
            this.Chart1.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.studentBindingSource, "Year", true));
            this.Chart1.DataSource = this.facultyBindingSource;
            legend1.Name = "Legend1";
            this.Chart1.Legends.Add(legend1);
            this.Chart1.Location = new System.Drawing.Point(-107, -94);
            this.Chart1.Name = "Chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Факультеты";
            series1.XValueMember = "Short_title";
            series1.YValueMembers = "Places";
            this.Chart1.Series.Add(series1);
            this.Chart1.Size = new System.Drawing.Size(1011, 589);
            this.Chart1.TabIndex = 0;
            this.Chart1.Text = "Chart1";
            title1.Name = "Кол-во мест на факультете";
            title1.Text = "Кол-во мест на факультете";
            this.Chart1.Titles.Add(title1);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.lab2DataSet;
            // 
            // lab2DataSet
            // 
            this.lab2DataSet.DataSetName = "lab2DataSet";
            this.lab2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facultyBindingSource
            // 
            this.facultyBindingSource.DataMember = "Faculty";
            this.facultyBindingSource.DataSource = this.dBFULLBindingSource;
            // 
            // dBFULLBindingSource
            // 
            this.dBFULLBindingSource.DataSource = this.dB_FULL;
            this.dBFULLBindingSource.Position = 0;
            // 
            // dB_FULL
            // 
            this.dB_FULL.DataSetName = "DB_FULL";
            this.dB_FULL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // lab2DataSet1
            // 
            this.lab2DataSet1.DataSetName = "lab2DataSet1";
            this.lab2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "Student";
            this.studentBindingSource1.DataSource = this.lab2DataSet1;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // lab2DataSetBindingSource
            // 
            this.lab2DataSetBindingSource.DataSource = this.lab2DataSet;
            this.lab2DataSetBindingSource.Position = 0;
            // 
            // studentBindingSource2
            // 
            this.studentBindingSource2.DataMember = "Student";
            this.studentBindingSource2.DataSource = this.dBFULLBindingSource;
            // 
            // studentTableAdapter2
            // 
            this.studentTableAdapter2.ClearBeforeFill = true;
            // 
            // chart2
            // 
            this.chart2.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            this.chart2.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.studentBindingSource, "Year", true));
            this.chart2.DataSource = this.stGroupBindingSource;
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(910, -94);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Группы";
            series3.XValueMember = "Num";
            series3.YValueMembers = "Students";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(947, 589);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            title2.Name = "Title1";
            title2.Text = "Кол-во студентов в группе";
            this.chart2.Titles.Add(title2);
            // 
            // stGroupBindingSource
            // 
            this.stGroupBindingSource.DataMember = "St_Group";
            this.stGroupBindingSource.DataSource = this.dBFULLBindingSource;
            // 
            // chart3
            // 
            this.chart3.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            this.chart3.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.studentBindingSource, "Year", true));
            this.chart3.DataSource = this.dBFULLBindingSource;
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(-117, 501);
            this.chart3.Name = "chart3";
            this.chart3.Size = new System.Drawing.Size(1021, 593);
            this.chart3.TabIndex = 2;
            this.chart3.Text = "chart3";
            // 
            // chart4
            // 
            this.chart4.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea2.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea2);
            this.chart4.DataBindings.Add(new System.Windows.Forms.Binding("DataSource", this.studentBindingSource, "Year", true));
            this.chart4.DataSource = this.studentBindingSource2;
            legend2.Name = "Legend1";
            this.chart4.Legends.Add(legend2);
            this.chart4.Location = new System.Drawing.Point(910, 501);
            this.chart4.Name = "chart4";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XValueMember = "FIO";
            series2.YValueMembers = "Year";
            this.chart4.Series.Add(series2);
            this.chart4.Size = new System.Drawing.Size(947, 593);
            this.chart4.TabIndex = 3;
            this.chart4.Text = "chart4";
            // 
            // st_GroupTableAdapter
            // 
            this.st_GroupTableAdapter.ClearBeforeFill = true;
            // 
            // stGroupBindingSource1
            // 
            this.stGroupBindingSource1.DataMember = "St_Group";
            this.stGroupBindingSource1.DataSource = this.dBFULLBindingSource;
            // 
            // facultyTableAdapter
            // 
            this.facultyTableAdapter.ClearBeforeFill = true;
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "Class";
            this.classBindingSource.DataSource = this.dBFULLBindingSource;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1829, 1163);
            this.Controls.Add(this.chart4);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.Chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFULLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FULL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stGroupBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private lab2DataSet lab2DataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private lab2DataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private lab2DataSet1 lab2DataSet1;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private lab2DataSet1TableAdapters.StudentTableAdapter studentTableAdapter1;
        private System.Windows.Forms.BindingSource lab2DataSetBindingSource;
        private System.Windows.Forms.BindingSource dBFULLBindingSource;
        private DB_FULL dB_FULL;
        private System.Windows.Forms.BindingSource studentBindingSource2;
        private DB_FULLTableAdapters.StudentTableAdapter studentTableAdapter2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.BindingSource stGroupBindingSource;
        private DB_FULLTableAdapters.St_GroupTableAdapter st_GroupTableAdapter;
        private System.Windows.Forms.BindingSource stGroupBindingSource1;
        private System.Windows.Forms.BindingSource facultyBindingSource;
        private DB_FULLTableAdapters.FacultyTableAdapter facultyTableAdapter;
        private System.Windows.Forms.BindingSource classBindingSource;
        private DB_FULLTableAdapters.ClassTableAdapter classTableAdapter;
    }
}

