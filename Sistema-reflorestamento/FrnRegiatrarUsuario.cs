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
    public partial class FrnRegiatrarUsuario : UserControl
    {
        
        public FrnRegiatrarUsuario()
        {
            InitializeComponent();
            
        }
        
        ClassCliente cliente = new ClassCliente();
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string login = "" ; 

            for (int i = 0; i < txtEmail.Text.Length; i++)//Legth para ir ao tamanho da string 
            {
                if (txtEmail.Text[i] != '@')//tinha que usar aspas simples pois é char;
                {
                    login += txtEmail.Text[i];
                    txtLogin.Text = login;
                }
                else if(txtEmail.Text[i] == '@')
                {
                    login = "";
                    break;
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dvgTabelasDoBanco.DataSource = cliente.RetTodasInfo();
        }

        public void FrnRegiatrarUsuario_Load(object sender, EventArgs e)
        {
            dvgTabelasDoBanco.DataSource = cliente.RetTodasInfo();
            lblCodUser.Text = cliente.Iduser.ToString();
            txtUsuarioresp.Text = cliente.Iduser.ToString();
            dvgTabelasDoBanco.DataSource = cliente.RetTodasInfo();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            bool ehValidoO;
            bool ehValido;
            string verificarLetra;
            cliente.Cpf = mskCpf.Text;
            verificarLetra = mskCpf.Text;
            ehValido = verificarLetra.All(char.IsDigit);
            
                if (ehValido == true)
                {
                    cliente.Cpf = mskCpf.Text;
                ehValido = mskCpf.Text.Length == 11;
                if(ehValido == true)
                {
                    cliente.Cpf = mskCpf.Text;
                }
                else
                {
                   mskCpf.BackColor = Color.Red;
                    MessageBox.Show("Digite 11 digitos no campo cpf","ATENÇÃO",MessageBoxButtons.OK);
                    mskCpf.Text = "";
                    mskCpf.BackColor = Color.White;
                }
                }
                else
                {
                   mskCpf.BackColor = Color.Red;
                    MessageBox.Show("Digite apenas números no cpf", "Atenção", MessageBoxButtons.OK);
                    mskCpf.Text = "";
                    mskCpf.BackColor = Color.White;

                }
            
            if (cliente.Verifica(txtSenha.Text) == true)
            {
                ehValidoO = txtSenha.Text.Length == 6;
                if (ehValidoO == true)
                {
                    cliente.Senha = txtSenha.Text;
                    //Lembrar semore do conceito de variavel
                    //esta na ram.
                    //VARIAVEL
                }
                else
                {
                    MessageBox.Show("Sua senha deve conter apenas 6 caracteres", "ATENÇÃO", MessageBoxButtons.OK);
                }

            }
            else
            {
                txtSenha.BackColor = Color.Red;
                MessageBox.Show("A senha deve conter letras e números","ATENÇÃO",MessageBoxButtons.OK);
                txtSenha.Text = "";
                txtSenha.BackColor = Color.White;
            }

            
            if (txtNome.Text != "" && mskTel.Text != "" && mskCpf.Text != "" && txtEmail.Text != "" && txtLogin.Text != "" && txtSenha.Text != "" && txttipoDeUsuario.Text != "")
            {
                
                
                string email = txtEmail.Text;
                cliente.Email = txtEmail.Text;
                Regex regVerificar = new Regex("^[A-Za-z0-9](([_.-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([.-]?[a-zA-Z0-9]+)*)([.][A-Za-z]{2,4})$");
                Match teste = regVerificar.Match(email);
                if (teste.Success && cliente.VerificarEmailBd() == true)
                {
                    cliente.Cpf = mskCpf.Text;
                    txtEmail.BackColor = Color.White;
                    cliente.Nome = txtNome.Text;
                    cliente.Telefone = mskTel.Text;
                    cliente.Email = txtEmail.Text;
                    cliente.Login = txtLogin.Text;
                    cliente.Senha = txtSenha.Text;
                    cliente.TipoUsuario = int.Parse(txttipoDeUsuario.Text);
                    cliente.CodUsuarioResp = int.Parse(txtUsuarioresp.Text);
                  
                    if (cliente.VerificarCpfBD() == true)
                    {
                        cliente.Cpf = mskCpf.Text;
                        cliente.InseriDados();
                        dvgTabelasDoBanco.DataSource = cliente.RetTodasInfo();
                        //Tem ue colocar tudo de novo nos metodos, pois aqui é um botão ele só colocará quando aqui.
                        txtNome.Text = "";
                        mskTel.Text = "";
                        mskCpf.Text = "";
                        txtEmail.Text = "";
                        txtEmail.Text = "";
                        txtLogin.Text = "";
                        txtSenha.Text = "";
                        txttipoDeUsuario.Text = "";
                    }
                    else if (cliente.VerificarCpfBD() == false)
                    {
                        MessageBox.Show("Já existe essa pessoa cadastrada no sistema \n Cadastre uma nova para prosseguir", "Atenção", MessageBoxButtons.OK);
                        txtNome.Text = "";
                        mskTel.Text = "";
                        mskCpf.Text = "";
                        txtEmail.Text = "";
                        txtEmail.Text = "";
                        txtLogin.Text = "";
                        txtSenha.Text = "";
                        txttipoDeUsuario.Text = "";
                    }
                    
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
                if (mskTel.Text == "")
                {
                    mskTel.BackColor = Color.Red;
                }
                else
                {
                    mskTel.BackColor = Color.White;
                }
                if (mskCpf.Text == "")
                {
                    mskCpf.BackColor = Color.Red;
                }
                else
                {
                    mskCpf.BackColor = Color.White;
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
                mskTel.BackColor = Color.White;
                mskCpf.BackColor = Color.White;
                txtEmail.BackColor = Color.White;
                txtEmail.BackColor = Color.White;
                txtLogin.BackColor = Color.White;
                txtSenha.BackColor = Color.White;
                txttipoDeUsuario.BackColor = Color.White;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void dvgTabelasDoBanco_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtNome.Text = dvgTabelasDoBanco.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            mskTel.Text = dvgTabelasDoBanco.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
            mskCpf.Text = dvgTabelasDoBanco.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
            txtEmail.Text = dvgTabelasDoBanco.Rows[e.RowIndex].Cells["email"].Value.ToString();   
            txtLogin.Text = dvgTabelasDoBanco.Rows[e.RowIndex].Cells["loginn"].Value.ToString();
            txtSenha.Text = dvgTabelasDoBanco.Rows[e.RowIndex].Cells["senha"].Value.ToString();
            txttipoDeUsuario.Text = dvgTabelasDoBanco.Rows[e.RowIndex].Cells["tipoUsuario"].Value.ToString();
            lblCodUser.Text = dvgTabelasDoBanco.Rows[e.RowIndex].Cells["codUsuario"].Value.ToString();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cliente.Nome = txtNome.Text;
            cliente.Telefone = mskTel.Text;
            cliente.Cpf = mskCpf.Text;
            cliente.Email = txtEmail.Text;
            cliente.Login = txtLogin.Text;
            cliente.Senha = txtSenha.Text;
            cliente.TipoUsuario = int.Parse(txttipoDeUsuario.Text);
            DataTable dt = cliente.logar();
            cliente.Iduser = int.Parse(dt.Rows[0]["codUsuario"].ToString());
            cliente.Excluir(cliente.Iduser);
        }

        private void txtUsuarioresp_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}