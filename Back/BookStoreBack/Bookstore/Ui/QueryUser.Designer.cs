namespace Bookstore.Ui
{
    partial class QueryUser
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
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_truename = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_address = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_regdate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Enter UserName To Query User";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(40, 24);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(207, 21);
            this.txt_username.TabIndex = 1;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(263, 23);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_confirm.TabIndex = 2;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_regdate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lb_address);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lb_email);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lb_truename);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lb_username);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 126);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UserInfo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "UserName:";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(71, 17);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(0, 12);
            this.lb_username.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "TrueName:";
            // 
            // lb_truename
            // 
            this.lb_truename.AutoSize = true;
            this.lb_truename.Location = new System.Drawing.Point(71, 38);
            this.lb_truename.Name = "lb_truename";
            this.lb_truename.Size = new System.Drawing.Size(0, 12);
            this.lb_truename.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-Mail:";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(71, 60);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(0, 12);
            this.lb_email.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "Address:";
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Location = new System.Drawing.Point(71, 81);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(0, 12);
            this.lb_address.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "Regdate:";
            // 
            // lb_regdate
            // 
            this.lb_regdate.AutoSize = true;
            this.lb_regdate.Location = new System.Drawing.Point(71, 102);
            this.lb_regdate.Name = "lb_regdate";
            this.lb_regdate.Size = new System.Drawing.Size(0, 12);
            this.lb_regdate.TabIndex = 9;
            // 
            // QueryUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 190);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label1);
            this.Name = "QueryUser";
            this.Text = "QueryUser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_regdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_truename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label label2;
    }
}