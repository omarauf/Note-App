namespace Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtLogPassword = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtLogEmail = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtRegEmail = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtRegName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 417);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.txtLogPassword);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.txtLogEmail);
            this.panel5.Controls.Add(this.pictureBox5);
            this.panel5.Controls.Add(this.btnLogin);
            this.panel5.Location = new System.Drawing.Point(303, 35);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(294, 347);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(228)))), ((int)(((byte)(230)))));
            this.panel6.ForeColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(23, 172);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(249, 1);
            this.panel6.TabIndex = 11;
            // 
            // txtLogPassword
            // 
            this.txtLogPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtLogPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogPassword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtLogPassword.Location = new System.Drawing.Point(53, 141);
            this.txtLogPassword.Name = "txtLogPassword";
            this.txtLogPassword.PasswordChar = '*';
            this.txtLogPassword.Size = new System.Drawing.Size(219, 22);
            this.txtLogPassword.TabIndex = 10;
            this.txtLogPassword.Text = "omar";
            this.txtLogPassword.Enter += new System.EventHandler(this.removePlaceholder);
            this.txtLogPassword.Leave += new System.EventHandler(this.writePlaceholder);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(137)))), ((int)(((byte)(152)))));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(23, 142);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(228)))), ((int)(((byte)(230)))));
            this.panel7.ForeColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(23, 99);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(249, 1);
            this.panel7.TabIndex = 8;
            // 
            // txtLogEmail
            // 
            this.txtLogEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtLogEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogEmail.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtLogEmail.Location = new System.Drawing.Point(53, 69);
            this.txtLogEmail.Name = "txtLogEmail";
            this.txtLogEmail.Size = new System.Drawing.Size(219, 22);
            this.txtLogEmail.TabIndex = 7;
            this.txtLogEmail.Text = "omar";
            this.txtLogEmail.Enter += new System.EventHandler(this.removePlaceholder);
            this.txtLogEmail.Leave += new System.EventHandler(this.writePlaceholder);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(137)))), ((int)(((byte)(152)))));
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(23, 69);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnLogin.Location = new System.Drawing.Point(23, 219);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(249, 30);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.txtRegPassword);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtRegEmail);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtRegName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Location = new System.Drawing.Point(3, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 350);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(228)))), ((int)(((byte)(230)))));
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(23, 219);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(249, 1);
            this.panel4.TabIndex = 11;
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtRegPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegPassword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtRegPassword.Location = new System.Drawing.Point(53, 188);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.PasswordChar = '*';
            this.txtRegPassword.Size = new System.Drawing.Size(219, 22);
            this.txtRegPassword.TabIndex = 10;
            this.txtRegPassword.Text = "Password";
            this.txtRegPassword.Enter += new System.EventHandler(this.removePlaceholder);
            this.txtRegPassword.Leave += new System.EventHandler(this.writePlaceholder);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(137)))), ((int)(((byte)(152)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(23, 189);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(228)))), ((int)(((byte)(230)))));
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(23, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(249, 1);
            this.panel3.TabIndex = 8;
            // 
            // txtRegEmail
            // 
            this.txtRegEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtRegEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegEmail.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtRegEmail.Location = new System.Drawing.Point(53, 116);
            this.txtRegEmail.Name = "txtRegEmail";
            this.txtRegEmail.Size = new System.Drawing.Size(219, 22);
            this.txtRegEmail.TabIndex = 7;
            this.txtRegEmail.Text = "Email";
            this.txtRegEmail.Enter += new System.EventHandler(this.removePlaceholder);
            this.txtRegEmail.Leave += new System.EventHandler(this.writePlaceholder);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(137)))), ((int)(((byte)(152)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 116);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(228)))), ((int)(((byte)(230)))));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(23, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 1);
            this.panel2.TabIndex = 5;
            // 
            // txtRegName
            // 
            this.txtRegName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.txtRegName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegName.ForeColor = System.Drawing.Color.DimGray;
            this.txtRegName.Location = new System.Drawing.Point(53, 41);
            this.txtRegName.Name = "txtRegName";
            this.txtRegName.Size = new System.Drawing.Size(219, 22);
            this.txtRegName.TabIndex = 4;
            this.txtRegName.Text = "Name";
            this.txtRegName.Enter += new System.EventHandler(this.removePlaceholder);
            this.txtRegName.Leave += new System.EventHandler(this.writePlaceholder);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(137)))), ((int)(((byte)(152)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnRegister.Location = new System.Drawing.Point(23, 266);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(249, 30);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register ";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtRegName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtRegPassword;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtRegEmail;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtLogPassword;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtLogEmail;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnLogin;
    }
}

