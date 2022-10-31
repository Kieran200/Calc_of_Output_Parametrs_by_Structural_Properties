using System;
using System.Data.SqlClient;
using System.Windows.Forms;

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
           

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT DISTINCT Substances.Id, Substances.Name, Descriptors.Name FROM Descriptors, Substances, DescriptorsDictionary WHERE Descriptors.Id = DescriptorsDictionary.DescriptorId AND Substances.Id = DescriptorsDictionary.SubstanceId AND Descriptors.Name IS NOT NULL";
                
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
