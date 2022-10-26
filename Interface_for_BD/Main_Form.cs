using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Interface_for_BD
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Open_BD_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Server=LAPTOP-1ttvm3h5 ; Database=DB_Descriptors_1;Trusted_Connection=True; ";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var id = reader.GetValue(0);
                        var Marker = reader.GetValue(1);
                        var Name = reader.GetValue(2);
                        var Description = reader.GetValue(3);
                    }
                }
            }
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_Descriptors_1DataSet.Descriptors". При необходимости она может быть перемещена или удалена.
            this.descriptorsTableAdapter.Fill(this.dB_Descriptors_1DataSet.Descriptors);

        }

        private void Open_Descriptors_Click(object sender, EventArgs e)
        {
            Descriptors_View descriptors_view = new Descriptors_View();
            descriptors_view.Show();
        }

        private void Open_Points_Click(object sender, EventArgs e)
        {
            Points_View points_view = new Points_View();
            points_view.Show();
        }

        private void Open_Substances_Click(object sender, EventArgs e)
        {
            Substances_View substances_view = new Substances_View();
            substances_view.Show();
        }

        private void Open_Density_Click(object sender, EventArgs e)
        {
            Density_View density_view = new Density_View();
            density_view.Show();
        }
    }
}
