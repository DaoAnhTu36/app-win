using AppStoreMobile.DatabaseContext;
using AppStoreMobile.Entities;
using Microsoft.EntityFrameworkCore;

namespace AppStoreMobile.Forms
{
    public partial class FormCreateCategory : Form
    {
        private readonly DbContextOptions<AppDbContext> _options;

        public FormCreateCategory(DbContextOptions<AppDbContext> options)
        {
            InitializeComponent();
            _options = options;
        }

        private void FormCreateCategory_Load(object sender, EventArgs e)
        {
            using var db = new AppDbContext(_options);
            var categories = db.CategoryEntity.ToList();
            comboBoxDanhMucCha.DataSource = categories;
            comboBoxDanhMucCha.DisplayMember = "Name";
            comboBoxDanhMucCha.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int parentId = 0;
            if (comboBoxDanhMucCha.SelectedValue != null)
            {
                parentId = (int)comboBoxDanhMucCha.SelectedValue;
            }
            var categoryName = textBoxTenDanhMuc.Text;
            var description = richTextBoxMota.Text;
            var dataInsert = new Categories
            {
                Description = description,
                Name = categoryName,
                ParentId = parentId,
                CreatedAt = DateTime.Now,
                CreatedBy = 1,
                UpdatedBy = 1,
            };
            try
            {
                using var db = new AppDbContext(_options);
                db.CategoryEntity.Add(dataInsert);
                db.SaveChanges();
                MessageBox.Show("Thêm mới thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}