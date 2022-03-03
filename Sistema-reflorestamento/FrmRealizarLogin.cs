using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace SituaçãoDeAprendizagem
{
    public partial class FrmRealizarLogin : Form
    {
        public FrmRealizarLogin()
        {
            InitializeComponent();
        }
        ClassCliente cliente = new ClassCliente();
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            cliente.Login = txtLogin.Text;
            cliente.Senha = txtSenha.Text;
            txtLogin.Text = "";
            txtSenha.Text = "";
            DataTable dt = cliente.logar();
            if (dt.Rows.Count > 0)
            {
                cliente.Iduser =int.Parse(dt.Rows[0]["codUsuario"].ToString());
                Form1 frn = new Form1(cliente.Iduser);
                //Fica salvo na variavel pois já mandei salvando para o outro formul´´ario como parametro.
               
                frn.Show();
               
            }
            else
            {
                MessageBox.Show("Login ou senha incorreto \n tente novamente ","ATENÇÃO",MessageBoxButtons.OK);
                txtLogin.Text = "";
                txtSenha.Text = "";
                
            }

                        
        }
            

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRealizarLogin_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FrmMandarEmail frm = new FrmMandarEmail();
            frm.Show();
            
            //var cliente = new SmtpClient("smtp.gmail.com", 587)
            //{
            //    Credentials = new NetworkCredential("2018senai22@gmail.com","caestes741"),
            //    EnableSsl = true
            //};

            //cliente.Send("2018senai22@gmail.com", "gabriel.soterocoimbra@gmail.com", "Assunto", "corpo");

        }
    }
}
