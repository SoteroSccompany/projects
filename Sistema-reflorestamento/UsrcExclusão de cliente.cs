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
    public partial class UsrcExclusão_de_cliente : UserControl
    {
        public UsrcExclusão_de_cliente()
        {
            InitializeComponent();
            dvgTabelasDoBanco.DataSource = cliente.RetTodasInfo();
            
        }
        ClassCliente cliente = new ClassCliente();
        private void dvgTabelasDoBanco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dvgTabelasDoBanco.DataSource = cliente.RetTodasInfo();
       
        }

        public void UsrcExclusão_de_cliente_Load(object sender, EventArgs e)
        {
            dvgTabelasDoBanco.DataSource = cliente.RetTodasInfo();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dvgTabelasDoBanco.DataSource = cliente.RetclientePorNome(txtBuscar.Text);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            cliente.Nome = txtNome.Text;
            cliente.Telefone = txttel.Text;
            cliente.Cpf = txtcpf.Text;
            cliente.Email = txtEmail.Text;
            cliente.Login = txtLogin.Text;
            cliente.Senha = txtSenha.Text;
            cliente.TipoUsuario = int.Parse(txttipoDeUsuario.Text);
            DataTable dt = cliente.logar();
            cliente.Iduser = int.Parse(dt.Rows[0]["codUsuario"].ToString());
            DialogResult result = MessageBox.Show("Deseja excluir o cliente?", "Confirmação", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                if (cliente.Excluir(cliente.Iduser) == true)
                {
                    MessageBox.Show("Exclusão feita com sucesso!","NOTIFICAÇÃO",MessageBoxButtons.OK);
                    dvgTabelasDoBanco.DataSource = cliente.RetTodasInfo();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir dados!");
                } 
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Usuário não excluido ");

            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Exclusão cancelada","NOTIFICAÇÃO",MessageBoxButtons.OK);
            }
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
            lblCodUserExclusao.Text = dvgTabelasDoBanco.Rows[e.RowIndex].Cells["codUsuario"].Value.ToString();
        }
    }
}
