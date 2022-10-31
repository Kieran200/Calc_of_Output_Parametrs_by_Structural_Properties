using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Interface_for_BD
{
    partial class Full_Table
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
            this.Full_Table_View = new System.Windows.Forms.DataGridView();
            this.btn_table_view = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_of_substanse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_of_descriptor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Full_Table_View)).BeginInit();
            this.SuspendLayout();
            // 
            // Full_Table_View
            // 
            this.Full_Table_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Full_Table_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name_of_substanse,
            this.Name_of_descriptor});
            this.Full_Table_View.Location = new System.Drawing.Point(12, 23);
            this.Full_Table_View.Name = "Full_Table_View";
            this.Full_Table_View.RowHeadersWidth = 51;
            this.Full_Table_View.RowTemplate.Height = 24;
            this.Full_Table_View.Size = new System.Drawing.Size(758, 339);
            this.Full_Table_View.TabIndex = 0;
            // 
            // btn_table_view
            // 
            this.btn_table_view.Location = new System.Drawing.Point(12, 391);
            this.btn_table_view.Name = "btn_table_view";
            this.btn_table_view.Size = new System.Drawing.Size(164, 47);
            this.btn_table_view.TabIndex = 1;
            this.btn_table_view.Text = "Показать вещества";
            this.btn_table_view.UseVisualStyleBackColor = true;
            this.btn_table_view.Click += new System.EventHandler(this.btn_table_view_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // Name_of_substanse
            // 
            this.Name_of_substanse.HeaderText = "Name of substanse";
            this.Name_of_substanse.MinimumWidth = 6;
            this.Name_of_substanse.Name = "Name_of_substanse";
            this.Name_of_substanse.Width = 125;
            // 
            // Name_of_descriptor
            // 
            this.Name_of_descriptor.HeaderText = "Name of descriptor";
            this.Name_of_descriptor.MinimumWidth = 6;
            this.Name_of_descriptor.Name = "Name_of_descriptor";
            this.Name_of_descriptor.Width = 125;
            // 
            // Full_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_table_view);
            this.Controls.Add(this.Full_Table_View);
            this.Name = "Full_Table";
            this.Text = "Full_Table";
            ((System.ComponentModel.ISupportInitialize)(this.Full_Table_View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Full_Table_View;
        string ConnectionString = "Server=LAPTOP-1ttvm3h5 ; Database=DB_Descriptors_1;Trusted_Connection=True; ";
        private Button btn_table_view;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name_of_substanse;
        private DataGridViewTextBoxColumn Name_of_descriptor;
    }
}