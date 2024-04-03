using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Carros
{
    public partial class Atividade2 : Form
    {
        public Atividade2()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu tela1 = new Menu();
            tela1.Show();
        }

        private void lblMnadados_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double MetrosN, DinheiroRec;
            MetrosN = Convert.ToDouble(txtM.Text);
            if (MetrosN < 800)
                DinheiroRec = 5000.00;
            else if (MetrosN >= 800 && MetrosN < 1500)
                DinheiroRec = 10000;
            else
                DinheiroRec = 15000;
            txtDinRec.Text = DinheiroRec.ToString();

        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtM.Clear();
            txtDinRec.Clear();
        }
    }
}
