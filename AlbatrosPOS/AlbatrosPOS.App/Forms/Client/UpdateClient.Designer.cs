namespace AlbatrosPOS.App.Forms.Client
{
    partial class UpdateClient
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
            UpdateBt = new Button();
            addAddressBt = new Button();
            addressTb = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            nameTb = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // UpdateBt
            // 
            UpdateBt.Location = new Point(651, 407);
            UpdateBt.Name = "UpdateBt";
            UpdateBt.Size = new Size(121, 34);
            UpdateBt.TabIndex = 13;
            UpdateBt.Text = "Editar";
            UpdateBt.UseVisualStyleBackColor = true;
            UpdateBt.Click += UpdateBt_Click;
            // 
            // addAddressBt
            // 
            addAddressBt.Location = new Point(29, 113);
            addAddressBt.Name = "addAddressBt";
            addAddressBt.Size = new Size(199, 34);
            addAddressBt.TabIndex = 12;
            addAddressBt.Text = "Agregar dirección";
            addAddressBt.UseVisualStyleBackColor = true;
            addAddressBt.Click += addAddressBt_Click_1;
            // 
            // addressTb
            // 
            addressTb.Location = new Point(128, 66);
            addressTb.Name = "addressTb";
            addressTb.Size = new Size(644, 31);
            addressTb.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 66);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 10;
            label2.Text = "Dirección:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(743, 237);
            dataGridView1.TabIndex = 9;
            // 
            // nameTb
            // 
            nameTb.Location = new Point(128, 9);
            nameTb.Name = "nameTb";
            nameTb.Size = new Size(644, 31);
            nameTb.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 7;
            label1.Text = "Nombre:";
            // 
            // UpdateClient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UpdateBt);
            Controls.Add(addAddressBt);
            Controls.Add(addressTb);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(nameTb);
            Controls.Add(label1);
            Name = "UpdateClient";
            Text = "UpdateClient";
            Load += UpdateClient_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UpdateBt;
        private Button addAddressBt;
        private TextBox addressTb;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox nameTb;
        private Label label1;
    }
}