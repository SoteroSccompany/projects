namespace SituaçãoDeAprendizagem
{
    partial class uscrCalcul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uscrCalcul));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.Label();
            this.btnCalculo1 = new System.Windows.Forms.Button();
            this.btnCalculo2 = new System.Windows.Forms.Button();
            this.dvgRetInfo = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNArvoresARepor = new System.Windows.Forms.TextBox();
            this.lblCodUser = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtval = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTREFLORE = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRetInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESCOLHA FORMA DESEJADA PARA REALIZAR OS CALCULOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(438, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "REPOSIÇÃO FLORESTAL POR PAGAMENTO:";
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.Location = new System.Drawing.Point(22, 202);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(408, 28);
            this.C.TabIndex = 2;
            this.C.Text = "REPOSIÇÃO FLORESTAL POR PLANTIO: ";
            // 
            // btnCalculo1
            // 
            this.btnCalculo1.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculo1.Image")));
            this.btnCalculo1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculo1.Location = new System.Drawing.Point(488, 112);
            this.btnCalculo1.Name = "btnCalculo1";
            this.btnCalculo1.Size = new System.Drawing.Size(144, 43);
            this.btnCalculo1.TabIndex = 4;
            this.btnCalculo1.Text = "   CALCULAR ";
            this.btnCalculo1.UseVisualStyleBackColor = true;
            this.btnCalculo1.Click += new System.EventHandler(this.btnCalculo1_Click);
            // 
            // btnCalculo2
            // 
            this.btnCalculo2.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculo2.Image")));
            this.btnCalculo2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculo2.Location = new System.Drawing.Point(488, 198);
            this.btnCalculo2.Name = "btnCalculo2";
            this.btnCalculo2.Size = new System.Drawing.Size(144, 43);
            this.btnCalculo2.TabIndex = 5;
            this.btnCalculo2.Text = "   CALCULAR ";
            this.btnCalculo2.UseVisualStyleBackColor = true;
            this.btnCalculo2.Click += new System.EventHandler(this.btnCalculo2_Click);
            // 
            // dvgRetInfo
            // 
            this.dvgRetInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgRetInfo.Location = new System.Drawing.Point(0, 403);
            this.dvgRetInfo.Name = "dvgRetInfo";
            this.dvgRetInfo.RowTemplate.Height = 24;
            this.dvgRetInfo.Size = new System.Drawing.Size(1032, 276);
            this.dvgRetInfo.TabIndex = 6;
            this.dvgRetInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgRetInfo_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "VALOR A PAGAR: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "NÚMEROS DE ÁRVORES A PLANTAR:";
            // 
            // txtNArvoresARepor
            // 
            this.txtNArvoresARepor.Location = new System.Drawing.Point(327, 328);
            this.txtNArvoresARepor.Name = "txtNArvoresARepor";
            this.txtNArvoresARepor.Size = new System.Drawing.Size(150, 22);
            this.txtNArvoresARepor.TabIndex = 10;
            // 
            // lblCodUser
            // 
            this.lblCodUser.AutoSize = true;
            this.lblCodUser.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodUser.Location = new System.Drawing.Point(932, 83);
            this.lblCodUser.Name = "lblCodUser";
            this.lblCodUser.Size = new System.Drawing.Size(17, 24);
            this.lblCodUser.TabIndex = 66;
            this.lblCodUser.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(712, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(203, 24);
            this.label13.TabIndex = 65;
            this.label13.Text = "CODIGO DE USUÁRIO:";
            // 
            // txtval
            // 
            this.txtval.Location = new System.Drawing.Point(530, 295);
            this.txtval.Name = "txtval";
            this.txtval.Size = new System.Drawing.Size(150, 22);
            this.txtval.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(693, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(303, 24);
            this.label5.TabIndex = 68;
            this.label5.Text = "CODIGO  DE REFLORESTAMENTO:";
            // 
            // TXTREFLORE
            // 
            this.TXTREFLORE.Enabled = false;
            this.TXTREFLORE.Location = new System.Drawing.Point(697, 219);
            this.TXTREFLORE.Name = "TXTREFLORE";
            this.TXTREFLORE.ReadOnly = true;
            this.TXTREFLORE.Size = new System.Drawing.Size(150, 22);
            this.TXTREFLORE.TabIndex = 69;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(176, 279);
            this.maskedTextBox1.Mask = "$00000000,0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(121, 22);
            this.maskedTextBox1.TabIndex = 70;
            this.maskedTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // uscrCalcul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.TXTREFLORE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtval);
            this.Controls.Add(this.lblCodUser);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtNArvoresARepor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dvgRetInfo);
            this.Controls.Add(this.btnCalculo2);
            this.Controls.Add(this.btnCalculo1);
            this.Controls.Add(this.C);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "uscrCalcul";
            this.Size = new System.Drawing.Size(1032, 679);
            this.Load += new System.EventHandler(this.uscrCalcul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgRetInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label C;
        private System.Windows.Forms.Button btnCalculo1;
        private System.Windows.Forms.Button btnCalculo2;
        private System.Windows.Forms.DataGridView dvgRetInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNArvoresARepor;
        private System.Windows.Forms.Label lblCodUser;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtval;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTREFLORE;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}
