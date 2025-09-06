using AppStoreMobile.Configurations;
using AppStoreMobile.DatabaseContext;
using AppStoreMobile.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppStoreMobile.Forms
{
    public partial class FormCreateProductAttribute : Form
    {
        private readonly DbContextOptions<AppDbContext> _options;

        public FormCreateProductAttribute(DbContextOptions<AppDbContext> options)
        {
            InitializeComponent();
            _options = options;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var attributeName = txtTenThuocTinh.Text;
                var attributeValue = txtGiaTri.Text;
                var data = new ProductAttributes
                {
                    AttributeName = attributeName,
                    AttributeValue = attributeValue,
                    CreatedAt = DateTime.Now,
                    CreatedBy = 1,
                    UpdatedBy = 1,
                };
                using var db = new AppDbContext(_options);
                db.ProductAttributeEntity.Add(data);
                db.SaveChanges();
                MessageBox.Show(ConfigMessageNotify.CREATE_NEW_RECORD, ConfigMessageTitleNotify.SUCCESS);
                ClearFormData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ConfigMessageTitleNotify.FAIL);
            }
        }

        private void ClearFormData()
        {
            txtGiaTri.Text = string.Empty;
            txtTenThuocTinh.Text = string.Empty;
        }
    }
}