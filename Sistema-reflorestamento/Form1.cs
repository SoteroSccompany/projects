using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SituaçãoDeAprendizagem
{
    public partial class Form1 : Form
    {
        ClassCliente cliente = new ClassCliente();

        int paramet;
        public Form1(int tipoUser)
        {
            InitializeComponent();
            frnHome1.BringToFront();
            paramet = tipoUser;
            
        }
      
        private void btnHome_Click(object sender, EventArgs e)
        {
            btnCadastroUser.Visible = false;
            btnEditUser.Visible = false;
            btnExclusao.Visible = false;
            btnCadastroReflorest.Visible = false;
            btnEdirFlore.Visible = false;
            button1.Visible = false;
            pnlAcompanharButon.Height = btnHome.Height;
            pnlAcompanharButon.Top = btnHome.Top;
            frnHome1.BringToFront();
        

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            btnEditUser.Visible = true;
            btnExclusao.Visible = true;
            btnCadastroUser.Visible = true;
            btnCadastroReflorest.Visible = false;
            btnEdirFlore.Visible = false;
            button1.Visible = false;
            pnlAcompanharButon.Height = btnCadastrar.Height;
            pnlAcompanharButon.Top = btnCadastrar.Top;
            frnRegiatrarUsuario1.BringToFront();
        }

        private void btnDesmatamento_Click(object sender, EventArgs e)
        {
            btnCadastroUser.Visible = false;
            btnEditUser.Visible = false;
            btnExclusao.Visible = false;
            btnCadastroReflorest.Visible = true;
            btnEdirFlore.Visible = true;
            button1.Visible = true;
            pnlAcompanharButon.Height = btnDesmatamento.Height;
            pnlAcompanharButon.Top = btnDesmatamento.Top;
            uscCadastrarReflorest1.BringToFront();
           
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            uscrCalcul1.uscrCalcul_Load(sender, e);
            btnCadastroUser.Visible = false;
            btnEditUser.Visible = false;
            btnExclusao.Visible = false;
            btnCadastroReflorest.Visible = false;
            btnEdirFlore.Visible = false;
            button1.Visible = false;
            uscrCalcul1.BringToFront();
            pnlAcompanharButon.Height = btnCalculo.Height;
            pnlAcompanharButon.Top = btnCalculo.Top;
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            pnlAcompanharButon.Height = btnSair.Height;
            pnlAcompanharButon.Top = btnSair.Top;
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (paramet == 0)
            {
                
                
                btnCadastrar.Visible = true;

            }
            else
            {
                btnCadastrar.Visible = false;

            }

        }

        private void frnRegiatrarUsuario1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastroUser_Click(object sender, EventArgs e)
        {
            frnRegiatrarUsuario1.FrnRegiatrarUsuario_Load(sender, e);
            frnRegiatrarUsuario1.BringToFront();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {

            uscrEditUser1.UscrEditUser_Load(sender,e);

            // private void UscrEditUser_Load(object sender, EventArgs e)

            uscrEditUser1.BringToFront();
        }

        private void uscrEditUser1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void usrcExclusão_de_cliente1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExclusao_Click(object sender, EventArgs e)
        {
            usrcExclusão_de_cliente1.UsrcExclusão_de_cliente_Load(sender, e);
            usrcExclusão_de_cliente1.BringToFront();
        }

        private void frnRegiatrarUsuario2_Load(object sender, EventArgs e)
        {

        }

        private void usrcExclusão_de_cliente1_Load_1(object sender, EventArgs e)
        {

        }

        

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            lblData.Text = dt.ToLongDateString() + "    " + dt.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnCadastroUser.Visible = false;
            btnEditUser.Visible = false;
            btnExclusao.Visible = false;
            btnCadastroReflorest.Visible = false;
            btnEdirFlore.Visible = false;
            button1.Visible = false;
      
        }

        private void btnCadastroReflorest_Click(object sender, EventArgs e)
        {
            uscCadastrarReflorest1.UscCadastrarReflorest_Load(sender, e);
            uscCadastrarReflorest1.BringToFront();
        }

        private void btnEdirFlore_Click(object sender, EventArgs e)
        {
            uscrEditarDesmatamento1.uscrEditarDesmatamento_Load(sender, e);
            uscrEditarDesmatamento1.BringToFront();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            uscrExclusãoDesmatamento1.uscrExclusãoDesmatamento_Load(sender, e);
            uscrExclusãoDesmatamento1.BringToFront();
        }

        private void uscrCalcul1_Load(object sender, EventArgs e)
        {

        }
    }
}
