
namespace Interface_for_BD
{
    partial class Density_View
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
            this.densityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.densityTableAdapter = new Interface_for_BD.DB_Descriptors_1DataSetTableAdapters.DensityTableAdapter();
            this.substanceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Descriptors_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.densityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.substanceIdDataGridViewTextBoxColumn,
            this.temperatureDataGridViewTextBoxColumn,
            this.pressureDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.densityBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(760, 274);
            this.dataGridView1.TabIndex = 0;
            // 
            // dB_Descriptors_1DataSet
            // 
            this.dB_Descriptors_1DataSet.DataSetName = "DB_Descriptors_1DataSet";
            this.dB_Descriptors_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // densityBindingSource
            // 
            this.densityBindingSource.DataMember = "Density";
            this.densityBindingSource.DataSource = this.dB_Descriptors_1DataSet;
            // 
            // densityTableAdapter
            // 
            this.densityTableAdapter.ClearBeforeFill = true;
            // 
            // substanceIdDataGridViewTextBoxColumn
            // 
            this.substanceIdDataGridViewTextBoxColumn.DataPropertyName = "SubstanceId";
            this.substanceIdDataGridViewTextBoxColumn.HeaderText = "SubstanceId";
            this.substanceIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.substanceIdDataGridViewTextBoxColumn.Name = "substanceIdDataGridViewTextBoxColumn";
            this.substanceIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // temperatureDataGridViewTextBoxColumn
            // 
            this.temperatureDataGridViewTextBoxColumn.DataPropertyName = "Temperature";
            this.temperatureDataGridViewTextBoxColumn.HeaderText = "Temperature";
            this.temperatureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.temperatureDataGridViewTextBoxColumn.Name = "temperatureDataGridViewTextBoxColumn";
            this.temperatureDataGridViewTextBoxColumn.Width = 125;
            // 
            // pressureDataGridViewTextBoxColumn
            // 
            this.pressureDataGridViewTextBoxColumn.DataPropertyName = "Pressure";
            this.pressureDataGridViewTextBoxColumn.HeaderText = "Pressure";
            this.pressureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pressureDataGridViewTextBoxColumn.Name = "pressureDataGridViewTextBoxColumn";
            this.pressureDataGridViewTextBoxColumn.Width = 125;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.Width = 125;
            // 
            // Density_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Density_View";
            this.Text = "Density_View";
            this.Load += new System.EventHandler(this.Density_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Descriptors_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.densityBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_Descriptors_1DataSet dB_Descriptors_1DataSet;
        private System.Windows.Forms.BindingSource densityBindingSource;
        private DB_Descriptors_1DataSetTableAdapters.DensityTableAdapter densityTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn substanceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
    }
}