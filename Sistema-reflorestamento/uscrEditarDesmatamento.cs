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
    public partial class uscrEditarDesmatamento : UserControl
    {
        public uscrEditarDesmatamento()
        {
            InitializeComponent();
        }
        ClassCliente cliente = new ClassCliente();
        ClassReflorestamento reflore = new ClassReflorestamento();
        public void uscrEditarDesmatamento_Load(object sender, EventArgs e)
        {
            lblCodUser.Text = cliente.Iduser.ToString();
            dvgTabelasDoBanco.DataSource = reflore.RetTodasInfo();
            txtUsuarioresp.Text = cliente.Iduser.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool ehvaliido;
            if (ehvaliido = txtBusca.Text.All(char.IsDigit) == true)
            {
                dvgTabelasDoBanco.DataSource = reflore.RetReflorePorAno(txtBusca.Text);
            }
            else
            {
                dvgTabelasDoBanco.DataSource = reflore.RetReflorePorEstado(txtBusca.Text);
            } 
        }

        private void dvgTabelasDoBanco_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAno.Text = dvgTabelasDoBanco.Rows[e.RowIndex].Cells["ano"].Value.ToString();
            lstbEstado.SelectedItem = dvgTabelasDoBanco.Rows[e.RowIndex].Cells["estado"].Value.ToString();
            txtNArvores.Text = dvgTabelasDoBanco.Rows[e.RowIndex].Cells["numArvoresCortadas"].Value.ToString();
            txtVolumeArvores.Text = dvgTabelasDoBanco.Rows[e.RowIndex].Cells["volumeM3"].Value.ToString();
            lblDesmatamento.Text = dvgTabelasDoBanco.Rows[e.RowIndex].Cells["codCalculo"].Value.ToString();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            bool ehvalido;
            if (txtAno.Text != "" && txtNArvores.Text != "" && txtVolumeArvores.Text != "" && lstbEstado.SelectedIndex > -1)
            {
                txtAno.BackColor = Color.White;
                txtNArvores.BackColor = Color.White;
                txtVolumeArvores.BackColor = Color.White;
                lstbEstado.BackColor = Color.White;

                if (ehvalido = txtAno.Text.All(char.IsDigit) == true && (ehvalido = txtNArvores.Text.All(char.IsDigit) == true) && (ehvalido = txtVolumeArvores.Text.All(char.IsDigit) == true))
                {
                    int a, b;
                    a = int.Parse(txtAno.Text);
                    DateTime dt = DateTime.Now;
                    b = int.Parse(dt.ToString("yyyy"));

                    if (a <= b)
                    {
                        reflore.CodReflorestamento = int.Parse(lblDesmatamento.Text);
                        reflore.Ano = int.Parse(txtAno.Text);
                        reflore.Estado = lstbEstado.SelectedItem.ToString();
                        reflore.NarvoresCortadas = int.Parse(txtNArvores.Text);
                        reflore.VolumeM3 = double.Parse(txtVolumeArvores.Text);
                        reflore.EditarDados(reflore.CodReflorestamento);
                        dvgTabelasDoBanco.DataSource = reflore.RetTodasInfo();
                        MessageBox.Show("Edição realizada com sucesso","NOTIFICAÇÃO",MessageBoxButtons.OK);
                        
                    }
                    else
                    {
                        txtAno.BackColor = Color.Red;
                        MessageBox.Show("O ano indicado é maior que o ano atual \n portanto não pode ser inserido", "ATENÇÃO", MessageBoxButtons.OK);
                    }
                }
                else if (ehvalido = txtAno.Text.All(char.IsDigit) == false)
                {
                    txtAno.BackColor = Color.Red;
                    MessageBox.Show("Prencha os campos apenas com números", "ATENÇÃO", MessageBoxButtons.OK);
                }
                else if (ehvalido = txtNArvores.Text.All(char.IsDigit) == false )
                {
                    txtNArvores.BackColor = Color.Red;
                    MessageBox.Show("Prencha os campos apenas com números", "ATENÇÃO", MessageBoxButtons.OK);
                }
                else if (ehvalido = txtVolumeArvores.Text.All(char.IsDigit) == false )
                {
                    txtVolumeArvores.BackColor = Color.Red;
                    MessageBox.Show("Prencha os campos apenas com números", "ATENÇÃO", MessageBoxButtons.OK);
                }

            }
            else if (txtAno.Text == "")
            {
                txtAno.BackColor = Color.Red;

                MessageBox.Show("Prencha todos os campos para continuar", "ATENÇÃO", MessageBoxButtons.OK);
            }
            else if (txtNArvores.Text == "")
            {
                txtNArvores.BackColor = Color.Red;
                MessageBox.Show("Prencha todos os campos para continuar", "ATENÇÃO", MessageBoxButtons.OK);
            }
            else if (txtVolumeArvores.Text == "")
            {
                txtVolumeArvores.BackColor = Color.Red;
                MessageBox.Show("Prencha todos os campos para continuar", "ATENÇÃO", MessageBoxButtons.OK);
            }
            else if (lstbEstado.SelectedIndex == -1)
            {
                lstbEstado.BackColor = Color.Red;
                MessageBox.Show("Escolha um estado para continuar", "ATENÇÃO", MessageBoxButtons.OK);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lblDesmatamento_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lstbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCodUser_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtVolumeArvores_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuarioresp_TextChanged(object sender, EventArgs e)
        {

        }

        private void dvgTabelasDoBanco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtNArvores_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
