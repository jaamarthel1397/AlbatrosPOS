namespace AlbatrosPOS.App.Forms.Order
{
    partial class CreateOrder
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
            getAddressesBt = new Button();
            createOrderBt = new Button();
            amountDd = new NumericUpDown();
            label4 = new Label();
            productCb = new ComboBox();
            label3 = new Label();
            addProductBt = new Button();
            detailsDgv = new DataGridView();
            addressCb = new ComboBox();
            label2 = new Label();
            clientsCb = new ComboBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)amountDd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detailsDgv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(getAddressesBt);
            panel1.Controls.Add(createOrderBt);
            panel1.Controls.Add(amountDd);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(productCb);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(addProductBt);
            panel1.Controls.Add(detailsDgv);
            panel1.Controls.Add(addressCb);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(clientsCb);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(22, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(2013, 1174);
            panel1.TabIndex = 0;
            // 
            // getAddressesBt
            // 
            getAddressesBt.Location = new Point(329, 49);
            getAddressesBt.Name = "getAddressesBt";
            getAddressesBt.Size = new Size(184, 34);
            getAddressesBt.TabIndex = 11;
            getAddressesBt.Text = "Obtener direcciones";
            getAddressesBt.UseVisualStyleBackColor = true;
            getAddressesBt.Click += getAddressesBt_Click;
            // 
            // createOrderBt
            // 
            createOrderBt.Location = new Point(1781, 258);
            createOrderBt.Name = "createOrderBt";
            createOrderBt.Size = new Size(198, 34);
            createOrderBt.TabIndex = 10;
            createOrderBt.Text = "Crear pedido";
            createOrderBt.UseVisualStyleBackColor = true;
            createOrderBt.Click += createOrderBt_Click;
            // 
            // amountDd
            // 
            amountDd.Location = new Point(436, 260);
            amountDd.Name = "amountDd";
            amountDd.Size = new Size(180, 31);
            amountDd.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(343, 261);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 8;
            label4.Text = "Cantidad:";
            // 
            // productCb
            // 
            productCb.FormattingEnabled = true;
            productCb.Location = new Point(142, 258);
            productCb.Name = "productCb";
            productCb.Size = new Size(182, 33);
            productCb.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 261);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 6;
            label3.Text = "Producto:";
            // 
            // addProductBt
            // 
            addProductBt.Location = new Point(646, 258);
            addProductBt.Name = "addProductBt";
            addProductBt.Size = new Size(112, 34);
            addProductBt.TabIndex = 5;
            addProductBt.Text = "Agregar producto";
            addProductBt.UseVisualStyleBackColor = true;
            addProductBt.Click += AddProductBt_Click;
            // 
            // detailsDgv
            // 
            detailsDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            detailsDgv.Location = new Point(38, 311);
            detailsDgv.Name = "detailsDgv";
            detailsDgv.RowHeadersWidth = 62;
            detailsDgv.Size = new Size(1941, 835);
            detailsDgv.TabIndex = 4;
            // 
            // addressCb
            // 
            addressCb.FormattingEnabled = true;
            addressCb.Location = new Point(649, 49);
            addressCb.Name = "addressCb";
            addressCb.Size = new Size(586, 33);
            addressCb.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(536, 52);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 2;
            label2.Text = "Dirección";
            // 
            // clientsCb
            // 
            clientsCb.FormattingEnabled = true;
            clientsCb.Location = new Point(128, 49);
            clientsCb.Name = "clientsCb";
            clientsCb.Size = new Size(182, 33);
            clientsCb.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 52);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // CreateOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2047, 1217);
            Controls.Add(panel1);
            Name = "CreateOrder";
            Text = "CreateOrder";
            Load += CreateOrder_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)amountDd).EndInit();
            ((System.ComponentModel.ISupportInitialize)detailsDgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView detailsDgv;
        private ComboBox addressCb;
        private Label label2;
        private ComboBox clientsCb;
        private Label label1;
        private ComboBox productCb;
        private Label label3;
        private Button addProductBt;
        private Button createOrderBt;
        private NumericUpDown amountDd;
        private Label label4;
        private Button getAddressesBt;
    }
}