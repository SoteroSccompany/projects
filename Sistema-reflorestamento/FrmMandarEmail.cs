using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SituaçãoDeAprendizagem
{
    public partial class FrmMandarEmail : Form
    {
        public FrmMandarEmail()
        {
            InitializeComponent();
        }
        ClassCliente cliente = new ClassCliente();
        ClassAcessoBD bd = new ClassAcessoBD();
        private void button1_Click(object sender, EventArgs e)
        {
            cliente.Email = txtEmail.Text;
            string log = "", emaill;

            bd.Conectar();
            //WHERE loginn like '{0}' and senha like '{1}'", Login, Senha
            //OBS: utilização do break para pauusar uma determnada ação ao chegar em um ponto desejado 
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Usuario WHERE email LIKE '{0}'", txtEmail.Text));
            bd.Desconectar();            
            
            emaill = dt.Rows[0]["senha"].ToString();
            log = dt.Rows[0]["loginn"].ToString();


            if (cliente.VerificarEmailBdEmail(txtEmail.Text) == true)
            {
                try
                {
                    var email = new SmtpClient("smtp.gmail.com", 587)
                    {
                        Credentials = new NetworkCredential("2018senai22@gmail.com", "caetes741"),
                        EnableSsl = true
                    };


                    email.Send("2018senai22@gmail.com", txtEmail.Text, "RECUPERAÇÃO DE SENHA", "SUA SENHA É : " + emaill + " \n SEU LOGIN: "+ log);

                    MessageBox.Show("Email enviado com sucesso");
                    txtEmail.Text = "";
                    this.Close();
                    
                }
                catch
                {
                    MessageBox.Show("HOUVE ERRO AO MANDAR O EMAIL");
                    //txtEmail.Text = "";
                }
           }
            else
            {
                MessageBox.Show("Este email, não esta cadastrado no Sistema","ATENÇÃO",MessageBoxButtons.OK);
                txtEmail.Text = "";
            }



        }

        private void FrmMandarEmail_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
