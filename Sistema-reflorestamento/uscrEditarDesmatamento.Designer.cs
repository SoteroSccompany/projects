namespace SituaçãoDeAprendizagem
{
    partial class uscrEditarDesmatamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uscrEditarDesmatamento));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstbEstado = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodUser = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtVolumeArvores = new System.Windows.Forms.TextBox();
            this.txtUsuarioresp = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dvgTabelasDoBanco = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNArvores = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDesmatamento = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTabelasDoBanco)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 24);
            this.label6.TabIndex = 71;
            this.label6.Text = "(EM METROS CUBICOS)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(542, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 24);
            this.label5.TabIndex = 70;
            this.label5.Text = "USUÁRIO RESPONSÁVEL:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 24);
            this.label4.TabIndex = 69;
            this.label4.Text = "VOLUME DE ARVORES CORTADAS:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(512, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 24);
            this.label3.TabIndex = 68;
            this.label3.Text = "NÚMERO DE ARVORES CORTADAS:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lstbEstado
            // 
            this.lstbEstado.FormattingEnabled = true;
            this.lstbEstado.ItemHeight = 16;
            this.lstbEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MG ",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RR",
            "RO",
            "RJ",
            "RN",
            "RS",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.lstbEstado.Location = new System.Drawing.Point(358, 85);
            this.lstbEstado.Name = "lstbEstado";
            this.lstbEstado.Size = new System.Drawing.Size(120, 36);
            this.lstbEstado.TabIndex = 2;
            this.lstbEstado.SelectedIndexChanged += new System.EventHandler(this.lstbEstado_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 66;
            this.label2.Text = "ESTADO:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 65;
            this.label1.Text = "ANO:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCodUser
            // 
            this.lblCodUser.AutoSize = true;
            this.lblCodUser.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodUser.Location = new System.Drawing.Point(672, 18);
            this.lblCodUser.Name = "lblCodUser";
            this.lblCodUser.Size = new System.Drawing.Size(17, 24);
            this.lblCodUser.TabIndex = 64;
            this.lblCodUser.Text = "-";
            this.lblCodUser.Click += new System.EventHandler(this.lblCodUser_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(463, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(203, 24);
            this.label13.TabIndex = 63;
            this.label13.Text = "CODIGO DE USUÁRIO:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtVolumeArvores
            // 
            this.txtVolumeArvores.Location = new System.Drawing.Point(348, 167);
            this.txtVolumeArvores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVolumeArvores.Name = "txtVolumeArvores";
            this.txtVolumeArvores.Size = new System.Drawing.Size(147, 22);
            this.txtVolumeArvores.TabIndex = 4;
            this.txtVolumeArvores.TextChanged += new System.EventHandler(this.txtVolumeArvores_TextChanged);
            // 
            // txtUsuarioresp
            // 
            this.txtUsuarioresp.Enabled = false;
            this.txtUsuarioresp.Location = new System.Drawing.Point(850, 167);
            this.txtUsuarioresp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuarioresp.Name = "txtUsuarioresp";
            this.txtUsuarioresp.ReadOnly = true;
            this.txtUsuarioresp.Size = new System.Drawing.Size(147, 22);
            this.txtUsuarioresp.TabIndex = 62;
            this.txtUsuarioresp.TextChanged += new System.EventHandler(this.txtUsuarioresp_TextChanged);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.Location = new System.Drawing.Point(850, 254);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(163, 33);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar      ";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dvgTabelasDoBanco
            // 
            this.dvgTabelasDoBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgTabelasDoBanco.Location = new System.Drawing.Point(0, 331);
            this.dvgTabelasDoBanco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvgTabelasDoBanco.Name = "dvgTabelasDoBanco";
            this.dvgTabelasDoBanco.RowTemplate.Height = 24;
            this.dvgTabelasDoBanco.Size = new System.Drawing.Size(1032, 341);
            this.dvgTabelasDoBanco.TabIndex = 61;
            this.dvgTabelasDoBanco.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgTabelasDoBanco_CellClick);
            this.dvgTabelasDoBanco.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgTabelasDoBanco_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(435, 39);
            this.label8.TabIndex = 60;
            this.label8.Text = "EDIÇÃO DE DESMATAMENTO:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtNArvores
            // 
            this.txtNArvores.Location = new System.Drawing.Point(850, 90);
            this.txtNArvores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNArvores.Name = "txtNArvores";
            this.txtNArvores.Size = new System.Drawing.Size(147, 22);
            this.txtNArvores.TabIndex = 3;
            this.txtNArvores.TextChanged += new System.EventHandler(this.txtNArvores_TextChanged);
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(76, 88);
            this.txtAno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(147, 22);
            this.txtAno.TabIndex = 1;
            this.txtAno.TextChanged += new System.EventHandler(this.txtAno_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(333, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 24);
            this.label7.TabIndex = 72;
            this.label7.Text = "CÓDIGO DE DESMATAMENTO:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblDesmatamento
            // 
            this.lblDesmatamento.AutoSize = true;
            this.lblDesmatamento.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesmatamento.Location = new System.Drawing.Point(649, 223);
            this.lblDesmatamento.Name = "lblDesmatamento";
            this.lblDesmatamento.Size = new System.Drawing.Size(17, 24);
            this.lblDesmatamento.TabIndex = 73;
            this.lblDesmatamento.Text = "-";
            this.lblDesmatamento.Click += new System.EventHandler(this.lblDesmatamento_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(498, 265);
            this.txtBusca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(147, 22);
            this.txtBusca.TabIndex = 5;
            this.txtBusca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(452, 24);
            this.label10.TabIndex = 75;
            this.label10.Text = "DIGITE O DESMATAMENTO QUE DESEJA ALTERAR";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(239, 17);
            this.label11.TabIndex = 76;
            this.label11.Text = "(FAÇA A BUSCA POR ANO OU ESTADO)";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // uscrEditarDesmatamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.lblDesmatamento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstbEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCodUser);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtVolumeArvores);
            this.Controls.Add(this.txtUsuarioresp);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dvgTabelasDoBanco);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNArvores);
            this.Controls.Add(this.txtAno);
            this.Name = "uscrEditarDesmatamento";
            this.Size = new System.Drawing.Size(1032, 679);
            this.Load += new System.EventHandler(this.uscrEditarDesmatamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgTabelasDoBanco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstbEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodUser;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtVolumeArvores;
        private System.Windows.Forms.TextBox txtUsuarioresp;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dvgTabelasDoBanco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNArvores;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDesmatamento;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}
