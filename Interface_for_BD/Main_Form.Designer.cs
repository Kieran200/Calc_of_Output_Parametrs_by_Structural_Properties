
namespace Interface_for_BD
{
    partial class Main_Form
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
            this.Open_BD = new System.Windows.Forms.Button();
            this.dB_Descriptors_1DataSet = new Interface_for_BD.DB_Descriptors_1DataSet();
            this.descriptorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptorsTableAdapter = new Interface_for_BD.DB_Descriptors_1DataSetTableAdapters.DescriptorsTableAdapter();
            this.Open_Descriptors = new System.Windows.Forms.Button();
            this.Open_Point = new System.Windows.Forms.Button();
            this.Open_Substances = new System.Windows.Forms.Button();
            this.Open_Density = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Descriptors_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Open_BD
            // 
            this.Open_BD.Location = new System.Drawing.Point(163, 260);
            this.Open_BD.Name = "Open_BD";
            this.Open_BD.Size = new System.Drawing.Size(137, 56);
            this.Open_BD.TabIndex = 0;
            this.Open_BD.Text = "Open BD";
            this.Open_BD.UseVisualStyleBackColor = true;
            this.Open_BD.Click += new System.EventHandler(this.Open_BD_Click);
            // 
            // dB_Descriptors_1DataSet
            // 
            this.dB_Descriptors_1DataSet.DataSetName = "DB_Descriptors_1DataSet";
            this.dB_Descriptors_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // descriptorsBindingSource
            // 
            this.descriptorsBindingSource.DataMember = "Descriptors";
            this.descriptorsBindingSource.DataSource = this.dB_Descriptors_1DataSet;
            // 
            // descriptorsTableAdapter
            // 
            this.descriptorsTableAdapter.ClearBeforeFill = true;
            // 
            // Open_Descriptors
            // 
            this.Open_Descriptors.Location = new System.Drawing.Point(163, 12);
            this.Open_Descriptors.Name = "Open_Descriptors";
            this.Open_Descriptors.Size = new System.Drawing.Size(137, 56);
            this.Open_Descriptors.TabIndex = 1;
            this.Open_Descriptors.Text = "Open descriptors";
            this.Open_Descriptors.UseVisualStyleBackColor = true;
            this.Open_Descriptors.Click += new System.EventHandler(this.Open_Descriptors_Click);
            // 
            // Open_Point
            // 
            this.Open_Point.Location = new System.Drawing.Point(164, 74);
            this.Open_Point.Name = "Open_Point";
            this.Open_Point.Size = new System.Drawing.Size(136, 56);
            this.Open_Point.TabIndex = 2;
            this.Open_Point.Text = "Open points";
            this.Open_Point.UseVisualStyleBackColor = true;
            this.Open_Point.Click += new System.EventHandler(this.Open_Points_Click);
            // 
            // Open_Substances
            // 
            this.Open_Substances.Location = new System.Drawing.Point(163, 136);
            this.Open_Substances.Name = "Open_Substances";
            this.Open_Substances.Size = new System.Drawing.Size(137, 56);
            this.Open_Substances.TabIndex = 3;
            this.Open_Substances.Text = "Open substances";
            this.Open_Substances.UseVisualStyleBackColor = true;
            this.Open_Substances.Click += new System.EventHandler(this.Open_Substances_Click);
            // 
            // Open_Density
            // 
            this.Open_Density.Location = new System.Drawing.Point(163, 198);
            this.Open_Density.Name = "Open_Density";
            this.Open_Density.Size = new System.Drawing.Size(137, 56);
            this.Open_Density.TabIndex = 4;
            this.Open_Density.Text = "Open density";
            this.Open_Density.UseVisualStyleBackColor = true;
            this.Open_Density.Click += new System.EventHandler(this.Open_Density_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 365);
            this.Controls.Add(this.Open_Density);
            this.Controls.Add(this.Open_Substances);
            this.Controls.Add(this.Open_Point);
            this.Controls.Add(this.Open_Descriptors);
            this.Controls.Add(this.Open_BD);
            this.Name = "Main_Form";
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_Descriptors_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptorsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Open_BD;
        private DB_Descriptors_1DataSet dB_Descriptors_1DataSet;
        private System.Windows.Forms.BindingSource descriptorsBindingSource;
        private DB_Descriptors_1DataSetTableAdapters.DescriptorsTableAdapter descriptorsTableAdapter;
        private System.Windows.Forms.Button Open_Descriptors;
        private System.Windows.Forms.Button Open_Point;
        private System.Windows.Forms.Button Open_Substances;
        private System.Windows.Forms.Button Open_Density;
    }
}

