namespace MT_MS
{
    partial class Verify
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtverifyemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpassis = new System.Windows.Forms.Label();
            this.txtforgetpass = new System.Windows.Forms.Label();
            this.btnverify = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtwrong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(120, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Forget Password";
            // 
            // txtverifyemail
            // 
            this.txtverifyemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtverifyemail.Location = new System.Drawing.Point(125, 97);
            this.txtverifyemail.Name = "txtverifyemail";
            this.txtverifyemail.Size = new System.Drawing.Size(224, 24);
            this.txtverifyemail.TabIndex = 2;
            this.txtverifyemail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(121, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Verify Email";
            // 
            // txtpassis
            // 
            this.txtpassis.AutoSize = true;
            this.txtpassis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtpassis.Location = new System.Drawing.Point(126, 130);
            this.txtpassis.Name = "txtpassis";
            this.txtpassis.Size = new System.Drawing.Size(113, 16);
            this.txtpassis.TabIndex = 4;
            this.txtpassis.Text = "Your password is ";
            this.txtpassis.Visible = false;
            // 
            // txtforgetpass
            // 
            this.txtforgetpass.AutoSize = true;
            this.txtforgetpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtforgetpass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtforgetpass.Location = new System.Drawing.Point(244, 130);
            this.txtforgetpass.Name = "txtforgetpass";
            this.txtforgetpass.Size = new System.Drawing.Size(78, 16);
            this.txtforgetpass.TabIndex = 5;
            this.txtforgetpass.Text = "Verify Email";
            this.txtforgetpass.Visible = false;
            // 
            // btnverify
            // 
            this.btnverify.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnverify.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnverify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnverify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnverify.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverify.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnverify.Location = new System.Drawing.Point(125, 149);
            this.btnverify.Name = "btnverify";
            this.btnverify.Size = new System.Drawing.Size(224, 35);
            this.btnverify.TabIndex = 6;
            this.btnverify.Text = "Verify";
            this.btnverify.UseVisualStyleBackColor = false;
            this.btnverify.Click += new System.EventHandler(this.btnverify_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(427, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtwrong
            // 
            this.txtwrong.AutoSize = true;
            this.txtwrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwrong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtwrong.Location = new System.Drawing.Point(126, 190);
            this.txtwrong.Name = "txtwrong";
            this.txtwrong.Size = new System.Drawing.Size(113, 16);
            this.txtwrong.TabIndex = 8;
            this.txtwrong.Text = "Your password is ";
            this.txtwrong.Visible = false;
            // 
            // Verify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(464, 229);
            this.Controls.Add(this.txtwrong);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnverify);
            this.Controls.Add(this.txtforgetpass);
            this.Controls.Add(this.txtpassis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtverifyemail);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Verify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verify";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtverifyemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtpassis;
        private System.Windows.Forms.Label txtforgetpass;
        private System.Windows.Forms.Button btnverify;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtwrong;
    }
}