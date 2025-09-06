using AppStoreMobile.DatabaseContext;
using AppStoreMobile.Forms.ProductAttribute;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

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
                dgvProductAttribute.Rows.Add(item.Id, item.AttributeName, item.AttributeValue, item.IsActive);
            }
        }

        private void dgvProductAttribute_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProductAttribute.Rows[e.RowIndex];
                var id = int.Parse(row.Cells["id"].Value.ToString());
                var attributeName = row.Cells["attribute_name"].Value.ToString();
                var attributeValue = row.Cells["attribute_value"].Value.ToString();
                var isActive = bool.Parse(row.Cells["is_active"].Value.ToString());
                FormEditProductAttribute formEditProductAttribute = new(_options, id, attributeName, attributeValue, isActive);
                formEditProductAttribute.ShowDialog();
            }
        }
    }
}