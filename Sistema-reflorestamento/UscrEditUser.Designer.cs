namespace SituaçãoDeAprendizagem
{
    partial class UscrEditUser
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UscrEditUser));
            this.lblCodUserEdit = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.dvgTabelasDoBanco = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txttipoDeUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTabelasDoBanco)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodUserEdit
            // 
            this.lblCodUserEdit.AutoSize = true;
            this.lblCodUserEdit.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodUserEdit.Location = new System.Drawing.Point(609, 25);
            this.lblCodUserEdit.Name = "lblCodUserEdit";
            this.lblCodUserEdit.Size = new System.Drawing.Size(17, 24);
            this.lblCodUserEdit.TabIndex = 57;
            this.lblCodUserEdit.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(384, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(203, 24);
            this.label13.TabIndex = 56;
            this.label13.Text = "CODIGO DE USUÁRIO:";
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Comic Sans MS", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(847, 293);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(99, 34);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "       EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(456, 98);
            this.txttel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(147, 22);
            this.txttel.TabIndex = 2;
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(93, 174);
            this.txtcpf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(147, 22);
            this.txtcpf.TabIndex = 4;
            // 
            // dvgTabelasDoBanco
            // 
            this.dvgTabelasDoBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgTabelasDoBanco.Location = new System.Drawing.Point(0, 338);
            this.dvgTabelasDoBanco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvgTabelasDoBanco.Name = "dvgTabelasDoBanco";
            this.dvgTabelasDoBanco.RowTemplate.Height = 24;
            this.dvgTabelasDoBanco.Size = new System.Drawing.Size(1029, 341);
            this.dvgTabelasDoBanco.TabIndex = 51;
            this.dvgTabelasDoBanco.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgTabelasDoBanco_CellClick);
            this.dvgTabelasDoBanco.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgTabelasDoBanco_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(346, 39);
            this.label8.TabIndex = 50;
            this.label8.Text = "EDIÇÃO DE USUÁRIOS:";
            // 
            // txttipoDeUsuario
            // 
            this.txttipoDeUsuario.Location = new System.Drawing.Point(200, 267);
            this.txttipoDeUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttipoDeUsuario.Name = "txttipoDeUsuario";
            this.txttipoDeUsuario.Size = new System.Drawing.Size(147, 22);
            this.txttipoDeUsuario.TabIndex = 7;
            this.txttipoDeUsuario.Text = "0";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(723, 172);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(147, 22);
            this.txtSenha.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(723, 103);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(147, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(397, 171);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(147, 22);
            this.txtLogin.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(93, 98);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(147, 22);
            this.txtNome.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 24);
            this.label7.TabIndex = 42;
            this.label7.Text = "TIPO DE USUÁRIO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(632, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 40;
            this.label6.Text = "SENHA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(319, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 24);
            this.label5.TabIndex = 38;
            this.label5.Text = "LOGIN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(632, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 36;
            this.label4.Text = "EMAIL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 33;
            this.label2.Text = "TELEFONE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "NOME:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(356, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(507, 17);
            this.label9.TabIndex = 58;
            this.label9.Text = "FAÇA AS ALTERAÇÕES NOS CAMPOS DEPOIS DE SELECIONADO E CLIQUE AQUI :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(633, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(362, 19);
            this.label10.TabIndex = 59;
            this.label10.Text = "DIGITE O NOME A BAIXO PARA REALIZAR EDIÇÃO";
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(637, 49);
            this.txtBusca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(147, 22);
            this.txtBusca.TabIndex = 0;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // UscrEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblCodUserEdit);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.dvgTabelasDoBanco);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txttipoDeUsuario);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UscrEditUser";
            this.Size = new System.Drawing.Size(1032, 679);
            this.Load += new System.EventHandler(this.UscrEditUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgTabelasDoBanco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCodUserEdit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.DataGridView dvgTabelasDoBanco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttipoDeUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBusca;
    }
}
