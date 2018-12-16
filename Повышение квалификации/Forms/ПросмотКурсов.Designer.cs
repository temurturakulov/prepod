namespace Повышение_квалификации
{
    partial class ПросмотКурсов
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.курсы_ОбученяDataSet = new Повышение_квалификации.Курсы_ОбученяDataSet();
            this.курсыОбученяDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.курсыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.курсыTableAdapter = new Повышение_квалификации.Курсы_ОбученяDataSetTableAdapters.КурсыTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseVolumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.educationFormIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.курсы_ОбученяDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.курсыОбученяDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.курсыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Повышение_квалификации.Properties.Resources.Untitled_5;
            this.button1.Location = new System.Drawing.Point(22, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 71);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.coursNameDataGridViewTextBoxColumn,
            this.coursTypeIdDataGridViewTextBoxColumn,
            this.courseVolumeDataGridViewTextBoxColumn,
            this.educationFormIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.курсыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(151, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 367);
            this.dataGridView1.TabIndex = 2;
            // 
            // курсы_ОбученяDataSet
            // 
            this.курсы_ОбученяDataSet.DataSetName = "Курсы_ОбученяDataSet";
            this.курсы_ОбученяDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // курсыОбученяDataSetBindingSource
            // 
            this.курсыОбученяDataSetBindingSource.DataSource = this.курсы_ОбученяDataSet;
            this.курсыОбученяDataSetBindingSource.Position = 0;
            // 
            // курсыBindingSource
            // 
            this.курсыBindingSource.DataMember = "Курсы";
            this.курсыBindingSource.DataSource = this.курсыОбученяDataSetBindingSource;
            // 
            // курсыTableAdapter
            // 
            this.курсыTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coursNameDataGridViewTextBoxColumn
            // 
            this.coursNameDataGridViewTextBoxColumn.DataPropertyName = "coursName";
            this.coursNameDataGridViewTextBoxColumn.HeaderText = "coursName";
            this.coursNameDataGridViewTextBoxColumn.Name = "coursNameDataGridViewTextBoxColumn";
            // 
            // coursTypeIdDataGridViewTextBoxColumn
            // 
            this.coursTypeIdDataGridViewTextBoxColumn.DataPropertyName = "coursTypeId";
            this.coursTypeIdDataGridViewTextBoxColumn.HeaderText = "coursTypeId";
            this.coursTypeIdDataGridViewTextBoxColumn.Name = "coursTypeIdDataGridViewTextBoxColumn";
            // 
            // courseVolumeDataGridViewTextBoxColumn
            // 
            this.courseVolumeDataGridViewTextBoxColumn.DataPropertyName = "courseVolume";
            this.courseVolumeDataGridViewTextBoxColumn.HeaderText = "courseVolume";
            this.courseVolumeDataGridViewTextBoxColumn.Name = "courseVolumeDataGridViewTextBoxColumn";
            // 
            // educationFormIdDataGridViewTextBoxColumn
            // 
            this.educationFormIdDataGridViewTextBoxColumn.DataPropertyName = "educationFormId";
            this.educationFormIdDataGridViewTextBoxColumn.HeaderText = "educationFormId";
            this.educationFormIdDataGridViewTextBoxColumn.Name = "educationFormIdDataGridViewTextBoxColumn";
            // 
            // ПросмотКурсов
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Повышение_квалификации.Properties.Resources.bumaga;
            this.ClientSize = new System.Drawing.Size(821, 511);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "ПросмотКурсов";
            this.Text = "Просмотр Курсов";
            this.Load += new System.EventHandler(this.ПросмотКурсов_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.курсы_ОбученяDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.курсыОбученяDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.курсыBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource курсыОбученяDataSetBindingSource;
        private Курсы_ОбученяDataSet курсы_ОбученяDataSet;
        private System.Windows.Forms.BindingSource курсыBindingSource;
        private Курсы_ОбученяDataSetTableAdapters.КурсыTableAdapter курсыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseVolumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn educationFormIdDataGridViewTextBoxColumn;
    }
}