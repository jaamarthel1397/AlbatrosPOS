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
            button3 = new Button();
            button2 = new Button();
            clientsBt = new Button();
            panel2 = new Panel();
            deleteOrderBt = new Button();
            addOrderBt = new Button();
            ordersDgv = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ordersDgv).BeginInit();
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
            // panel2
            // 
            panel2.Controls.Add(deleteOrderBt);
            panel2.Controls.Add(addOrderBt);
            panel2.Controls.Add(ordersDgv);
            panel2.Location = new Point(408, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(1529, 1108);
            panel2.TabIndex = 1;
            // 
            // deleteOrderBt
            // 
            deleteOrderBt.Location = new Point(241, 78);
            deleteOrderBt.Name = "deleteOrderBt";
            deleteOrderBt.Size = new Size(192, 52);
            deleteOrderBt.TabIndex = 2;
            deleteOrderBt.Text = "Eliminar pedido";
            deleteOrderBt.UseVisualStyleBackColor = true;
            deleteOrderBt.Click += button1_Click;
            // 
            // addOrderBt
            // 
            addOrderBt.Location = new Point(27, 78);
            addOrderBt.Name = "addOrderBt";
            addOrderBt.Size = new Size(192, 52);
            addOrderBt.TabIndex = 1;
            addOrderBt.Text = "Crear pedido";
            addOrderBt.UseVisualStyleBackColor = true;
            addOrderBt.Click += addOrderBt_Click;
            // 
            // ordersDgv
            // 
            ordersDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersDgv.Location = new Point(27, 158);
            ordersDgv.Name = "ordersDgv";
            ordersDgv.RowHeadersWidth = 62;
            ordersDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ordersDgv.Size = new Size(1465, 708);
            ordersDgv.TabIndex = 0;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1983, 1152);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainMenu";
            Text = "MainMenu";
            Load += MainMenu_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ordersDgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button clientsBt;
        private Button button3;
        private Panel panel2;
        private Button deleteOrderBt;
        private Button addOrderBt;
        private DataGridView ordersDgv;
        private DataGridViewTextBoxColumn ClientName;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn ClientId;
        private DataGridViewTextBoxColumn AddressId;
    }
}