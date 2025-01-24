namespace PolibiuszApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtInput = new TextBox();
            txtOutput = new TextBox();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            lblInput = new Label();
            lblOutput = new Label();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(12, 30);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(300, 23);
            txtInput.TabIndex = 0;
            txtInput.Text = "asd";
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(12, 85);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(300, 23);
            txtOutput.TabIndex = 1;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(12, 130);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(75, 23);
            btnEncrypt.TabIndex = 2;
            btnEncrypt.Text = "Zaszyfruj";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += this.btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(237, 130);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(75, 23);
            btnDecrypt.TabIndex = 3;
            btnDecrypt.Text = "Rozszyfruj";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += this.btnDecrypt_Click;
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new Point(12, 12);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(94, 15);
            lblInput.TabIndex = 4;
            lblInput.Text = "Tekst wejściowy:";
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(12, 67);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(88, 15);
            lblOutput.TabIndex = 5;
            lblOutput.Text = "Wynik operacji:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 161);
            Controls.Add(lblOutput);
            Controls.Add(lblInput);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Szyfr Polibiusza";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
    }
}
