namespace CsharpProjectThree
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginBtn = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.passwortInput = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(66)))), ((int)(((byte)(228)))));
            this.loginBtn.Location = new System.Drawing.Point(210, 240);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 26;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(66)))), ((int)(((byte)(228)))));
            this.Label3.Location = new System.Drawing.Point(45, 152);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(75, 18);
            this.Label3.TabIndex = 25;
            this.Label3.Text = "Password";
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox2.BackgroundImage")));
            this.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureBox2.InitialImage")));
            this.PictureBox2.Location = new System.Drawing.Point(13, 167);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(26, 26);
            this.PictureBox2.TabIndex = 24;
            this.PictureBox2.TabStop = false;
            // 
            // passwortInput
            // 
            this.passwortInput.Location = new System.Drawing.Point(45, 173);
            this.passwortInput.Name = "passwortInput";
            this.passwortInput.PasswordChar = '*';
            this.passwortInput.Size = new System.Drawing.Size(240, 20);
            this.passwortInput.TabIndex = 23;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(66)))), ((int)(((byte)(228)))));
            this.Label2.Location = new System.Drawing.Point(45, 100);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(77, 18);
            this.Label2.TabIndex = 22;
            this.Label2.Text = "Username";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox1.BackgroundImage")));
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureBox1.InitialImage")));
            this.PictureBox1.Location = new System.Drawing.Point(13, 115);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(26, 26);
            this.PictureBox1.TabIndex = 21;
            this.PictureBox1.TabStop = false;
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(45, 121);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(240, 20);
            this.usernameInput.TabIndex = 20;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(0)))), ((int)(((byte)(158)))));
            this.Label1.Location = new System.Drawing.Point(94, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(117, 37);
            this.Label1.TabIndex = 19;
            this.Label1.Text = "LOGIN";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(0)))), ((int)(((byte)(158)))));
            this.Panel1.Controls.Add(this.Label6);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel1.Location = new System.Drawing.Point(311, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(303, 342);
            this.Panel1.TabIndex = 18;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(227)))));
            this.Label6.Location = new System.Drawing.Point(35, 193);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(142, 42);
            this.Label6.TabIndex = 11;
            this.Label6.Text = "System";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(227)))));
            this.Label5.Location = new System.Drawing.Point(35, 151);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(236, 42);
            this.Label5.TabIndex = 10;
            this.Label5.Text = "Management";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(227)))));
            this.Label4.Location = new System.Drawing.Point(35, 109);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(153, 42);
            this.Label4.TabIndex = 9;
            this.Label4.Text = "Hospital";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 342);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.passwortInput);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Panel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button loginBtn;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.TextBox passwortInput;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.TextBox usernameInput;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
    }
}

