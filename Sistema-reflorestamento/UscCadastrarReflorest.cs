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
    public partial class UscCadastrarReflorest : UserControl
    {
        public UscCadastrarReflorest()
        {
            InitializeComponent();
        }

        ClassReflorestamento reflore = new ClassReflorestamento();
        ClassCliente cliente = new ClassCliente();
       

        private void btnCadastrar_Click(object sender, EventArgs e)
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
                        reflore.Ano = int.Parse(txtAno.Text);
                        reflore.Estado = lstbEstado.Text;
                        reflore.NarvoresCortadas = int.Parse(txtNArvores.Text);
                        reflore.VolumeM3 = double.Parse(txtVolumeArvores.Text);
                        //reflore.CodUsuarioResp = cliente.Iduser;
                        reflore.CadastrarReflorestamento();
                        MessageBox.Show("AÇÃO REALIZADA COM SUCESSO");
                        dvgTabelasDoBanco.DataSource = reflore.RetTodasInfo();
                    }
                    else
                    {
                        txtAno.BackColor = Color.Red;
                        MessageBox.Show("O ano indicado é maior que o ano atual \n portanto não pode ser inserido","ATENÇÃO",MessageBoxButtons.OK);
                    }
                }
                else if (ehvalido = txtAno.Text.All(char.IsDigit) == false)
                {
                    txtAno.BackColor = Color.Red;
                    MessageBox.Show("Prencha os campos apenas com números","ATENÇÃO",MessageBoxButtons.OK);
                }
                else if (ehvalido = txtNArvores.Text.All(char.IsDigit) == false)
                {
                    txtNArvores.BackColor = Color.Red;
                    MessageBox.Show("Prencha os campos apenas com números", "ATENÇÃO", MessageBoxButtons.OK);
                }
                else if (ehvalido = txtVolumeArvores.Text.All(char.IsDigit) == false)
                {
                    txtVolumeArvores.BackColor = Color.Red;
                    MessageBox.Show("Prencha os campos apenas com números", "ATENÇÃO", MessageBoxButtons.OK);
                }

            }
            else if (txtAno.Text == "")
            {
                txtAno.BackColor = Color.Red;
                
                MessageBox.Show("Prencha todos os campos para continuar","ATENÇÃO",MessageBoxButtons.OK);
            }
            else if ((txtNArvores.Text == "") && (txtVolumeArvores.Text != ""))
            {
                txtNArvores.Text = "null";
            }
            else if ((txtNArvores.Text != "") && (txtVolumeArvores.Text == ""))
            {
                txtVolumeArvores.Text = "null";
            }
            else if ((txtNArvores.Text == "") && (txtVolumeArvores.Text == ""))
            {
                txtVolumeArvores.BackColor = Color.Red;
                txtNArvores.BackColor = Color.Red;
                MessageBox.Show("Escolha um estado para continuar", "ATENÇÃO", MessageBoxButtons.OK);
            }
            else if (lstbEstado.SelectedIndex == -1)
            {
                lstbEstado.BackColor = Color.Red;
                MessageBox.Show("Escolha um estado para continuar", "ATENÇÃO", MessageBoxButtons.OK);
            }
        }
        public void UscCadastrarReflorest_Load(object sender, EventArgs e)
        {
            dvgTabelasDoBanco.DataSource = reflore.RetTodasInfo();
            lblCodUser.Text = cliente.Iduser.ToString();
            txtUsuarioresp.Text = cliente.Iduser.ToString();
        }

        private void txtUsuarioresp_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCodUser_Click(object sender, EventArgs e)
        {

        }
    }
}
