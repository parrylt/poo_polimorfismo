namespace poo_polimorfismo
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnContaEspecial = new System.Windows.Forms.RadioButton();
            this.btnContaPoupanca = new System.Windows.Forms.RadioButton();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSaldoCE = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSaldoCP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(49, 152);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(261, 20);
            this.txtValor.TabIndex = 0;
            // 
            // btnContaEspecial
            // 
            this.btnContaEspecial.AutoSize = true;
            this.btnContaEspecial.Location = new System.Drawing.Point(40, 74);
            this.btnContaEspecial.Name = "btnContaEspecial";
            this.btnContaEspecial.Size = new System.Drawing.Size(96, 17);
            this.btnContaEspecial.TabIndex = 1;
            this.btnContaEspecial.TabStop = true;
            this.btnContaEspecial.Text = "Conta Especial";
            this.btnContaEspecial.UseVisualStyleBackColor = true;
            // 
            // btnContaPoupanca
            // 
            this.btnContaPoupanca.AutoSize = true;
            this.btnContaPoupanca.Location = new System.Drawing.Point(207, 74);
            this.btnContaPoupanca.Name = "btnContaPoupanca";
            this.btnContaPoupanca.Size = new System.Drawing.Size(105, 17);
            this.btnContaPoupanca.TabIndex = 2;
            this.btnContaPoupanca.TabStop = true;
            this.btnContaPoupanca.Text = "Conta Poupança";
            this.btnContaPoupanca.UseVisualStyleBackColor = true;
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(40, 224);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(111, 47);
            this.btnDepositar.TabIndex = 3;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(207, 224);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(113, 47);
            this.btnSacar.TabIndex = 4;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Saldo CE :";
            // 
            // lblSaldoCE
            // 
            this.lblSaldoCE.AutoSize = true;
            this.lblSaldoCE.Location = new System.Drawing.Point(109, 308);
            this.lblSaldoCE.Name = "lblSaldoCE";
            this.lblSaldoCE.Size = new System.Drawing.Size(0, 13);
            this.lblSaldoCE.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Saldo CP :";
            // 
            // lblSaldoCP
            // 
            this.lblSaldoCP.AutoSize = true;
            this.lblSaldoCP.Location = new System.Drawing.Point(283, 308);
            this.lblSaldoCP.Name = "lblSaldoCP";
            this.lblSaldoCP.Size = new System.Drawing.Size(0, 13);
            this.lblSaldoCP.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 385);
            this.Controls.Add(this.lblSaldoCP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSaldoCE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.btnContaPoupanca);
            this.Controls.Add(this.btnContaEspecial);
            this.Controls.Add(this.txtValor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.RadioButton btnContaEspecial;
        private System.Windows.Forms.RadioButton btnContaPoupanca;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSaldoCE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSaldoCP;
    }
}

