namespace AppStoreMobile.Forms
{
    partial class FormCreateCategory
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
            textBoxTenDanhMuc = new TextBox();
            lblTenDanhMuc = new Label();
            lblDanhMucCha = new Label();
            comboBoxDanhMucCha = new ComboBox();
            btnSave = new Button();
            richTextBoxMota = new RichTextBox();
            lblMota = new Label();
            SuspendLayout();
            // 
            // textBoxTenDanhMuc
            // 
            textBoxTenDanhMuc.Location = new Point(101, 31);
            textBoxTenDanhMuc.Name = "textBoxTenDanhMuc";
            textBoxTenDanhMuc.Size = new Size(250, 23);
            textBoxTenDanhMuc.TabIndex = 0;
            // 
            // lblTenDanhMuc
            // 
            lblTenDanhMuc.AutoSize = true;
            lblTenDanhMuc.Location = new Point(12, 34);
            lblTenDanhMuc.Name = "lblTenDanhMuc";
            lblTenDanhMuc.Size = new Size(83, 15);
            lblTenDanhMuc.TabIndex = 1;
            lblTenDanhMuc.Text = "Tên danh mục";
            // 
            // lblDanhMucCha
            // 
            lblDanhMucCha.AutoSize = true;
            lblDanhMucCha.Location = new Point(12, 77);
            lblDanhMucCha.Name = "lblDanhMucCha";
            lblDanhMucCha.Size = new Size(84, 15);
            lblDanhMucCha.TabIndex = 3;
            lblDanhMucCha.Text = "Danh mục cha";
            // 
            // comboBoxDanhMucCha
            // 
            comboBoxDanhMucCha.FormattingEnabled = true;
            comboBoxDanhMucCha.Location = new Point(102, 74);
            comboBoxDanhMucCha.Name = "comboBoxDanhMucCha";
            comboBoxDanhMucCha.Size = new Size(250, 23);
            comboBoxDanhMucCha.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 216);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Lưu lại";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // richTextBoxMota
            // 
            richTextBoxMota.Location = new Point(102, 107);
            richTextBoxMota.Name = "richTextBoxMota";
            richTextBoxMota.Size = new Size(249, 96);
            richTextBoxMota.TabIndex = 7;
            richTextBoxMota.Text = "";
            // 
            // lblMota
            // 
            lblMota.AutoSize = true;
            lblMota.Location = new Point(12, 110);
            lblMota.Name = "lblMota";
            lblMota.Size = new Size(38, 15);
            lblMota.TabIndex = 8;
            lblMota.Text = "Mô tả";
            // 
            // FormCreateCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMota);
            Controls.Add(richTextBoxMota);
            Controls.Add(btnSave);
            Controls.Add(comboBoxDanhMucCha);
            Controls.Add(lblDanhMucCha);
            Controls.Add(lblTenDanhMuc);
            Controls.Add(textBoxTenDanhMuc);
            Name = "FormCreateCategory";
            Text = "Thêm mới danh mục";
            Load += FormCreateCategory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTenDanhMuc;
        private Label lblTenDanhMuc;
        private Label lblDanhMucCha;
        private ComboBox comboBoxDanhMucCha;
        private Button btnSave;
        private RichTextBox richTextBoxMota;
        private Label lblMota;
    }
}