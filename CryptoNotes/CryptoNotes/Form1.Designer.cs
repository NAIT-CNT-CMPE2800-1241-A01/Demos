namespace CryptoNotes
{
    partial class Form1
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
            this.UI_B_EncAES = new System.Windows.Forms.Button();
            this.UI_TB_Text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UI_B_EncAES
            // 
            this.UI_B_EncAES.Location = new System.Drawing.Point(12, 38);
            this.UI_B_EncAES.Name = "UI_B_EncAES";
            this.UI_B_EncAES.Size = new System.Drawing.Size(75, 23);
            this.UI_B_EncAES.TabIndex = 0;
            this.UI_B_EncAES.Text = "Encrypt AES";
            this.UI_B_EncAES.UseVisualStyleBackColor = true;
            this.UI_B_EncAES.Click += new System.EventHandler(this.UI_B_EncAES_Click);
            // 
            // UI_TB_Text
            // 
            this.UI_TB_Text.Location = new System.Drawing.Point(12, 12);
            this.UI_TB_Text.Name = "UI_TB_Text";
            this.UI_TB_Text.Size = new System.Drawing.Size(776, 20);
            this.UI_TB_Text.TabIndex = 1;
            this.UI_TB_Text.Text = "The message...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_TB_Text);
            this.Controls.Add(this.UI_B_EncAES);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_B_EncAES;
        private System.Windows.Forms.TextBox UI_TB_Text;
    }
}

