using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_SomadorDeNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            double n1, n2, total;
            n1 = Convert.ToDouble(txtNumero1.Text);
            n2 = Convert.ToDouble(txtNumero2.Text);
            total = n1 + n2;
            txtTotal.Text = total.ToString();
        }
    }
}
