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
    public partial class Descriptors_View : Form
    {
        public Descriptors_View()
        {
            InitializeComponent();
        }

        private void Descriptors_View_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_Descriptors_1DataSet.Descriptors". При необходимости она может быть перемещена или удалена.
            this.descriptorsTableAdapter.Fill(this.dB_Descriptors_1DataSet.Descriptors);

        }
    }
}
