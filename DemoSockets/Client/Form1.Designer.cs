namespace Client
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
            this.UI_TB_Address = new System.Windows.Forms.TextBox();
            this.UI_B_Connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_TB_Address
            // 
            this.UI_TB_Address.Location = new System.Drawing.Point(235, 172);
            this.UI_TB_Address.Name = "UI_TB_Address";
            this.UI_TB_Address.Size = new System.Drawing.Size(257, 20);
            this.UI_TB_Address.TabIndex = 0;
            // 
            // UI_B_Connect
            // 
            this.UI_B_Connect.Location = new System.Drawing.Point(250, 285);
            this.UI_B_Connect.Name = "UI_B_Connect";
            this.UI_B_Connect.Size = new System.Drawing.Size(373, 114);
            this.UI_B_Connect.TabIndex = 1;
            this.UI_B_Connect.Text = "Connect!";
            this.UI_B_Connect.UseVisualStyleBackColor = true;
            this.UI_B_Connect.Click += new System.EventHandler(this.UI_B_Connect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_B_Connect);
            this.Controls.Add(this.UI_TB_Address);
            this.Name = "Form1";
            this.Text = "Akil\'s Happy Socket Runtime!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_TB_Address;
        private System.Windows.Forms.Button UI_B_Connect;
    }
}

