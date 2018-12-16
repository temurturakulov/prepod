namespace Повышение_квалификации
{
    partial class МенюАдминистратора
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(МенюАдминистратора));
            this.button1 = new System.Windows.Forms.Button();
            this.повышениеквалифDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.повышение_квалифDataSet = new Повышение_квалификации.повышение_квалифDataSet();
            this.повышениеквалифDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.повышениеквалифDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.повышение_квалифDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.повышениеквалифDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Повышение_квалификации.Properties.Resources.Untitled_5;
            this.button1.Location = new System.Drawing.Point(22, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 71);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // повышениеквалифDataSetBindingSource1
            // 
            this.повышениеквалифDataSetBindingSource1.DataSource = this.повышение_квалифDataSet;
            this.повышениеквалифDataSetBindingSource1.Position = 0;
            // 
            // повышение_квалифDataSet
            // 
            this.повышение_квалифDataSet.DataSetName = "повышение_квалифDataSet";
            this.повышение_квалифDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // повышениеквалифDataSetBindingSource
            // 
            this.повышениеквалифDataSetBindingSource.DataSource = this.повышение_квалифDataSet;
            this.повышениеквалифDataSetBindingSource.Position = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.button2.Location = new System.Drawing.Point(287, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "Добавление пользователя";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.button3.Location = new System.Drawing.Point(287, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 66);
            this.button3.TabIndex = 2;
            this.button3.Text = "Редактирование пользователя";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.button4.Location = new System.Drawing.Point(287, 263);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 67);
            this.button4.TabIndex = 3;
            this.button4.Text = "Удаление пользователя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // МенюАдминистратора
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(821, 511);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "МенюАдминистратора";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "МенюАдминистратора";
            this.Load += new System.EventHandler(this.МенюАдминистратора_Load);
            ((System.ComponentModel.ISupportInitialize)(this.повышениеквалифDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.повышение_квалифDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.повышениеквалифDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource повышениеквалифDataSetBindingSource;
        private повышение_квалифDataSet повышение_квалифDataSet;
        private System.Windows.Forms.BindingSource повышениеквалифDataSetBindingSource1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}