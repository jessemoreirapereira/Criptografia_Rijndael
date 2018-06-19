namespace Criptografia
{
    partial class Criptografia
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
            this.btnCripto = new System.Windows.Forms.Button();
            this.btnDescriptografar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblChave = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtChave = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCripto
            // 
            this.btnCripto.Location = new System.Drawing.Point(16, 118);
            this.btnCripto.Name = "btnCripto";
            this.btnCripto.Size = new System.Drawing.Size(367, 23);
            this.btnCripto.TabIndex = 0;
            this.btnCripto.Text = "Criptografar";
            this.btnCripto.UseVisualStyleBackColor = true;
            this.btnCripto.Click += new System.EventHandler(this.btnCripto_Click);
            // 
            // btnDescriptografar
            // 
            this.btnDescriptografar.Location = new System.Drawing.Point(16, 148);
            this.btnDescriptografar.Name = "btnDescriptografar";
            this.btnDescriptografar.Size = new System.Drawing.Size(367, 23);
            this.btnDescriptografar.TabIndex = 1;
            this.btnDescriptografar.Text = "Descriptografar";
            this.btnDescriptografar.UseVisualStyleBackColor = true;
            this.btnDescriptografar.Click += new System.EventHandler(this.btnDescriptografar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(16, 178);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(367, 23);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblChave
            // 
            this.lblChave.AutoSize = true;
            this.lblChave.Location = new System.Drawing.Point(13, 13);
            this.lblChave.Name = "lblChave";
            this.lblChave.Size = new System.Drawing.Size(95, 13);
            this.lblChave.TabIndex = 3;
            this.lblChave.Text = "Chave / Password";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(13, 64);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "Valor";
            // 
            // txtChave
            // 
            this.txtChave.Location = new System.Drawing.Point(16, 29);
            this.txtChave.Name = "txtChave";
            this.txtChave.Size = new System.Drawing.Size(367, 20);
            this.txtChave.TabIndex = 5;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(16, 80);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(367, 20);
            this.txtValor.TabIndex = 6;
            // 
            // Criptografia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 218);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtChave);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblChave);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDescriptografar);
            this.Controls.Add(this.btnCripto);
            this.Name = "Criptografia";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCripto;
        private System.Windows.Forms.Button btnDescriptografar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblChave;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtChave;
        private System.Windows.Forms.TextBox txtValor;
    }
}

