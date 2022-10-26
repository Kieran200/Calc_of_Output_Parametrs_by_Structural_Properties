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
    public partial class Points_View : Form
    {
        public Points_View()
        {
            InitializeComponent();
        }

        private void Point_View_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_Descriptors_1DataSet.Points". При необходимости она может быть перемещена или удалена.
            this.pointsTableAdapter.Fill(this.dB_Descriptors_1DataSet.Points);

        }
    }
}
