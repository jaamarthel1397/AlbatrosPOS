namespace AlbatrosPOS.App.Forms
{
    partial class MainMenu
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
            clientsBt = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(clientsBt);
            panel1.Location = new Point(13, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 1112);
            panel1.TabIndex = 0;
            // 
            // clientsBt
            // 
            clientsBt.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            clientsBt.Location = new Point(8, 12);
            clientsBt.Name = "clientsBt";
            clientsBt.Size = new Size(344, 241);
            clientsBt.TabIndex = 0;
            clientsBt.Text = "Clientes";
            clientsBt.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(8, 276);
            button2.Name = "button2";
            button2.Size = new Size(344, 241);
            button2.TabIndex = 1;
            button2.Text = "Productos";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(8, 542);
            button3.Name = "button3";
            button3.Size = new Size(344, 241);
            button3.TabIndex = 2;
            button3.Text = "Pedidos";
            button3.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1983, 1152);
            Controls.Add(panel1);
            Name = "MainMenu";
            Text = "MainMenu";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button clientsBt;
        private Button button3;
    }
}