using AppStoreMobile.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace AppStoreMobile.Forms
{
    public partial class FormListProductAttribute : Form
    {
        private readonly DbContextOptions<AppDbContext> _options;

        public FormListProductAttribute(DbContextOptions<AppDbContext> options)
        {
            InitializeComponent();
            _options = options;
        }

        private void btnCreatePorductAttribute_Click(object sender, EventArgs e)
        {
            this.Close();
            FormCreateProductAttribute formCreateProductAttribute = new FormCreateProductAttribute(_options);
            formCreateProductAttribute.Show();
        }

        private void FormListProductAttribute_Load(object sender, EventArgs e)
        {
            using var db = new AppDbContext(_options);
            var data = db.ProductAttributeEntity.ToList();
            foreach (var item in data)
            {
                dgvProductAttribute.Rows.Add(item.AttributeName, item.AttributeValue);
            }

            //dgvProductAttribute.DataSource = data;
        }

        private void dgvProductAttribute_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProductAttribute.Rows[e.RowIndex];
                string name = row.Cells["Name"].Value?.ToString();
                MessageBox.Show("Bạn vừa click vào: " + name);
            }
        }

        private void dgvProductAttribute_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProductAttribute.Rows[e.RowIndex];
                string name = row.Cells["attribute_name"].Value?.ToString();
                MessageBox.Show("Bạn vừa click vào: " + name);
            }
        }
    }
}