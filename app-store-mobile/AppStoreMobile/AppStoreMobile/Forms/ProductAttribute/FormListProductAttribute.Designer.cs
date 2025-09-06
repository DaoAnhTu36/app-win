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
            id = new DataGridViewTextBoxColumn();
            attribute_name = new DataGridViewTextBoxColumn();
            attribute_value = new DataGridViewTextBoxColumn();
            is_active = new DataGridViewTextBoxColumn();
            btnCreatePorductAttribute = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductAttribute).BeginInit();
            SuspendLayout();
            // 
            // dgvProductAttribute
            // 
            dgvProductAttribute.AllowUserToAddRows = false;
            dgvProductAttribute.AllowUserToDeleteRows = false;
            dgvProductAttribute.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductAttribute.Columns.AddRange(new DataGridViewColumn[] { id, attribute_name, attribute_value, is_active });
            dgvProductAttribute.Location = new Point(0, 50);
            dgvProductAttribute.Name = "dgvProductAttribute";
            dgvProductAttribute.ReadOnly = true;
            dgvProductAttribute.Size = new Size(800, 400);
            dgvProductAttribute.TabIndex = 0;
            dgvProductAttribute.CellDoubleClick += dgvProductAttribute_CellDoubleClick;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // attribute_name
            // 
            attribute_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            attribute_name.HeaderText = "Tên thuộc tính";
            attribute_name.Name = "attribute_name";
            attribute_name.ReadOnly = true;
            // 
            // attribute_value
            // 
            attribute_value.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            attribute_value.HeaderText = "Giá trị";
            attribute_value.Name = "attribute_value";
            attribute_value.ReadOnly = true;
            // 
            // is_active
            // 
            is_active.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            is_active.HeaderText = "Trạng thái";
            is_active.Name = "is_active";
            is_active.ReadOnly = true;
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
            // FormListProductAttribute
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreatePorductAttribute);
            Controls.Add(dgvProductAttribute);
            Name = "FormListProductAttribute";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Danh sách thuộc tính sản phẩm";
            Load += FormListProductAttribute_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductAttribute).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProductAttribute;
        private Button btnCreatePorductAttribute;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn attribute_name;
        private DataGridViewTextBoxColumn attribute_value;
        private DataGridViewTextBoxColumn is_active;
    }
}