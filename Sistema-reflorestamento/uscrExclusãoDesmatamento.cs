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
    public partial class uscrExclusãoDesmatamento : UserControl
    {
        public uscrExclusãoDesmatamento()
        {
            InitializeComponent();
        }
        ClassReflorestamento reflore = new ClassReflorestamento();
        ClassCliente cliente = new ClassCliente();
        public void uscrExclusãoDesmatamento_Load(object sender, EventArgs e)
        {
            dvgTabelasDoBanco.DataSource = reflore.RetTodasInfo();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
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

        private void btnEXCLUIR_Click(object sender, EventArgs e)
        {
            reflore.CodReflorestamento =int.Parse(lblDesmatamento.Text);
            
            if (txtValidação.Text == "admin")
            {
                reflore.Excluir(reflore.CodReflorestamento);
                MessageBox.Show("AÇÃO REALIZADA COM SUCESSO");
                dvgTabelasDoBanco.DataSource = reflore.RetTodasInfo();
            }
            else
            {
                MessageBox.Show("SENHA DE ADM INCORRETA \n TENTE NOVAMENTE","ATENÇÃO",MessageBoxButtons.OK);
            }
        }
    }
}
