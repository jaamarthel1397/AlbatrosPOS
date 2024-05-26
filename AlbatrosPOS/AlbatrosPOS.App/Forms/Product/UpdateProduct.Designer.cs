namespace AlbatrosPOS.App.Forms.Product
{
    partial class UpdateProduct
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
            descriptionTb = new TextBox();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            SaveBt = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 62);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 0;
            label1.Text = "Descripción:";
            // 
            // descriptionTb
            // 
            descriptionTb.Location = new Point(188, 60);
            descriptionTb.Name = "descriptionTb";
            descriptionTb.Size = new Size(608, 31);
            descriptionTb.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 130);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 2;
            label2.Text = "Cantidad:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(188, 124);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 31);
            numericUpDown1.TabIndex = 3;
            // 
            // SaveBt
            // 
            SaveBt.Location = new Point(684, 252);
            SaveBt.Name = "SaveBt";
            SaveBt.Size = new Size(112, 34);
            SaveBt.TabIndex = 4;
            SaveBt.Text = "Editar";
            SaveBt.UseVisualStyleBackColor = true;
            SaveBt.Click += SaveBt_Click;
            // 
            // UpdateProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 302);
            Controls.Add(SaveBt);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(descriptionTb);
            Controls.Add(label1);
            Name = "UpdateProduct";
            Text = "UpdateProduct";
            Load += UpdateProduct_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox descriptionTb;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Button SaveBt;
    }
}