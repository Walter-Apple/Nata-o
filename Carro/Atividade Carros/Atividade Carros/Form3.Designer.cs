namespace Atividade_Carros
{
    partial class Atividade2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSair = new System.Windows.Forms.Button();
            this.lblMnadados = new System.Windows.Forms.Label();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtDinRec = new System.Windows.Forms.TextBox();
            this.lblDrecebido = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(713, 415);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblMnadados
            // 
            this.lblMnadados.AutoSize = true;
            this.lblMnadados.Location = new System.Drawing.Point(280, 99);
            this.lblMnadados.Name = "lblMnadados";
            this.lblMnadados.Size = new System.Drawing.Size(88, 13);
            this.lblMnadados.TabIndex = 1;
            this.lblMnadados.Text = "Metros Nadados:";
            this.lblMnadados.Click += new System.EventHandler(this.lblMnadados_Click);
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(388, 99);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(100, 20);
            this.txtM.TabIndex = 2;
            // 
            // txtDinRec
            // 
            this.txtDinRec.Location = new System.Drawing.Point(388, 268);
            this.txtDinRec.Name = "txtDinRec";
            this.txtDinRec.ReadOnly = true;
            this.txtDinRec.Size = new System.Drawing.Size(100, 20);
            this.txtDinRec.TabIndex = 3;
            // 
            // lblDrecebido
            // 
            this.lblDrecebido.AutoSize = true;
            this.lblDrecebido.Location = new System.Drawing.Point(280, 271);
            this.lblDrecebido.Name = "lblDrecebido";
            this.lblDrecebido.Size = new System.Drawing.Size(98, 13);
            this.lblDrecebido.TabIndex = 4;
            this.lblDrecebido.Text = "Dinheiro Recebido:";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(388, 190);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 23);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(556, 190);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(94, 23);
            this.btnLimpa.TabIndex = 6;
            this.btnLimpa.Text = "Limpar";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // Atividade2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblDrecebido);
            this.Controls.Add(this.txtDinRec);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.lblMnadados);
            this.Controls.Add(this.btnSair);
            this.Name = "Atividade2";
            this.Text = "Natação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblMnadados;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtDinRec;
        private System.Windows.Forms.Label lblDrecebido;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnLimpa;
    }
}