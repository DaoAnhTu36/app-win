using AppStoreMobile.DatabaseContext;
using AppStoreMobile.Forms;
using Microsoft.EntityFrameworkCore;

namespace AppStoreMobile
{
    public partial class Form1 : Form
    {
        private readonly DbContextOptions<AppDbContext> _options;

        public Form1(DbContextOptions<AppDbContext> options)
        {
            InitializeComponent();
            _options = options;
        }

        private void itemMenuDanhMuc_Click(object sender, EventArgs e)
        {
        }

        private void itemMenuSanPham_Click(object sender, EventArgs e)
        {
        }

        private void itemMenuThuocTinh_Click(object sender, EventArgs e)
        {
            var formListProductAttribute = new FormListProductAttribute(_options);
            formListProductAttribute.MdiParent = this;
            formListProductAttribute.Show();
        }

        private void itemMenuHinhAnh_Click(object sender, EventArgs e)
        {
        }

        private void subItemMenuDanhMucThemMoi_Click(object sender, EventArgs e)
        {
            var formCreateCategory = new FormCreateCategory(_options);
            formCreateCategory.MdiParent = this;
            formCreateCategory.Show();
        }

        private void subItemMenuThuocTinhThemMoi_Click(object sender, EventArgs e)
        {
            var formCreateProductAttribute = new FormCreateProductAttribute(_options);
            formCreateProductAttribute.MdiParent = this;
            formCreateProductAttribute.Show();
        }
    }
}