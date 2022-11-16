using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Interface_for_BD
{
    public partial class Full_Table : Form
    {
        public Full_Table()
        {
            InitializeComponent();
        }

        private void btn_table_view_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Server=LAPTOP-1ttvm3h5; Database=DB_Descriptors_1;Trusted_Connection=True; ";

            using (SqlConnection connection_2 = new SqlConnection(ConnectionString))
            {
                Exp_view.Rows.Clear();
                connection_2.Open();
                string selectedState = cb_sub_name.SelectedValue.ToString();             
                string query_2 = string.Format("SELECT Points.ExperimentId, Points.Value, Points.Temperature, Points.Pressure FROM Experiments, Points, Substances WHERE Points.ExperimentId = Experiments.Id AND  Experiments.SubstanceId = Substances.Id AND Substances.Id = {0}", selectedState);
                SqlCommand command_2 = new SqlCommand(query_2, connection_2);
                SqlDataReader reader_2 = command_2.ExecuteReader();
                if (reader_2.HasRows)
                {
                    while (reader_2.Read())
                    {
                        var Id = reader_2.GetValue(0);
                        var Solubility = reader_2.GetValue(1);
                        var Temperature = reader_2.GetValue(2);
                        var Pressure = reader_2.GetValue(3);
                        Exp_view.Rows.Add(Id, Solubility, Temperature, Pressure);
                    }
                }
            }
        }

        private void Full_Table_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_Descriptors_1DataSet.Substances". При необходимости она может быть перемещена или удалена.
            this.substancesTableAdapter.Fill(this.dB_Descriptors_1DataSet.Substances);

        }

        private void Full_Table_View_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_table_view_2_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Server=LAPTOP-1ttvm3h5; Database=DB_Descriptors_1;Trusted_Connection=True; ";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                Full_Table_View.Rows.Clear();
                connection.Open();
                string selectedState = cb_sub_name.SelectedValue.ToString();
                string query = string.Format("SELECT Substances.Id, Descriptors.Name, DescriptorsDictionary.Value FROM  Descriptors, Substances, DescriptorsDictionary WHERE Descriptors.Id = DescriptorsDictionary.DescriptorId AND Substances.Id = DescriptorsDictionary.SubstanceId AND Substances.Id = {0} AND Descriptors.Name IS NOT NULL", selectedState);
                string query_2 = string.Format("SELECT Points.ExperimentId, Points.Value, Points.Temperature, Points.Pressure FROM Experiments, Points, Substances WHERE Points.ExperimentId = Experiments.Id AND  Experiments.SubstanceId = Substances.Id AND Substances.Id = {0}", selectedState);
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();


                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var Id = reader.GetValue(0);
                        var Name_of_substance = reader.GetValue(1);
                        var Name_of_descriptor = reader.GetValue(2);
                        Full_Table_View.Rows.Add(Id, Name_of_substance, Name_of_descriptor);
                    }
                }


            }
        }
    }
}
