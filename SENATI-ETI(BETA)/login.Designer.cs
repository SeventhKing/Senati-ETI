namespace LoginETI
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblErrorLogin = new System.Windows.Forms.Label();
            this.txtCorreo1 = new SENATI_ETI_BETA_.textBox();
            this.txtPassword1 = new SENATI_ETI_BETA_.textBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(52)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(571, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ETI | APLICACION SEGUIMIENTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(752, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese su cuenta";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::APPSENATI2022.Properties.Resources.seantiimagen2;
            this.pictureBox1.Location = new System.Drawing.Point(408, 233);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(86)))), ((int)(((byte)(160)))));
            this.btnIngresar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(718, 421);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(239, 27);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblErrorLogin
            // 
            this.lblErrorLogin.AutoSize = true;
            this.lblErrorLogin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblErrorLogin.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorLogin.Location = new System.Drawing.Point(740, 396);
            this.lblErrorLogin.Name = "lblErrorLogin";
            this.lblErrorLogin.Size = new System.Drawing.Size(184, 13);
            this.lblErrorLogin.TabIndex = 7;
            this.lblErrorLogin.Text = "El correo o password es incorrecto";
            this.lblErrorLogin.Visible = false;
            // 
            // txtCorreo1
            // 
            this.txtCorreo1.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCorreo1.BorderColor = System.Drawing.Color.Silver;
            this.txtCorreo1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCorreo1.BorderRadius = 15;
            this.txtCorreo1.BorderSize = 2;
            this.txtCorreo1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCorreo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCorreo1.Location = new System.Drawing.Point(718, 303);
            this.txtCorreo1.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo1.Multiline = false;
            this.txtCorreo1.Name = "txtCorreo1";
            this.txtCorreo1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCorreo1.PasswordChar = false;
            this.txtCorreo1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCorreo1.PlaceholderText = "";
            this.txtCorreo1.Size = new System.Drawing.Size(239, 31);
            this.txtCorreo1.TabIndex = 8;
            this.txtCorreo1.Texts = "";
            this.txtCorreo1.UnderlinedStyle = false;
            this.txtCorreo1._TextChanged += new System.EventHandler(this.txtCorreo1__TextChanged);
            // 
            // txtPassword1
            // 
            this.txtPassword1.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPassword1.BorderColor = System.Drawing.Color.Silver;
            this.txtPassword1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPassword1.BorderRadius = 15;
            this.txtPassword1.BorderSize = 2;
            this.txtPassword1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPassword1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword1.Location = new System.Drawing.Point(718, 349);
            this.txtPassword1.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword1.Multiline = false;
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPassword1.PasswordChar = true;
            this.txtPassword1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword1.PlaceholderText = "";
            this.txtPassword1.Size = new System.Drawing.Size(239, 31);
            this.txtPassword1.TabIndex = 8;
            this.txtPassword1.Texts = "";
            this.txtPassword1.UnderlinedStyle = false;
            this.txtPassword1._TextChanged += new System.EventHandler(this.txtPassword__TextChanged);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1425, 814);
            this.Controls.Add(this.txtPassword1);
            this.Controls.Add(this.txtCorreo1);
            this.Controls.Add(this.lblErrorLogin);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnIngresar;
        private Label lblErrorLogin;
        private SENATI_ETI_BETA_.textBox txtCorreo1;
        private SENATI_ETI_BETA_.textBox txtPassword1;
    }
}