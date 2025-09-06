namespace AppStoreMobile.Forms.ProductAttribute
{
    partial class FormEditProductAttribute
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
            txtID = new TextBox();
            txtTenThuocTinh = new TextBox();
            label2 = new Label();
            txtGiaTri = new TextBox();
            label3 = new Label();
            btnSave = new Button();
            label4 = new Label();
            checkBoxTrangThai = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(105, 6);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(201, 23);
            txtID.TabIndex = 1;
            // 
            // txtTenThuocTinh
            // 
            txtTenThuocTinh.Location = new Point(105, 35);
            txtTenThuocTinh.Name = "txtTenThuocTinh";
            txtTenThuocTinh.Size = new Size(201, 23);
            txtTenThuocTinh.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 2;
            label2.Text = "Tên thuộc tính";
            // 
            // txtGiaTri
            // 
            txtGiaTri.Location = new Point(105, 64);
            txtGiaTri.Name = "txtGiaTri";
            txtGiaTri.Size = new Size(201, 23);
            txtGiaTri.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "Giá trị";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(231, 137);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Lưu lại";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 97);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 6;
            label4.Text = "Trạng thái";
            // 
            // checkBoxTrangThai
            // 
            checkBoxTrangThai.AutoSize = true;
            checkBoxTrangThai.Location = new Point(105, 97);
            checkBoxTrangThai.Name = "checkBoxTrangThai";
            checkBoxTrangThai.Size = new Size(83, 19);
            checkBoxTrangThai.TabIndex = 7;
            checkBoxTrangThai.Text = "Hoạt động";
            checkBoxTrangThai.UseVisualStyleBackColor = true;
            // 
            // FormEditProductAttribute
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBoxTrangThai);
            Controls.Add(label4);
            Controls.Add(btnSave);
            Controls.Add(txtGiaTri);
            Controls.Add(label3);
            Controls.Add(txtTenThuocTinh);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            Name = "FormEditProductAttribute";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chỉnh sửa thuộc tính";
            Load += FormEditProductAttribute_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtID;
        private TextBox txtTenThuocTinh;
        private Label label2;
        private TextBox txtGiaTri;
        private Label label3;
        private Button btnSave;
        private Label label4;
        private CheckBox checkBoxTrangThai;
    }
}