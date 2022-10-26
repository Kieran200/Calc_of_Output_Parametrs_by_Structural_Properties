using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_for_BD
{
    public partial class Density_View : Form
    {
        public Density_View()
        {
            InitializeComponent();
        }

        private void Density_View_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_Descriptors_1DataSet.Density". При необходимости она может быть перемещена или удалена.
            this.densityTableAdapter.Fill(this.dB_Descriptors_1DataSet.Density);

        }
    }
}
