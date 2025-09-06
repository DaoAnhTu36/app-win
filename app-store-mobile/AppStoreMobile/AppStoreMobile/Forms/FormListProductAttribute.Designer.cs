namespace AppStoreMobile.Forms
{
    partial class FormListProductAttribute
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
            dgvProductAttribute = new DataGridView();
            btnCreatePorductAttribute = new Button();
            attribute_name = new DataGridViewTextBoxColumn();
            attribute_value = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProductAttribute).BeginInit();
            SuspendLayout();
            // 
            // dgvProductAttribute
            // 
            dgvProductAttribute.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductAttribute.Columns.AddRange(new DataGridViewColumn[] { attribute_name, attribute_value });
            dgvProductAttribute.Dock = DockStyle.Bottom;
            dgvProductAttribute.Location = new Point(0, 50);
            dgvProductAttribute.Name = "dgvProductAttribute";
            dgvProductAttribute.Size = new Size(800, 400);
            dgvProductAttribute.TabIndex = 0;
            dgvProductAttribute.CellClick += dgvProductAttribute_CellClick;
            // 
            // btnCreatePorductAttribute
            // 
            btnCreatePorductAttribute.Location = new Point(12, 12);
            btnCreatePorductAttribute.Name = "btnCreatePorductAttribute";
            btnCreatePorductAttribute.Size = new Size(75, 23);
            btnCreatePorductAttribute.TabIndex = 1;
            btnCreatePorductAttribute.Text = "Thêm mới";
            btnCreatePorductAttribute.UseVisualStyleBackColor = true;
            btnCreatePorductAttribute.Click += btnCreatePorductAttribute_Click;
            // 
            // attribute_name
            // 
            attribute_name.HeaderText = "Tên thuộc tính";
            attribute_name.Name = "attribute_name";
            // 
            // attribute_value
            // 
            attribute_value.HeaderText = "Giá trị";
            attribute_value.Name = "attribute_value";
            // 
            // FormListProductAttribute
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreatePorductAttribute);
            Controls.Add(dgvProductAttribute);
            Name = "FormListProductAttribute";
            Text = "Danh sách thuộc tính sản phẩm";
            Load += FormListProductAttribute_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductAttribute).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProductAttribute;
        private Button btnCreatePorductAttribute;
        private DataGridViewTextBoxColumn attribute_name;
        private DataGridViewTextBoxColumn attribute_value;
    }
}