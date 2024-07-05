namespace AlbatrosPOS.App.Forms.Client
{
    partial class CreateClient
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
            label1 = new Label();
            nameTb = new TextBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            addressTb = new TextBox();
            addAddressBt = new Button();
            createBt = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 38);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // nameTb
            // 
            nameTb.Location = new Point(130, 38);
            nameTb.Name = "nameTb";
            nameTb.Size = new Size(644, 31);
            nameTb.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 192);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(743, 237);
            dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 95);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 3;
            label2.Text = "Dirección:";
            // 
            // addressTb
            // 
            addressTb.Location = new Point(130, 95);
            addressTb.Name = "addressTb";
            addressTb.Size = new Size(644, 31);
            addressTb.TabIndex = 4;
            // 
            // addAddressBt
            // 
            addAddressBt.Location = new Point(31, 142);
            addAddressBt.Name = "addAddressBt";
            addAddressBt.Size = new Size(199, 34);
            addAddressBt.TabIndex = 5;
            addAddressBt.Text = "Agregar dirección";
            addAddressBt.UseVisualStyleBackColor = true;
            addAddressBt.Click += addAddressBt_Click;
            // 
            // createBt
            // 
            createBt.Location = new Point(653, 436);
            createBt.Name = "createBt";
            createBt.Size = new Size(121, 34);
            createBt.TabIndex = 6;
            createBt.Text = "Crear";
            createBt.UseVisualStyleBackColor = true;
            createBt.Click += createBt_Click;
            // 
            // CreateClient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 482);
            Controls.Add(createBt);
            Controls.Add(addAddressBt);
            Controls.Add(addressTb);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(nameTb);
            Controls.Add(label1);
            Name = "CreateClient";
            Text = "CreateClient";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nameTb;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox addressTb;
        private Button addAddressBt;
        private Button createBt;
    }
}