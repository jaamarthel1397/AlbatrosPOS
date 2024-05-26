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
            ordersPanel = new Panel();
            deleteOrderBt = new Button();
            addOrderBt = new Button();
            ordersDgv = new DataGridView();
            clientsPanel = new Panel();
            button1 = new Button();
            createClient = new Button();
            clientsDgv = new DataGridView();
            productsPanel = new Panel();
            button5 = new Button();
            button6 = new Button();
            productsDgv = new DataGridView();
            panel1.SuspendLayout();
            ordersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ordersDgv).BeginInit();
            clientsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clientsDgv).BeginInit();
            productsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productsDgv).BeginInit();
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
            button3.Click += button3_Click;
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
            button2.Click += button2_Click;
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
            clientsBt.Click += clientsBt_Click;
            // 
            // ordersPanel
            // 
            ordersPanel.Controls.Add(deleteOrderBt);
            ordersPanel.Controls.Add(addOrderBt);
            ordersPanel.Controls.Add(ordersDgv);
            ordersPanel.Location = new Point(408, 27);
            ordersPanel.Name = "ordersPanel";
            ordersPanel.Size = new Size(1529, 1108);
            ordersPanel.TabIndex = 1;
            ordersPanel.Visible = false;
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
            ordersDgv.CellDoubleClick += ordersDgv_CellDoubleClick;
            // 
            // clientsPanel
            // 
            clientsPanel.Controls.Add(button1);
            clientsPanel.Controls.Add(createClient);
            clientsPanel.Controls.Add(clientsDgv);
            clientsPanel.Location = new Point(380, 47);
            clientsPanel.Name = "clientsPanel";
            clientsPanel.Size = new Size(1529, 1108);
            clientsPanel.TabIndex = 1;
            clientsPanel.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(241, 78);
            button1.Name = "button1";
            button1.Size = new Size(192, 52);
            button1.TabIndex = 2;
            button1.Text = "Eliminar cliente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += DeleteClient_Click_1;
            // 
            // createClient
            // 
            createClient.Location = new Point(27, 78);
            createClient.Name = "createClient";
            createClient.Size = new Size(192, 52);
            createClient.TabIndex = 1;
            createClient.Text = "Crear cliente";
            createClient.UseVisualStyleBackColor = true;
            createClient.Click += createClient_Click;
            // 
            // clientsDgv
            // 
            clientsDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientsDgv.Location = new Point(27, 158);
            clientsDgv.Name = "clientsDgv";
            clientsDgv.RowHeadersWidth = 62;
            clientsDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            clientsDgv.Size = new Size(1465, 708);
            clientsDgv.TabIndex = 0;
            clientsDgv.CellDoubleClick += clientsDgv_CellDoubleClick;
            // 
            // productsPanel
            // 
            productsPanel.Controls.Add(button5);
            productsPanel.Controls.Add(button6);
            productsPanel.Controls.Add(productsDgv);
            productsPanel.Location = new Point(383, 35);
            productsPanel.Name = "productsPanel";
            productsPanel.Size = new Size(1529, 1108);
            productsPanel.TabIndex = 1;
            productsPanel.Visible = false;
            // 
            // button5
            // 
            button5.Location = new Point(241, 78);
            button5.Name = "button5";
            button5.Size = new Size(192, 52);
            button5.TabIndex = 2;
            button5.Text = "Eliminar producto";
            button5.UseVisualStyleBackColor = true;
            button5.Click += deleteProduct_Click;
            // 
            // button6
            // 
            button6.Location = new Point(27, 78);
            button6.Name = "button6";
            button6.Size = new Size(192, 52);
            button6.TabIndex = 1;
            button6.Text = "Crear producto";
            button6.UseVisualStyleBackColor = true;
            button6.Click += createProduct_Click;
            // 
            // productsDgv
            // 
            productsDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsDgv.Location = new Point(27, 158);
            productsDgv.Name = "productsDgv";
            productsDgv.RowHeadersWidth = 62;
            productsDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsDgv.Size = new Size(1465, 708);
            productsDgv.TabIndex = 0;
            productsDgv.CellDoubleClick += productsDgv_CellDoubleClick;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1983, 1152);
            Controls.Add(clientsPanel);
            Controls.Add(productsPanel);
            Controls.Add(ordersPanel);
            Controls.Add(panel1);
            Name = "MainMenu";
            Text = "MainMenu";
            Load += MainMenu_Load;
            panel1.ResumeLayout(false);
            ordersPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ordersDgv).EndInit();
            clientsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)clientsDgv).EndInit();
            productsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productsDgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button clientsBt;
        private Button button3;
        private Panel ordersPanel;
        private Button deleteOrderBt;
        private Button addOrderBt;
        private DataGridView ordersDgv;
        private DataGridViewTextBoxColumn ClientName;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn ClientId;
        private DataGridViewTextBoxColumn AddressId;
        private Panel clientsPanel;
        private Panel productsPanel;
        private Button button5;
        private Button button6;
        private DataGridView productsDgv;
        private Button button1;
        private Button createClient;
        private DataGridView clientsDgv;
    }
}