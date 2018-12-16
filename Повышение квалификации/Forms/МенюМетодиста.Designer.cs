namespace Повышение_квалификации
{
    partial class МенюМетодиста
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
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.курсыTableAdapter1 = new Повышение_квалификации.повышение_квалифDataSet1TableAdapters.КурсыTableAdapter();
            this.silverHaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.silverHa = new Повышение_квалификации.silverHa();
            this.курсыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.курсыTableAdapter = new Повышение_квалификации.silverHaTableAdapters.КурсыTableAdapter();
            this.tableAdapterManager = new Повышение_квалификации.silverHaTableAdapters.TableAdapterManager();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseVolumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.educationFormIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursTypeList = new System.Windows.Forms.ComboBox();
            this.educationFormList = new System.Windows.Forms.ComboBox();
            this.видКурсаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.видКурсаTableAdapter = new Повышение_квалификации.silverHaTableAdapters.ВидКурсаTableAdapter();
            this.формаОбученияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.формаОбученияTableAdapter = new Повышение_квалификации.silverHaTableAdapters.ФормаОбученияTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silverHaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silverHa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.курсыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видКурсаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.формаОбученияBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Повышение_квалификации.Properties.Resources.Untitled_5;
            this.button1.Location = new System.Drawing.Point(32, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 71);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.button2.Location = new System.Drawing.Point(108, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 63);
            this.button2.TabIndex = 5;
            this.button2.Text = "Составить список курсов";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(437, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(588, 424);
            this.dataGridView1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(28, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Название курса";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Объем курса";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(219, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Код_Тип_Курса";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(28, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Код_Формы_Обучения";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(219, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 20);
            this.textBox2.TabIndex = 15;
            // 
            // курсыTableAdapter1
            // 
            this.курсыTableAdapter1.ClearBeforeFill = true;
            // 
            // silverHaBindingSource
            // 
            this.silverHaBindingSource.DataSource = this.silverHa;
            this.silverHaBindingSource.Position = 0;
            // 
            // silverHa
            // 
            this.silverHa.DataSetName = "silverHa";
            this.silverHa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // курсыBindingSource
            // 
            this.курсыBindingSource.DataMember = "Курсы";
            this.курсыBindingSource.DataSource = this.silverHa;
            // 
            // курсыTableAdapter
            // 
            this.курсыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Повышение_квалификации.silverHaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвторизацияTableAdapter = null;
            this.tableAdapterManager.ВидКурсаTableAdapter = null;
            this.tableAdapterManager.КурсыTableAdapter = this.курсыTableAdapter;
            this.tableAdapterManager.ОбучениеTableAdapter = null;
            this.tableAdapterManager.ПользователиTableAdapter = null;
            this.tableAdapterManager.ПреподавателиTableAdapter = null;
            this.tableAdapterManager.РолиTableAdapter = null;
            this.tableAdapterManager.ФормаОбученияTableAdapter = null;
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
            // coursTypeList
            // 
            this.coursTypeList.DataSource = this.видКурсаBindingSource;
            this.coursTypeList.DisplayMember = "coursName";
            this.coursTypeList.FormattingEnabled = true;
            this.coursTypeList.Location = new System.Drawing.Point(219, 134);
            this.coursTypeList.Name = "coursTypeList";
            this.coursTypeList.Size = new System.Drawing.Size(152, 21);
            this.coursTypeList.TabIndex = 17;
            this.coursTypeList.ValueMember = "id";
            // 
            // educationFormList
            // 
            this.educationFormList.DataSource = this.формаОбученияBindingSource;
            this.educationFormList.DisplayMember = "educationType";
            this.educationFormList.FormattingEnabled = true;
            this.educationFormList.Location = new System.Drawing.Point(219, 189);
            this.educationFormList.Name = "educationFormList";
            this.educationFormList.Size = new System.Drawing.Size(152, 21);
            this.educationFormList.TabIndex = 18;
            this.educationFormList.ValueMember = "id";
            // 
            // видКурсаBindingSource
            // 
            this.видКурсаBindingSource.DataMember = "ВидКурса";
            this.видКурсаBindingSource.DataSource = this.silverHaBindingSource;
            // 
            // видКурсаTableAdapter
            // 
            this.видКурсаTableAdapter.ClearBeforeFill = true;
            // 
            // формаОбученияBindingSource
            // 
            this.формаОбученияBindingSource.DataMember = "ФормаОбучения";
            this.формаОбученияBindingSource.DataSource = this.silverHaBindingSource;
            // 
            // формаОбученияTableAdapter
            // 
            this.формаОбученияTableAdapter.ClearBeforeFill = true;
            // 
            // МенюМетодиста
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Повышение_квалификации.Properties.Resources.bumaga;
            this.ClientSize = new System.Drawing.Size(1057, 531);
            this.Controls.Add(this.educationFormList);
            this.Controls.Add(this.coursTypeList);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "МенюМетодиста";
            this.Text = "МенюМетодиста";
            this.Load += new System.EventHandler(this.МенюМетодиста_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silverHaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silverHa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.курсыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видКурсаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.формаОбученияBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.BindingSource silverHaBindingSource;
        private silverHa silverHa;
        private повышение_квалифDataSet1TableAdapters.КурсыTableAdapter курсыTableAdapter1;
        private System.Windows.Forms.BindingSource курсыBindingSource;
        private silverHaTableAdapters.КурсыTableAdapter курсыTableAdapter;
        private silverHaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseVolumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn educationFormIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox coursTypeList;
        private System.Windows.Forms.ComboBox educationFormList;
        private System.Windows.Forms.BindingSource видКурсаBindingSource;
        private silverHaTableAdapters.ВидКурсаTableAdapter видКурсаTableAdapter;
        private System.Windows.Forms.BindingSource формаОбученияBindingSource;
        private silverHaTableAdapters.ФормаОбученияTableAdapter формаОбученияTableAdapter;
    }
}