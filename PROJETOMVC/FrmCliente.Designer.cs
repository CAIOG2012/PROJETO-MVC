namespace PROJETOMVCA27
{
    partial class FrmCliente
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
            this.btn_enviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cpfa27 = new System.Windows.Forms.TextBox();
            this.txt_nomea27 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nomemaea27 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_enviar.Location = new System.Drawing.Point(51, 207);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(162, 53);
            this.btn_enviar.TabIndex = 0;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPF:";
            // 
            // txt_cpfa27
            // 
            this.txt_cpfa27.Location = new System.Drawing.Point(29, 38);
            this.txt_cpfa27.Name = "txt_cpfa27";
            this.txt_cpfa27.Size = new System.Drawing.Size(200, 20);
            this.txt_cpfa27.TabIndex = 2;
            this.txt_cpfa27.TextChanged += new System.EventHandler(this.txt_cpfa27_TextChanged);
            // 
            // txt_nomea27
            // 
            this.txt_nomea27.Location = new System.Drawing.Point(29, 104);
            this.txt_nomea27.Name = "txt_nomea27";
            this.txt_nomea27.Size = new System.Drawing.Size(200, 20);
            this.txt_nomea27.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 84);
            this.label2.MaximumSize = new System.Drawing.Size(5000, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome Completo:";
            // 
            // txt_nomemaea27
            // 
            this.txt_nomemaea27.Location = new System.Drawing.Point(29, 172);
            this.txt_nomemaea27.Name = "txt_nomemaea27";
            this.txt_nomemaea27.Size = new System.Drawing.Size(200, 20);
            this.txt_nomemaea27.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome da Mãe:";
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 272);
            this.Controls.Add(this.txt_nomemaea27);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nomea27);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cpfa27);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_enviar);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmcliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cpfa27;
        private System.Windows.Forms.TextBox txt_nomea27;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nomemaea27;
        private System.Windows.Forms.Label label3;
    }
}

