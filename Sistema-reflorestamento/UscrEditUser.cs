using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SituaçãoDeAprendizagem
{
    public partial class UscrEditUser : UserControl
    {
        public UscrEditUser()
        {
            InitializeComponent();
        }
        ClassCliente cliente = new ClassCliente();
        private void dvgTabelasDoBanco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public void UscrEditUser_Load(object sender, EventArgs e)
        {
            dvgTabelasDoBanco.DataSource = cliente.RetTodasInfo();
            lblCodUserEdit.Text = cliente.Iduser.ToString();

        }

        private void dvgTabelasDoBanco_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNome.Text = dvgTabelasDoBanco.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txttel.Text = dvgTabelasDoBanco.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
            txtcpf.Text = dvgTabelasDoBanco.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
            txtEmail.Text = dvgTabelasDoBanco.Rows[e.RowIndex].Cells["email"].Value.ToString();
            txtLogin.Text = dvgTabelasDoBanco.Rows[e.RowIndex].Cells["loginn"].Value.ToString();
            txtSenha.Text = dvgTabelasDoBanco.Rows[e.RowIndex].Cells["senha"].Value.ToString();
            txttipoDeUsuario.Text = dvgTabelasDoBanco.Rows[e.RowIndex].Cells["tipoUsuario"].Value.ToString();
            lblCodUserEdit.Text = dvgTabelasDoBanco.Rows[e.RowIndex].Cells["codUsuario"].Value.ToString();

        }
       
        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            
            if (cliente.Verifica(txtcpf.Text) == false)
            {                
                if (txtcpf.Text.Length == 11)
                {
                    cliente.Cpf = txtcpf.Text;
                }
                else
                {
                    txtcpf.BackColor = Color.Red;
                    MessageBox.Show("Digite 11 digitos no campo cpf", "ATENÇÃO", MessageBoxButtons.OK);
                    txtcpf.Text = "";
                    txtcpf.BackColor = Color.White;
                }
            }
            else
            {
                txtcpf.BackColor = Color.Red;
                MessageBox.Show("Digite apenas números no cpf", "Atenção", MessageBoxButtons.OK);
                txtcpf.Text = "";
                txtcpf.BackColor = Color.White;

            }
            if (cliente.Verifica(txtSenha.Text) == true)
            {
                 
                if (txtSenha.Text.Length == 6)
                {
                    cliente.Senha = txtSenha.Text;
                    //Lembrar semore do conceito de variavel
                    //esta na ram.
                    //VARIAVEL
                }
                else
                {
                    MessageBox.Show("Sua senha deve conter apenas 6 caracteres", "ATENÇÃO", MessageBoxButtons.OK);
                    txtSenha.Text = "";
                }

            }
            else
            {
                txtSenha.BackColor = Color.Red;
                txtSenha.Text = "";
                MessageBox.Show("A senha deve conter letras e números", "ATENÇÃO", MessageBoxButtons.OK);
                txtSenha.BackColor = Color.White;
            }


            if (txtNome.Text != "" && txttel.Text != "" && txtcpf.Text != "" && txtEmail.Text != "" && txtLogin.Text != "" && txtSenha.Text != "" && txttipoDeUsuario.Text != "")
            {


                string email = txtEmail.Text;
                cliente.Email = txtEmail.Text;
                Regex regVerificar = new Regex("^[A-Za-z0-9](([_.-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([.-]?[a-zA-Z0-9]+)*)([.][A-Za-z]{2,4})$");
                Match teste = regVerificar.Match(email);
                if (teste.Success)
                {

                    cliente.Cpf = txtcpf.Text;
                    txtEmail.BackColor = Color.White;
                    cliente.Nome = txtNome.Text;
                    cliente.Telefone = txttel.Text;
                    cliente.Email = txtEmail.Text;
                    cliente.Login = txtLogin.Text;
                    cliente.Senha = txtSenha.Text;
                    cliente.TipoUsuario = int.Parse(txttipoDeUsuario.Text);
                    cliente.Iduser =int.Parse(lblCodUserEdit.Text);
                        cliente.EditarDados(cliente.Iduser);
                    MessageBox.Show("AÇÃO REALIZADA COM SUCESSO");
                        dvgTabelasDoBanco.DataSource = cliente.RetTodasInfo();
                        //Tem ue colocar tudo de novo nos metodos, pois aqui é um botão ele só colocará quando aqui.
                        txtNome.Text = "";
                        txttel.Text = "";
                        txtcpf.Text = "";
                        txtEmail.Text = "";
                        txtEmail.Text = "";
                        txtLogin.Text = "";
                        txtSenha.Text = "";
                        txttipoDeUsuario.Text = "";
                   

                }
                else
                {
                    txtEmail.BackColor = Color.Red;
                    MessageBox.Show("Email invalido ou já cadastrado \n Tente um diferente", "ATENÇÃO", MessageBoxButtons.OK);
                    txtEmail.Text = "";
                    txtEmail.BackColor = Color.White;
                }

            }
            else
            {
                if (txtNome.Text == "")
                {
                    txtNome.BackColor = Color.Red;
                }
                else
                {
                    txtNome.BackColor = Color.White;
                }
                if (txttel.Text == "")
                {
                    txttel.BackColor = Color.Red;
                }
                else
                {
                    txttel.BackColor = Color.White;
                }
                if (txtcpf.Text == "")
                {
                    txtcpf.BackColor = Color.Red;
                }
                else
                {
                    txtcpf.BackColor = Color.White;
                }
                if (txtEmail.Text == "")
                {
                    txtEmail.BackColor = Color.Red;
                }
                else
                {
                    txtEmail.BackColor = Color.White;
                }
                if (txtLogin.Text == "")
                {
                    txtLogin.BackColor = Color.Red;
                }
                else
                {
                    txtLogin.BackColor = Color.White;
                }
                if (txtSenha.Text == "")
                {
                    txtSenha.BackColor = Color.Red;
                }
                else
                {
                    txtSenha.BackColor = Color.White;
                }
                if (txttipoDeUsuario.Text == "")
                {
                    txttipoDeUsuario.BackColor = Color.Red;
                }
                else
                {
                    txttipoDeUsuario.BackColor = Color.White;
                }
                MessageBox.Show("PRENCHA TODOS OS CAMPOS PARA CONTINUAR", "ATENÇÃO!", MessageBoxButtons.OK);

                txtNome.BackColor = Color.White;
                txttel.BackColor = Color.White;
                txtcpf.BackColor = Color.White;
                txtEmail.BackColor = Color.White;
                txtEmail.BackColor = Color.White;
                txtLogin.BackColor = Color.White;
                txtSenha.BackColor = Color.White;
                txttipoDeUsuario.BackColor = Color.White;
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            dvgTabelasDoBanco.DataSource = cliente.RetclientePorNome(txtBusca.Text);
            
        }
    }
}
