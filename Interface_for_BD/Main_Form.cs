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
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Open_BD_Click(object sender, EventArgs e)
        {
            Full_Table full_table= new Full_Table();
            full_table.Show();
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
