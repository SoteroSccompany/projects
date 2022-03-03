namespace SituaçãoDeAprendizagem
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlAcompanharButon = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.btnDesmatamento = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblData = new System.Windows.Forms.Label();
            this.btnCadastroUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnExclusao = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCadastroReflorest = new System.Windows.Forms.Button();
            this.btnEdirFlore = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.uscrCalcul1 = new SituaçãoDeAprendizagem.uscrCalcul();
            this.uscrExclusãoDesmatamento1 = new SituaçãoDeAprendizagem.uscrExclusãoDesmatamento();
            this.uscrEditarDesmatamento1 = new SituaçãoDeAprendizagem.uscrEditarDesmatamento();
            this.uscCadastrarReflorest1 = new SituaçãoDeAprendizagem.UscCadastrarReflorest();
            this.usrcExclusão_de_cliente1 = new SituaçãoDeAprendizagem.UsrcExclusão_de_cliente();
            this.uscrEditUser1 = new SituaçãoDeAprendizagem.UscrEditUser();
            this.frnRegiatrarUsuario1 = new SituaçãoDeAprendizagem.FrnRegiatrarUsuario();
            this.frnHome1 = new SituaçãoDeAprendizagem.FrnHome();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.LightGreen;
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Controls.Add(this.pnlAcompanharButon);
            this.pnlMenu.Controls.Add(this.btnSair);
            this.pnlMenu.Controls.Add(this.btnCalculo);
            this.pnlMenu.Controls.Add(this.btnDesmatamento);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Controls.Add(this.btnCadastrar);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(248, 818);
            this.pnlMenu.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pnlAcompanharButon
            // 
            this.pnlAcompanharButon.BackColor = System.Drawing.Color.DarkGreen;
            this.pnlAcompanharButon.Location = new System.Drawing.Point(3, 225);
            this.pnlAcompanharButon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAcompanharButon.Name = "pnlAcompanharButon";
            this.pnlAcompanharButon.Size = new System.Drawing.Size(13, 80);
            this.pnlAcompanharButon.TabIndex = 3;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(21, 487);
            this.btnSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(224, 80);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "     SAIR";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCalculo
            // 
            this.btnCalculo.FlatAppearance.BorderSize = 0;
            this.btnCalculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculo.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalculo.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculo.Image")));
            this.btnCalculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculo.Location = new System.Drawing.Point(21, 395);
            this.btnCalculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(224, 86);
            this.btnCalculo.TabIndex = 6;
            this.btnCalculo.Text = "     CALCULAR DESMATAMENTO ";
            this.btnCalculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // btnDesmatamento
            // 
            this.btnDesmatamento.FlatAppearance.BorderSize = 0;
            this.btnDesmatamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesmatamento.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesmatamento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDesmatamento.Image = ((System.Drawing.Image)(resources.GetObject("btnDesmatamento.Image")));
            this.btnDesmatamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesmatamento.Location = new System.Drawing.Point(21, 309);
            this.btnDesmatamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDesmatamento.Name = "btnDesmatamento";
            this.btnDesmatamento.Size = new System.Drawing.Size(224, 80);
            this.btnDesmatamento.TabIndex = 5;
            this.btnDesmatamento.Text = "     REGISTRAR DESMATAMENTO ";
            this.btnDesmatamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDesmatamento.UseVisualStyleBackColor = true;
            this.btnDesmatamento.Click += new System.EventHandler(this.btnDesmatamento_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(17, 225);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(225, 80);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "     HOME";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(21, 571);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(224, 80);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "     ÁREA DO ADMINISTRADOR";
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.lblData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(248, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 40);
            this.panel1.TabIndex = 2;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(715, 9);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(13, 17);
            this.lblData.TabIndex = 20;
            this.lblData.Text = "-";
            // 
            // btnCadastroUser
            // 
            this.btnCadastroUser.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroUser.Location = new System.Drawing.Point(288, 84);
            this.btnCadastroUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastroUser.Name = "btnCadastroUser";
            this.btnCadastroUser.Size = new System.Drawing.Size(291, 46);
            this.btnCadastroUser.TabIndex = 8;
            this.btnCadastroUser.Text = "CADASTRO DE USUÁRIOS";
            this.btnCadastroUser.UseVisualStyleBackColor = true;
            this.btnCadastroUser.Visible = false;
            this.btnCadastroUser.Click += new System.EventHandler(this.btnCadastroUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUser.Location = new System.Drawing.Point(584, 84);
            this.btnEditUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(291, 46);
            this.btnEditUser.TabIndex = 9;
            this.btnEditUser.Text = "EDIÇÃO DE USUÁRIOS";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Visible = false;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnExclusao
            // 
            this.btnExclusao.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExclusao.Location = new System.Drawing.Point(880, 84);
            this.btnExclusao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExclusao.Name = "btnExclusao";
            this.btnExclusao.Size = new System.Drawing.Size(291, 46);
            this.btnExclusao.TabIndex = 10;
            this.btnExclusao.Text = "EXCLUSÃO DE USUÁRIOS";
            this.btnExclusao.UseVisualStyleBackColor = true;
            this.btnExclusao.Visible = false;
            this.btnExclusao.Click += new System.EventHandler(this.btnExclusao_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // btnCadastroReflorest
            // 
            this.btnCadastroReflorest.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroReflorest.Location = new System.Drawing.Point(287, 85);
            this.btnCadastroReflorest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastroReflorest.Name = "btnCadastroReflorest";
            this.btnCadastroReflorest.Size = new System.Drawing.Size(291, 46);
            this.btnCadastroReflorest.TabIndex = 16;
            this.btnCadastroReflorest.Text = "CADASTRO DE DESMATAMENTO";
            this.btnCadastroReflorest.UseVisualStyleBackColor = true;
            this.btnCadastroReflorest.Visible = false;
            this.btnCadastroReflorest.Click += new System.EventHandler(this.btnCadastroReflorest_Click);
            // 
            // btnEdirFlore
            // 
            this.btnEdirFlore.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdirFlore.Location = new System.Drawing.Point(585, 85);
            this.btnEdirFlore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdirFlore.Name = "btnEdirFlore";
            this.btnEdirFlore.Size = new System.Drawing.Size(291, 46);
            this.btnEdirFlore.TabIndex = 17;
            this.btnEdirFlore.Text = "EDITAR DESMATAMENTO";
            this.btnEdirFlore.UseVisualStyleBackColor = true;
            this.btnEdirFlore.Visible = false;
            this.btnEdirFlore.Click += new System.EventHandler(this.btnEdirFlore_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(880, 84);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 46);
            this.button1.TabIndex = 18;
            this.button1.Text = "EXCLUSÃO DE DESMATAMENTO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // uscrCalcul1
            // 
            this.uscrCalcul1.Location = new System.Drawing.Point(248, 139);
            this.uscrCalcul1.Name = "uscrCalcul1";
            this.uscrCalcul1.Size = new System.Drawing.Size(1032, 679);
            this.uscrCalcul1.TabIndex = 25;
            this.uscrCalcul1.Load += new System.EventHandler(this.uscrCalcul1_Load);
            // 
            // uscrExclusãoDesmatamento1
            // 
            this.uscrExclusãoDesmatamento1.Location = new System.Drawing.Point(248, 139);
            this.uscrExclusãoDesmatamento1.Name = "uscrExclusãoDesmatamento1";
            this.uscrExclusãoDesmatamento1.Size = new System.Drawing.Size(1032, 679);
            this.uscrExclusãoDesmatamento1.TabIndex = 24;
            // 
            // uscrEditarDesmatamento1
            // 
            this.uscrEditarDesmatamento1.Location = new System.Drawing.Point(248, 139);
            this.uscrEditarDesmatamento1.Name = "uscrEditarDesmatamento1";
            this.uscrEditarDesmatamento1.Size = new System.Drawing.Size(1032, 679);
            this.uscrEditarDesmatamento1.TabIndex = 23;
            // 
            // uscCadastrarReflorest1
            // 
            this.uscCadastrarReflorest1.Location = new System.Drawing.Point(248, 141);
            this.uscCadastrarReflorest1.Name = "uscCadastrarReflorest1";
            this.uscCadastrarReflorest1.Size = new System.Drawing.Size(1032, 679);
            this.uscCadastrarReflorest1.TabIndex = 22;
            // 
            // usrcExclusão_de_cliente1
            // 
            this.usrcExclusão_de_cliente1.Location = new System.Drawing.Point(248, 141);
            this.usrcExclusão_de_cliente1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usrcExclusão_de_cliente1.Name = "usrcExclusão_de_cliente1";
            this.usrcExclusão_de_cliente1.Size = new System.Drawing.Size(1032, 679);
            this.usrcExclusão_de_cliente1.TabIndex = 21;
            // 
            // uscrEditUser1
            // 
            this.uscrEditUser1.Location = new System.Drawing.Point(248, 139);
            this.uscrEditUser1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uscrEditUser1.Name = "uscrEditUser1";
            this.uscrEditUser1.Size = new System.Drawing.Size(1032, 679);
            this.uscrEditUser1.TabIndex = 20;
            // 
            // frnRegiatrarUsuario1
            // 
            this.frnRegiatrarUsuario1.Location = new System.Drawing.Point(248, 141);
            this.frnRegiatrarUsuario1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.frnRegiatrarUsuario1.Name = "frnRegiatrarUsuario1";
            this.frnRegiatrarUsuario1.Size = new System.Drawing.Size(1032, 679);
            this.frnRegiatrarUsuario1.TabIndex = 19;
            // 
            // frnHome1
            // 
            this.frnHome1.Location = new System.Drawing.Point(248, 139);
            this.frnHome1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.frnHome1.Name = "frnHome1";
            this.frnHome1.Size = new System.Drawing.Size(1032, 679);
            this.frnHome1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 818);
            this.Controls.Add(this.uscrCalcul1);
            this.Controls.Add(this.uscrExclusãoDesmatamento1);
            this.Controls.Add(this.uscrEditarDesmatamento1);
            this.Controls.Add(this.uscCadastrarReflorest1);
            this.Controls.Add(this.usrcExclusão_de_cliente1);
            this.Controls.Add(this.uscrEditUser1);
            this.Controls.Add(this.frnRegiatrarUsuario1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEdirFlore);
            this.Controls.Add(this.btnCadastroReflorest);
            this.Controls.Add(this.btnExclusao);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnCadastroUser);
            this.Controls.Add(this.frnHome1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlAcompanharButon;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.Button btnDesmatamento;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panel1;
        private FrnHome frnHome1;
        private System.Windows.Forms.Button btnCadastroUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnExclusao;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCadastroReflorest;
        private System.Windows.Forms.Button btnEdirFlore;
        private System.Windows.Forms.Button button1;
        private FrnRegiatrarUsuario frnRegiatrarUsuario1;
        private UscrEditUser uscrEditUser1;
        private UsrcExclusão_de_cliente usrcExclusão_de_cliente1;
        private UscCadastrarReflorest uscCadastrarReflorest1;
        private uscrEditarDesmatamento uscrEditarDesmatamento1;
        private uscrExclusãoDesmatamento uscrExclusãoDesmatamento1;
        private uscrCalcul uscrCalcul1;
    }
}

