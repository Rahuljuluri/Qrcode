namespace barcode
{
    partial class Form1
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
            pictureBox = new PictureBox();
            btnBarcode = new Button();
            label1 = new Label();
            txtBarcode = new TextBox();
            txtQRcode = new TextBox();
            label2 = new Label();
            btnQRcode = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
            pictureBox.Location = new Point(12, 23);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(844, 245);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // btnBarcode
            // 
            btnBarcode.Location = new Point(535, 357);
            btnBarcode.Name = "btnBarcode";
            btnBarcode.Size = new Size(94, 34);
            btnBarcode.TabIndex = 1;
            btnBarcode.Text = "BARCODE";
            btnBarcode.UseVisualStyleBackColor = true;
            btnBarcode.Click += btnBarcode_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 362);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 2;
            label1.Text = "BARCODE";
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(136, 357);
            txtBarcode.Multiline = true;
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(356, 34);
            txtBarcode.TabIndex = 3;
            // 
            // txtQRcode
            // 
            txtQRcode.Location = new Point(136, 414);
            txtQRcode.Multiline = true;
            txtQRcode.Name = "txtQRcode";
            txtQRcode.Size = new Size(356, 34);
            txtQRcode.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 419);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 5;
            label2.Text = "QRCODE";
            // 
            // btnQRcode
            // 
            btnQRcode.Location = new Point(535, 414);
            btnQRcode.Name = "btnQRcode";
            btnQRcode.Size = new Size(94, 34);
            btnQRcode.TabIndex = 4;
            btnQRcode.Text = "QRCODE";
            btnQRcode.UseVisualStyleBackColor = true;
            btnQRcode.Click += btnQRcode_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 519);
            Controls.Add(txtQRcode);
            Controls.Add(label2);
            Controls.Add(btnQRcode);
            Controls.Add(txtBarcode);
            Controls.Add(label1);
            Controls.Add(btnBarcode);
            Controls.Add(pictureBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Button btnBarcode;
        private Label label1;
        private TextBox txtBarcode;
        private TextBox txtQRcode;
        private Label label2;
        private Button btnQRcode;
    }
}
