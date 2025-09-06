namespace AppStoreMobile.Forms
{
    partial class FormCreateProductAttribute
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
            label2 = new Label();
            txtGiaTri = new TextBox();
            btnSave = new Button();
            txtTenThuocTinh = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 54);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 10;
            label2.Text = "Giá trị";
            // 
            // txtGiaTri
            // 
            txtGiaTri.Location = new Point(109, 51);
            txtGiaTri.Name = "txtGiaTri";
            txtGiaTri.Size = new Size(200, 23);
            txtGiaTri.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(19, 92);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(72, 25);
            btnSave.TabIndex = 8;
            btnSave.Text = "Lưu lại";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtTenThuocTinh
            // 
            txtTenThuocTinh.Location = new Point(109, 12);
            txtTenThuocTinh.Name = "txtTenThuocTinh";
            txtTenThuocTinh.Size = new Size(200, 23);
            txtTenThuocTinh.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 15);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 6;
            label1.Text = "Tên thuộc tính";
            // 
            // FormCreateProductAttribute
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtGiaTri);
            Controls.Add(btnSave);
            Controls.Add(txtTenThuocTinh);
            Controls.Add(label1);
            Name = "FormCreateProductAttribute";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm mới thuộc tính";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtGiaTri;
        private Button btnSave;
        private TextBox txtTenThuocTinh;
        private Label label1;
    }
}