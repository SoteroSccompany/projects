using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SituaçãoDeAprendizagem
{
    public partial class uscrCalcul : UserControl
    {
        public uscrCalcul()
        {
            InitializeComponent();
        }
        ClassReflorestamento reflo = new ClassReflorestamento();
        ClassCliente cliente = new ClassCliente();
        double resul, val = 0;
        double result1, val1 = 0;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculo2_Click(object sender, EventArgs e)
        {
            if (TXTREFLORE.Text == "")
            {
                MessageBox.Show("CLIQUE NO REFLORESTAMENTO DESEJADO \n DEPOIS CLIQUE DENOVO NO BOTÃO");
            }
            else
            {
                reflo.CodReflorestamento = int.Parse(TXTREFLORE.Text);
                reflo.ArvoreAPagar = resul;
                reflo.ArvoreARepor =int.Parse(result1.ToString());
                reflo.CadastrarPAg();
                txtNArvoresARepor.Text = result1.ToString();
                maskedTextBox1.Text = resul.ToString();

            }
        }

        public void uscrCalcul_Load(object sender, EventArgs e)
        {
            dvgRetInfo.DataSource = reflo.RetTodasInfo2();
            lblCodUser.Text = cliente.Iduser.ToString();
        }

        private void btnCalculo1_Click(object sender, EventArgs e)
        {
            if (TXTREFLORE.Text == "")
            {
                MessageBox.Show("CLIQUE NO REFLORESTAMENTO DESEJADO \n DEPOIS CLIQUE DENOVO NO BOTÃO");
            }
            else
            {
                reflo.CodReflorestamento = int.Parse(TXTREFLORE.Text);
                reflo.ArvoreAPagar = resul;
                reflo.ArvoreARepor = int.Parse(result1.ToString());
                reflo.CadastrarPAg();
                dvgRetInfo.DataSource = reflo.RetTodasInfo2();
                txtNArvoresARepor.Text = result1.ToString();
                maskedTextBox1.Text = resul.ToString();

            }
        }

        private void dvgRetInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTREFLORE.Text = dvgRetInfo.Rows[e.RowIndex].Cells["codCalculo"].Value.ToString();
            val = double.Parse(dvgRetInfo.Rows[e.RowIndex].Cells["numArvoresCortadas"].Value.ToString());
            val1 = double.Parse(dvgRetInfo.Rows[e.RowIndex].Cells["volumeM3"].Value.ToString());
            resul = val * 0.75 ;
            result1 = val1 * 6;

        }
    }
}
