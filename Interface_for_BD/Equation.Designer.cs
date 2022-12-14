
namespace Interface_for_BD
{
    partial class Equation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_T = new System.Windows.Forms.TextBox();
            this.txb_d2 = new System.Windows.Forms.TextBox();
            this.txb_p = new System.Windows.Forms.TextBox();
            this.txb_d1 = new System.Windows.Forms.TextBox();
            this.Btn_Show_Eq = new System.Windows.Forms.Button();
            this.txb_sol = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_sub_name = new System.Windows.Forms.ComboBox();
            this.substancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_Descriptors_1DataSet = new Interface_for_BD.DB_Descriptors_1DataSet();
            this.substancesTableAdapter = new Interface_for_BD.DB_Descriptors_1DataSetTableAdapters.SubstancesTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_desc_name = new System.Windows.Forms.ComboBox();
            this.Btn_Select_Sub = new System.Windows.Forms.Button();
            this.Btn_Add_Desc = new System.Windows.Forms.Button();
            this.Btn_Show_Solub = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.substancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Descriptors_1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "d1 +";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "1/T";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "d2 +";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "p +";
            // 
            // txb_T
            // 
            this.txb_T.Location = new System.Drawing.Point(334, 237);
            this.txb_T.Name = "txb_T";
            this.txb_T.Size = new System.Drawing.Size(58, 22);
            this.txb_T.TabIndex = 4;
            this.txb_T.TextChanged += new System.EventHandler(this.txb_T_TextChanged);
            // 
            // txb_d2
            // 
            this.txb_d2.Location = new System.Drawing.Point(121, 237);
            this.txb_d2.Name = "txb_d2";
            this.txb_d2.Size = new System.Drawing.Size(61, 22);
            this.txb_d2.TabIndex = 6;
            // 
            // txb_p
            // 
            this.txb_p.Location = new System.Drawing.Point(230, 237);
            this.txb_p.Name = "txb_p";
            this.txb_p.Size = new System.Drawing.Size(64, 22);
            this.txb_p.TabIndex = 7;
            this.txb_p.TextChanged += new System.EventHandler(this.txb_p_TextChanged);
            // 
            // txb_d1
            // 
            this.txb_d1.Location = new System.Drawing.Point(12, 228);
            this.txb_d1.Name = "txb_d1";
            this.txb_d1.Size = new System.Drawing.Size(61, 22);
            this.txb_d1.TabIndex = 8;
            this.txb_d1.TextChanged += new System.EventHandler(this.txb_d1_TextChanged);
            // 
            // Btn_Show_Eq
            // 
            this.Btn_Show_Eq.Location = new System.Drawing.Point(101, 292);
            this.Btn_Show_Eq.Name = "Btn_Show_Eq";
            this.Btn_Show_Eq.Size = new System.Drawing.Size(212, 33);
            this.Btn_Show_Eq.TabIndex = 9;
            this.Btn_Show_Eq.Text = "Добавить уравнение";
            this.Btn_Show_Eq.UseVisualStyleBackColor = true;
            this.Btn_Show_Eq.Click += new System.EventHandler(this.Btn_Show_Eq_Click);
            // 
            // txb_sol
            // 
            this.txb_sol.Location = new System.Drawing.Point(210, 352);
            this.txb_sol.Name = "txb_sol";
            this.txb_sol.Size = new System.Drawing.Size(110, 22);
            this.txb_sol.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(73, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Растворимость:";
            // 
            // cb_sub_name
            // 
            this.cb_sub_name.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.substancesBindingSource, "Name", true));
            this.cb_sub_name.DataSource = this.substancesBindingSource;
            this.cb_sub_name.DisplayMember = "Name";
            this.cb_sub_name.FormattingEnabled = true;
            this.cb_sub_name.Location = new System.Drawing.Point(240, 15);
            this.cb_sub_name.Name = "cb_sub_name";
            this.cb_sub_name.Size = new System.Drawing.Size(121, 24);
            this.cb_sub_name.TabIndex = 21;
            this.cb_sub_name.ValueMember = "Id";
            // 
            // substancesBindingSource
            // 
            this.substancesBindingSource.DataMember = "Substances";
            this.substancesBindingSource.DataSource = this.dB_Descriptors_1DataSet;
            // 
            // dB_Descriptors_1DataSet
            // 
            this.dB_Descriptors_1DataSet.DataSetName = "DB_Descriptors_1DataSet";
            this.dB_Descriptors_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // substancesTableAdapter
            // 
            this.substancesTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(95, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Название вещества";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(73, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Название дескриптора";
            // 
            // cb_desc_name
            // 
            this.cb_desc_name.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.substancesBindingSource, "Name", true));
            this.cb_desc_name.FormattingEnabled = true;
            this.cb_desc_name.Location = new System.Drawing.Point(246, 113);
            this.cb_desc_name.Name = "cb_desc_name";
            this.cb_desc_name.Size = new System.Drawing.Size(121, 24);
            this.cb_desc_name.TabIndex = 24;
            this.cb_desc_name.SelectedIndexChanged += new System.EventHandler(this.cb_desc_name_SelectedIndexChanged);
            // 
            // Btn_Select_Sub
            // 
            this.Btn_Select_Sub.Location = new System.Drawing.Point(118, 59);
            this.Btn_Select_Sub.Name = "Btn_Select_Sub";
            this.Btn_Select_Sub.Size = new System.Drawing.Size(179, 28);
            this.Btn_Select_Sub.TabIndex = 25;
            this.Btn_Select_Sub.Text = "Выбрать вещество";
            this.Btn_Select_Sub.UseVisualStyleBackColor = true;
            this.Btn_Select_Sub.Click += new System.EventHandler(this.Btn_Select_Sub_Click);
            // 
            // Btn_Add_Desc
            // 
            this.Btn_Add_Desc.Location = new System.Drawing.Point(118, 162);
            this.Btn_Add_Desc.Name = "Btn_Add_Desc";
            this.Btn_Add_Desc.Size = new System.Drawing.Size(179, 28);
            this.Btn_Add_Desc.TabIndex = 26;
            this.Btn_Add_Desc.Text = "Добавить дескриптор";
            this.Btn_Add_Desc.UseVisualStyleBackColor = true;
            this.Btn_Add_Desc.Click += new System.EventHandler(this.Btn_Add_Desc_Click);
            // 
            // Btn_Show_Solub
            // 
            this.Btn_Show_Solub.Location = new System.Drawing.Point(101, 396);
            this.Btn_Show_Solub.Name = "Btn_Show_Solub";
            this.Btn_Show_Solub.Size = new System.Drawing.Size(212, 33);
            this.Btn_Show_Solub.TabIndex = 27;
            this.Btn_Show_Solub.Text = "Показать растворимость";
            this.Btn_Show_Solub.UseVisualStyleBackColor = true;
            this.Btn_Show_Solub.Click += new System.EventHandler(this.Btn_Show_Solub_Click);
            // 
            // Equation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 450);
            this.Controls.Add(this.Btn_Show_Solub);
            this.Controls.Add(this.Btn_Add_Desc);
            this.Controls.Add(this.Btn_Select_Sub);
            this.Controls.Add(this.cb_desc_name);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cb_sub_name);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txb_sol);
            this.Controls.Add(this.Btn_Show_Eq);
            this.Controls.Add(this.txb_d1);
            this.Controls.Add(this.txb_p);
            this.Controls.Add(this.txb_d2);
            this.Controls.Add(this.txb_T);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Equation";
            this.Text = "Equation";
            this.Load += new System.EventHandler(this.Equation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.substancesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Descriptors_1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_T;
        private System.Windows.Forms.TextBox txb_d2;
        private System.Windows.Forms.TextBox txb_p;
        private System.Windows.Forms.TextBox txb_d1;
        private System.Windows.Forms.Button Btn_Show_Eq;
        private System.Windows.Forms.TextBox txb_sol;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_sub_name;
        private DB_Descriptors_1DataSet dB_Descriptors_1DataSet;
        private System.Windows.Forms.BindingSource substancesBindingSource;
        private DB_Descriptors_1DataSetTableAdapters.SubstancesTableAdapter substancesTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_desc_name;
        private System.Windows.Forms.Button Btn_Select_Sub;
        private System.Windows.Forms.Button Btn_Add_Desc;
        private System.Windows.Forms.Button Btn_Show_Solub;
    }
}