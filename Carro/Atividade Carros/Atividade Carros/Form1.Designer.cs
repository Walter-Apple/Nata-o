namespace Atividade_Carros
{
    partial class Atividade
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
            this.txtsalarioFixo = new System.Windows.Forms.TextBox();
            this.txtcomissao = new System.Windows.Forms.TextBox();
            this.txtnumCarros = new System.Windows.Forms.TextBox();
            this.txtvalorCarro = new System.Windows.Forms.TextBox();
            this.txtsalarioTotal = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.lblsalarioFixo = new System.Windows.Forms.Label();
            this.lblcomissao = new System.Windows.Forms.Label();
            this.lblnumCarros = new System.Windows.Forms.Label();
            this.lblvalorCarros = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtsalarioFixo
            // 
            this.txtsalarioFixo.Location = new System.Drawing.Point(151, 38);
            this.txtsalarioFixo.Name = "txtsalarioFixo";
            this.txtsalarioFixo.Size = new System.Drawing.Size(100, 20);
            this.txtsalarioFixo.TabIndex = 0;
            this.txtsalarioFixo.TextChanged += new System.EventHandler(this.txtsalarioFixo_TextChanged);
            // 
            // txtcomissao
            // 
            this.txtcomissao.Location = new System.Drawing.Point(151, 78);
            this.txtcomissao.Name = "txtcomissao";
            this.txtcomissao.Size = new System.Drawing.Size(100, 20);
            this.txtcomissao.TabIndex = 1;
            // 
            // txtnumCarros
            // 
            this.txtnumCarros.Location = new System.Drawing.Point(151, 124);
            this.txtnumCarros.Name = "txtnumCarros";
            this.txtnumCarros.Size = new System.Drawing.Size(100, 20);
            this.txtnumCarros.TabIndex = 2;
            // 
            // txtvalorCarro
            // 
            this.txtvalorCarro.Location = new System.Drawing.Point(151, 168);
            this.txtvalorCarro.Name = "txtvalorCarro";
            this.txtvalorCarro.Size = new System.Drawing.Size(100, 20);
            this.txtvalorCarro.TabIndex = 3;
            this.txtvalorCarro.TextChanged += new System.EventHandler(this.txtvalorCarro_TextChanged);
            // 
            // txtsalarioTotal
            // 
            this.txtsalarioTotal.Location = new System.Drawing.Point(151, 342);
            this.txtsalarioTotal.Name = "txtsalarioTotal";
            this.txtsalarioTotal.ReadOnly = true;
            this.txtsalarioTotal.Size = new System.Drawing.Size(100, 20);
            this.txtsalarioTotal.TabIndex = 4;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(373, 342);
            this.txt5.Name = "txt5";
            this.txt5.ReadOnly = true;
            this.txt5.Size = new System.Drawing.Size(100, 20);
            this.txt5.TabIndex = 5;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(151, 245);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(349, 245);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(713, 415);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 8;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // lblsalarioFixo
            // 
            this.lblsalarioFixo.AutoSize = true;
            this.lblsalarioFixo.Location = new System.Drawing.Point(64, 38);
            this.lblsalarioFixo.Name = "lblsalarioFixo";
            this.lblsalarioFixo.Size = new System.Drawing.Size(64, 13);
            this.lblsalarioFixo.TabIndex = 9;
            this.lblsalarioFixo.Text = "Salário Fixo:";
            // 
            // lblcomissao
            // 
            this.lblcomissao.AutoSize = true;
            this.lblcomissao.Location = new System.Drawing.Point(44, 85);
            this.lblcomissao.Name = "lblcomissao";
            this.lblcomissao.Size = new System.Drawing.Size(101, 13);
            this.lblcomissao.TabIndex = 10;
            this.lblcomissao.Text = "Comissão por Carro:";
            // 
            // lblnumCarros
            // 
            this.lblnumCarros.AutoSize = true;
            this.lblnumCarros.Location = new System.Drawing.Point(50, 127);
            this.lblnumCarros.Name = "lblnumCarros";
            this.lblnumCarros.Size = new System.Drawing.Size(95, 13);
            this.lblnumCarros.TabIndex = 11;
            this.lblnumCarros.Text = "Número de Carros:";
            // 
            // lblvalorCarros
            // 
            this.lblvalorCarros.AutoSize = true;
            this.lblvalorCarros.Location = new System.Drawing.Point(64, 171);
            this.lblvalorCarros.Name = "lblvalorCarros";
            this.lblvalorCarros.Size = new System.Drawing.Size(67, 13);
            this.lblvalorCarros.TabIndex = 12;
            this.lblvalorCarros.Text = "Valor Carros:";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(76, 349);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(69, 13);
            this.lbltotal.TabIndex = 13;
            this.lbltotal.Text = "Salário Total:";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(284, 342);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(83, 13);
            this.lbl5.TabIndex = 14;
            this.lbl5.Text = "5% das Vendas:";
            // 
            // Atividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblvalorCarros);
            this.Controls.Add(this.lblnumCarros);
            this.Controls.Add(this.lblcomissao);
            this.Controls.Add(this.lblsalarioFixo);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txtsalarioTotal);
            this.Controls.Add(this.txtvalorCarro);
            this.Controls.Add(this.txtnumCarros);
            this.Controls.Add(this.txtcomissao);
            this.Controls.Add(this.txtsalarioFixo);
            this.Name = "Atividade";
            this.Text = "Carros";
            this.Load += new System.EventHandler(this.Atividade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsalarioFixo;
        private System.Windows.Forms.TextBox txtcomissao;
        private System.Windows.Forms.TextBox txtnumCarros;
        private System.Windows.Forms.TextBox txtvalorCarro;
        private System.Windows.Forms.TextBox txtsalarioTotal;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label lblsalarioFixo;
        private System.Windows.Forms.Label lblcomissao;
        private System.Windows.Forms.Label lblnumCarros;
        private System.Windows.Forms.Label lblvalorCarros;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lbl5;
    }
}

