
using AlbatrosPOS.App.Models;
using System.Security.Claims;
using System.Text;
using System.Text.Json;

namespace AlbatrosPOS.App
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label3 = new Label();
            passwordTf = new TextBox();
            usernameTb = new TextBox();
            label2 = new Label();
            UserLabel = new Label();
            registerBt = new Button();
            label1 = new Label();
            loginBt = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(passwordTf);
            panel1.Controls.Add(usernameTb);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(UserLabel);
            panel1.Controls.Add(registerBt);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(loginBt);
            panel1.Location = new Point(530, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(714, 613);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold);
            label3.Location = new Point(137, 75);
            label3.Name = "label3";
            label3.Size = new Size(416, 81);
            label3.TabIndex = 7;
            label3.Text = "BIENVENIDO";
            // 
            // passwordTf
            // 
            passwordTf.Location = new Point(231, 278);
            passwordTf.Name = "passwordTf";
            passwordTf.Size = new Size(222, 31);
            passwordTf.TabIndex = 6;
            passwordTf.UseSystemPasswordChar = true;
            // 
            // usernameTb
            // 
            usernameTb.Location = new Point(231, 208);
            usernameTb.Name = "usernameTb";
            usernameTb.Size = new Size(222, 31);
            usernameTb.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 250);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 4;
            label2.Text = "Constraseña";
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Location = new Point(231, 180);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(72, 25);
            UserLabel.TabIndex = 3;
            UserLabel.Text = "Usuario";
            // 
            // registerBt
            // 
            registerBt.Location = new Point(231, 467);
            registerBt.Name = "registerBt";
            registerBt.Size = new Size(220, 44);
            registerBt.TabIndex = 2;
            registerBt.Text = "Crear usuario";
            registerBt.UseVisualStyleBackColor = true;
            registerBt.Click += registerBt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(200, 429);
            label1.Name = "label1";
            label1.Size = new Size(299, 25);
            label1.TabIndex = 1;
            label1.Text = "¿No tienes usuario? Regístrate ahora";
            // 
            // loginBt
            // 
            loginBt.Location = new Point(231, 337);
            loginBt.Name = "loginBt";
            loginBt.Size = new Size(220, 44);
            loginBt.TabIndex = 0;
            loginBt.Text = "Iniciar sesión";
            loginBt.UseVisualStyleBackColor = true;
            loginBt.Click += loginBt_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1773, 939);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button loginBt;
        private Button registerBt;
        private Label label1;
        private TextBox passwordTf;
        private TextBox usernameTb;
        private Label label2;
        private Label UserLabel;
        private Label label3;
    }
}
