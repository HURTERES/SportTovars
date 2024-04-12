using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СУБД__Спортивные_товары_
{
    public partial class FormAddEdit : Form
    {
        public FormAddEdit()
        {
            InitializeComponent();
        }

        public bool edit;

        private void FormAddEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sporttovBAUDataSet1.Provider' table. You can move, or remove it, as needed.
            this.providerTableAdapter.Fill(this.sporttovBAUDataSet1.Provider);
            // TODO: This line of code loads data into the 'sporttovBAUDataSet1.Manufacturer' table. You can move, or remove it, as needed.
            this.manufacturerTableAdapter.Fill(this.sporttovBAUDataSet1.Manufacturer);
            // TODO: This line of code loads data into the 'sporttovBAUDataSet1.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.sporttovBAUDataSet1.Category);
            // TODO: This line of code loads data into the 'sporttovBAUDataSet1.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.sporttovBAUDataSet1.Product);
            LblPhoto.Hide();
            if (edit)
            {
                LblText.Text = "Добавление";
                BsProduct.AddNew();
                CmbCatigori.SelectedIndex = 0;
                CmbManufacturer.SelectedIndex = 0;
                CmbProvider.SelectedIndex = 0;
            }
            else
            {
                LblText.Text = "Редактирование";
                TbxArticul.ReadOnly = true;
                try
                {
                    PbxPhoto.Image = Image.FromFile(Application.StartupPath + "\\Фото\\" + LblPhoto.Text);
                }
                catch
                {
                    PbxPhoto.Image = Image.FromFile(Application.StartupPath + "\\Фото\\" + "picture.png");
                }
            }
        }

        private void BtnLoadPhoto_Click(object sender, EventArgs e)
        {
            if (OfdPhoto.ShowDialog() == DialogResult.OK)
            {
                Image Im;
                try
                {
                    Im = Image.FromFile(OfdPhoto.FileName);
                    if ((Im.Height <= 200 && Im.Width <= 300) || (Im.Width <= 200 && Im.Height <= 300))
                        PbxPhoto.Image = Im;
                    else
                    {
                        MessageBox.Show("Размеры изображения слишком большие", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        OfdPhoto.FileName = "";
                    }
                }
                catch
                {
                    MessageBox.Show("Невозможно загрузить изображение из файла", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    OfdPhoto.FileName = "";
                }
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (TbxArticul.Text.Trim() == "")
            {
                MessageBox.Show("Артикул не может быть пустым", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            BsProductCheckArticul.Filter = $"ProductDescription = '{TbxArticul.Text}'";
            if (BsProductCheckArticul.Count > 0 && edit)
            {
                MessageBox.Show("Такой артикул уже используется в БД", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (TbxName.Text.Trim() == "")
            {
                MessageBox.Show("Название товара не может быть пустым", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (TbxCount.Text.Trim() == "")
            {
                MessageBox.Show("Кол-во на складе не может быть пустым", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (TbxCost.Text.Trim() == "")
            {
                MessageBox.Show("соимость товара не может быть пустым", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (TbxDescription.Text.Trim() == "")
            {
                MessageBox.Show("Описание товара не может быть пустым", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (OfdPhoto.FileName != "")
            {
                string NewFileName = Guid.NewGuid() + Path.GetExtension(OfdPhoto.FileName);
                LblPhoto.Text = NewFileName;
                File.Copy(OfdPhoto.FileName, Application.StartupPath + "\\Фото\\" + NewFileName);
            }

            BsProduct.EndEdit();
            this.productTableAdapter.Update(this.sporttovBAUDataSet1.Product);
            Close();
        }
    }
}
