namespace AlbatrosPOS.App.Forms
{
    partial class Register
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
            panel1 = new Panel();
            label3 = new Label();
            passwordTf = new TextBox();
            usernameTb = new TextBox();
            label2 = new Label();
            UserLabel = new Label();
            registerBt = new Button();
            resultTx = new Label();
            returnBt = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(returnBt);
            panel1.Controls.Add(resultTx);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(passwordTf);
            panel1.Controls.Add(usernameTb);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(UserLabel);
            panel1.Controls.Add(registerBt);
            panel1.Location = new Point(626, 255);
            panel1.Name = "panel1";
            panel1.Size = new Size(714, 613);
            panel1.TabIndex = 1;
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
            registerBt.Location = new Point(231, 337);
            registerBt.Name = "registerBt";
            registerBt.Size = new Size(220, 44);
            registerBt.TabIndex = 0;
            registerBt.Text = "Registrar";
            registerBt.UseVisualStyleBackColor = true;
            registerBt.Click += registerBt_Click;
            // 
            // resultTx
            // 
            resultTx.AutoSize = true;
            resultTx.Location = new Point(231, 417);
            resultTx.Name = "resultTx";
            resultTx.Size = new Size(0, 25);
            resultTx.TabIndex = 8;
            // 
            // returnBt
            // 
            returnBt.Location = new Point(231, 445);
            returnBt.Name = "returnBt";
            returnBt.Size = new Size(222, 34);
            returnBt.TabIndex = 9;
            returnBt.Text = "Regresar";
            returnBt.UseVisualStyleBackColor = true;
            returnBt.Visible = false;
            returnBt.Click += returnBt_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1966, 1122);
            Controls.Add(panel1);
            Name = "Register";
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private TextBox passwordTf;
        private TextBox usernameTb;
        private Label label2;
        private Label UserLabel;
        private Button registerBt;
        private Label label1;
        private Label resultTx;
        private Button returnBt;
    }
}