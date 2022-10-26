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
    public partial class Substances_View : Form
    {
        public Substances_View()
        {
            InitializeComponent();
        }

        private void Substances_View_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_Descriptors_1DataSet.Substances". При необходимости она может быть перемещена или удалена.
            this.substancesTableAdapter.Fill(this.dB_Descriptors_1DataSet.Substances);

        }
    }
}
