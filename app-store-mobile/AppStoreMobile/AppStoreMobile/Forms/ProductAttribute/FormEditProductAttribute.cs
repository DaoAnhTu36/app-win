using AppStoreMobile.Configurations;
using AppStoreMobile.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace AppStoreMobile.Forms.ProductAttribute
{
    public partial class FormEditProductAttribute : Form
    {
        private readonly DbContextOptions<AppDbContext> _options;

        public FormEditProductAttribute(DbContextOptions<AppDbContext> options
            , int id
            , string key
            , string value
            , bool status)
        {
            InitializeComponent();
            _options = options;
            txtID.Text = id.ToString();
            txtTenThuocTinh.Text = key.ToString();
            txtGiaTri.Text = value.ToString();
            checkBoxTrangThai.Checked = status;
        }

        private void FormEditProductAttribute_Load(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext(_options);
            var data = db.ProductAttributeEntity.FirstOrDefault(x => x.Id.ToString() == txtID.Text);
            if (data == null)
            {
                MessageBox.Show(ConfigMessageNotify.NOT_FOUND_RECORD);
                return;
            }
            data.AttributeValue = txtGiaTri.Text;
            data.AttributeName = txtTenThuocTinh.Text;
            data.IsActive = checkBoxTrangThai.Checked;
            db.ProductAttributeEntity.Update(data);
            db.SaveChanges();
            MessageBox.Show(ConfigMessageNotify.UPDATE_RECORD);
        }
    }
}