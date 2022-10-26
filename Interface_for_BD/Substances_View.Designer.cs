
namespace Interface_for_BD
{
    partial class Substances_View
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dB_Descriptors_1DataSet = new Interface_for_BD.DB_Descriptors_1DataSet();
            this.substancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.substancesTableAdapter = new Interface_for_BD.DB_Descriptors_1DataSetTableAdapters.SubstancesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.massDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cansmiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Descriptors_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.substancesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.massDataGridViewTextBoxColumn,
            this.cASDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.cansmiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.substancesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1047, 278);
            this.dataGridView1.TabIndex = 0;
            // 
            // dB_Descriptors_1DataSet
            // 
            this.dB_Descriptors_1DataSet.DataSetName = "DB_Descriptors_1DataSet";
            this.dB_Descriptors_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // substancesBindingSource
            // 
            this.substancesBindingSource.DataMember = "Substances";
            this.substancesBindingSource.DataSource = this.dB_Descriptors_1DataSet;
            // 
            // substancesTableAdapter
            // 
            this.substancesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // massDataGridViewTextBoxColumn
            // 
            this.massDataGridViewTextBoxColumn.DataPropertyName = "Mass";
            this.massDataGridViewTextBoxColumn.HeaderText = "Mass";
            this.massDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.massDataGridViewTextBoxColumn.Name = "massDataGridViewTextBoxColumn";
            this.massDataGridViewTextBoxColumn.Width = 125;
            // 
            // cASDataGridViewTextBoxColumn
            // 
            this.cASDataGridViewTextBoxColumn.DataPropertyName = "CAS";
            this.cASDataGridViewTextBoxColumn.HeaderText = "CAS";
            this.cASDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cASDataGridViewTextBoxColumn.Name = "cASDataGridViewTextBoxColumn";
            this.cASDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // cansmiDataGridViewTextBoxColumn
            // 
            this.cansmiDataGridViewTextBoxColumn.DataPropertyName = "cansmi";
            this.cansmiDataGridViewTextBoxColumn.HeaderText = "cansmi";
            this.cansmiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cansmiDataGridViewTextBoxColumn.Name = "cansmiDataGridViewTextBoxColumn";
            this.cansmiDataGridViewTextBoxColumn.Width = 125;
            // 
            // Substances_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Substances_View";
            this.Text = "Substances_View";
            this.Load += new System.EventHandler(this.Substances_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Descriptors_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.substancesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_Descriptors_1DataSet dB_Descriptors_1DataSet;
        private System.Windows.Forms.BindingSource substancesBindingSource;
        private DB_Descriptors_1DataSetTableAdapters.SubstancesTableAdapter substancesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn massDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cansmiDataGridViewTextBoxColumn;
    }
}