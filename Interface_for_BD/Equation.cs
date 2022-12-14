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
    public partial class Equation : Form
    {
        public Equation()
        {
            InitializeComponent();
        }

        private void Btn_Select_Sub_Click(object sender, EventArgs e)
        {
            List<Descriptors> Desc_Name = new List<Descriptors>();

            string sub_id = cb_sub_name.SelectedValue.ToString();
            string ConnectionString = "Server=LAPTOP-1ttvm3h5; Database=DB_Descriptors_1;Trusted_Connection=True; ";
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string query = string.Format("SELECT Descriptors.Name, Descriptors.Id FROM Descriptors, Substances, DescriptorsDictionary WHERE Descriptors.Id = DescriptorsDictionary.DescriptorId AND Substances.Id = DescriptorsDictionary.SubstanceId AND Substances.Id = {0} AND Descriptors.Name IS NOT NULL", sub_id);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Descriptors d = new Descriptors() { Id = Convert.ToString(reader.GetValue(1)), Name = Convert.ToString(reader.GetValue(0)) };
                    Desc_Name.Add(d);
                    //cb_desc_name.Items.Add(reader.GetValue(0));
                    //cb_desc_name.ValueMember += reader.GetValue(1);
                    
                }
            }
            cb_desc_name.DataSource = Desc_Name;
            cb_desc_name.DisplayMember = "Name";
            cb_desc_name.ValueMember = "Id";
            cb_desc_name.SelectedIndexChanged += cb_desc_name_SelectedIndexChanged;
        }
        class Descriptors
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }
        List<double> Values = new List<double>();
        private void Btn_Add_Desc_Click(object sender, EventArgs e)
        {
            string sub_id = cb_sub_name.SelectedValue.ToString();
            int desc_id = Convert.ToInt32(cb_desc_name.SelectedValue);

            string ConnectionString = "Server=LAPTOP-1ttvm3h5; Database=DB_Descriptors_1;Trusted_Connection=True; ";
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string query = string.Format("SELECT DescriptorsDictionary.Value FROM  Descriptors, Substances, DescriptorsDictionary WHERE {0} = DescriptorsDictionary.DescriptorId AND {1} = DescriptorsDictionary.SubstanceId",desc_id, sub_id);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Values.Add(Convert.ToDouble(reader.GetValue(0)));
                }
            }
            //выводим температуру и давление
            //string query_2 = string.Format("SELECT DescriptorsDictionary.Value FROM  Descriptors, Substances, DescriptorsDictionary WHERE {0} = DescriptorsDictionary.DescriptorId AND {1} = DescriptorsDictionary.SubstanceId", desc_id, sub_id);
            //SqlCommand command_2 = new SqlCommand(query, connection);
            //SqlDataReader reader_2 = command.ExecuteReader();
            //if (reader.HasRows)
            //{
            //    while (reader_2.Read())
            //    {
            //        Values.Add(Convert.ToDouble(reader_2.GetValue(0)));
            //    }
            //}


        }

        private void cb_desc_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Descriptors d = (Descriptors)cb_desc_name.SelectedItem;
        }



        private void txb_T_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_p_TextChanged(object sender, EventArgs e)
        {

        }
        private void txb_d1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        double x_d1;
        double x_d2;
        double x_p;
        double x_T;
        private void Btn_Show_Eq_Click(object sender, EventArgs e)
        {
            x_d1 = Convert.ToDouble(txb_d1.Text);
            x_d2 = Convert.ToDouble(txb_d2.Text);
            x_p = Convert.ToDouble(txb_p.Text);
            x_T = Convert.ToDouble(txb_T.Text);

        }
        
        private void Equation_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_Descriptors_1DataSet.Substances". При необходимости она может быть перемещена или удалена.
            this.substancesTableAdapter.Fill(this.dB_Descriptors_1DataSet.Substances);

        }
        double Sol;
        private void Btn_Show_Solub_Click(object sender, EventArgs e)
        {
            Sol = x_d1 * Values[0] + x_d2 * Values[1] + x_p * 101325 + x_T * 298;
            txb_sol.Text = Convert.ToString(Sol);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

   
    }
}
