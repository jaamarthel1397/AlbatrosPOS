namespace AlbatrosPOS.App.Forms.Product
{
    partial class CreateProduct
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
            SaveBt = new Button();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            descriptionTb = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // SaveBt
            // 
            SaveBt.Location = new Point(659, 235);
            SaveBt.Name = "SaveBt";
            SaveBt.Size = new Size(112, 34);
            SaveBt.TabIndex = 9;
            SaveBt.Text = "Crear";
            SaveBt.UseVisualStyleBackColor = true;
            SaveBt.Click += SaveBt_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(163, 107);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 31);
            numericUpDown1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 113);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 7;
            label2.Text = "Cantidad:";
            // 
            // descriptionTb
            // 
            descriptionTb.Location = new Point(163, 43);
            descriptionTb.Name = "descriptionTb";
            descriptionTb.Size = new Size(608, 31);
            descriptionTb.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 45);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 5;
            label1.Text = "Descripción:";
            // 
            // CreateProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 292);
            Controls.Add(SaveBt);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(descriptionTb);
            Controls.Add(label1);
            Name = "CreateProduct";
            Text = "CreateProduct";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveBt;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private TextBox descriptionTb;
        private Label label1;
    }
}