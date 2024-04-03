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
    public partial class Atividade : Form
    {
        public Atividade()
        {
            InitializeComponent();
        }

        private void txtvalorCarro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsalarioFixo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double Sfixo, CporCarro, Numcarro, Vcarro, Stotal, Cinco;
            Sfixo = Convert.ToDouble(txtsalarioFixo.Text);
            CporCarro = Convert.ToDouble(txtcomissao.Text);
            Numcarro = Convert.ToDouble(txtnumCarros.Text);
            Vcarro = Convert.ToDouble(txtvalorCarro.Text);
            Cinco = (Numcarro * Vcarro)*0.05;
            Stotal = Sfixo + (Numcarro * CporCarro) + Cinco;
            txtsalarioTotal.Text = Stotal.ToString();
            txt5.Text = Cinco.ToString();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcomissao.Clear();
            txtvalorCarro.Clear();
            txtsalarioFixo.Clear();
            txtsalarioTotal.Clear();
            txt5.Clear();
            txtnumCarros.Clear();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu tela1 = new Menu();
            tela1.Show();
        }

        private void Atividade_Load(object sender, EventArgs e)
        {

        }
    }
}
