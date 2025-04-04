namespace CryptoChat2142
{
    partial class Client
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
            this.UI_B_Connect = new System.Windows.Forms.Button();
            this.UI_TB_Message = new System.Windows.Forms.TextBox();
            this.UI_B_Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_B_Connect
            // 
            this.UI_B_Connect.Location = new System.Drawing.Point(12, 12);
            this.UI_B_Connect.Name = "UI_B_Connect";
            this.UI_B_Connect.Size = new System.Drawing.Size(75, 23);
            this.UI_B_Connect.TabIndex = 0;
            this.UI_B_Connect.Text = "Connect";
            this.UI_B_Connect.UseVisualStyleBackColor = true;
            this.UI_B_Connect.Click += new System.EventHandler(this.UI_B_Connect_Click);
            // 
            // UI_TB_Message
            // 
            this.UI_TB_Message.Location = new System.Drawing.Point(12, 41);
            this.UI_TB_Message.Name = "UI_TB_Message";
            this.UI_TB_Message.Size = new System.Drawing.Size(776, 20);
            this.UI_TB_Message.TabIndex = 1;
            // 
            // UI_B_Send
            // 
            this.UI_B_Send.Location = new System.Drawing.Point(713, 67);
            this.UI_B_Send.Name = "UI_B_Send";
            this.UI_B_Send.Size = new System.Drawing.Size(75, 23);
            this.UI_B_Send.TabIndex = 2;
            this.UI_B_Send.Text = "Send";
            this.UI_B_Send.UseVisualStyleBackColor = true;
            this.UI_B_Send.Click += new System.EventHandler(this.UI_B_Send_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 103);
            this.Controls.Add(this.UI_B_Send);
            this.Controls.Add(this.UI_TB_Message);
            this.Controls.Add(this.UI_B_Connect);
            this.Name = "Client";
            this.Text = "Client Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_B_Connect;
        private System.Windows.Forms.TextBox UI_TB_Message;
        private System.Windows.Forms.Button UI_B_Send;
    }
}

