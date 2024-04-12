using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace СУБД__Спортивные_товары_
{
    public partial class FormTovar : Form
    {
        public FormTovar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// вывод списка товаров
        /// </summary>
        void OutPutProduct()
        {
            SqlConnection Con = new SqlConnection(FormMain.TxtCon);
            Con.Open();
            this.productTableAdapter.Fill(this.sporttovBAUDataSet1.Product);
            string TxtFind = "";
            DgvProduct.Rows.Clear();
            if (CbxName.Checked && TbxFind.Text != "")
                TxtFind += $"and ProductName Like '{TbxFind.Text}%' ";
            if (CbxTitle.Checked && TbxFind.Text != "")
                TxtFind += $"and ProductDescription Like '{TbxFind.Text}%' ";
            if (CbxManuf.Checked && TbxFind.Text != "")
                TxtFind += $"and Name Like '{TbxFind.Text}%' ";
            if (CbxPrice.Checked && TbxFind.Text != "")
                TxtFind += $"and ProductCost = {TbxFind.Text} ";
            if (CbxCount.Checked && TbxFind.Text != "")
                TxtFind += $"and ProductQuantityInStock = {TbxFind.Text} ";
            if (CmbManuf.Text != "Все производители")
                TxtFind += $"and Name = '{CmbManuf.Text}'";
            if (RbtVozr.Checked)
                TxtFind += "\r\nOrder by ProductCost asc";
            else
                TxtFind += "\r\nOrder by ProductCost desc";
            string TxtQuery = @"SELECT        Product.ProductArticleNumber, Product.ProductName, Product.ProductDescription, Product.ProductCost, Product.ProductQuantityInStock, Product.ProductPhoto, Manufacturer.Name
FROM            Product INNER JOIN
                         Manufacturer ON Product.ProductManufacturer = Manufacturer.IdManufacturer
Where 1 > 0 " + TxtFind;
            try
            {
                SqlCommand Query = new SqlCommand(TxtQuery, Con);
                SqlDataReader Res = Query.ExecuteReader();
                while (Res.Read())
                {
                    string TxtProduct = Res["ProductName"] + "\r\n" + Res["ProductDescription"] + "\r\nПроизводитель: " + Res["Name"] + "\r\nЦена: " + Res["ProductCost"];
                    try
                    {
                        DgvProduct.Rows.Add(Res["ProductArticleNumber"], Image.FromFile(Application.StartupPath + "\\Фото\\" + Res["ProductPhoto"]), TxtProduct, "На складе: " + Res["ProductQuantityInStock"]);
                    }
                    catch
                    {
                        DgvProduct.Rows.Add(Res["ProductArticleNumber"], Image.FromFile(Application.StartupPath + "\\Фото\\" + "picture.png"), TxtProduct, "На складе: " + Res["ProductQuantityInStock"]);
                    }
                    if (Res["ProductQuantityInStock"].ToString() == "0")
                    {
                        DgvProduct.Rows[DgvProduct.RowCount - 1].DefaultCellStyle.BackColor = Color.Silver;
                    }
                }
            }
            catch { }
            Con.Close();
            if (DgvProduct.Rows.Count > 0)
                LblCount.Text = $"Найдено {DgvProduct.Rows.Count} из {BsProduct.Count}";
            else
                LblCount.Text = "Продукты не найдены";
        }
        private void FormTovar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sporttovBAUDataSet1.OrderProduct' table. You can move, or remove it, as needed.
            this.orderProductTableAdapter.Fill(this.sporttovBAUDataSet1.OrderProduct);
            // TODO: This line of code loads data into the 'sporttovBAUDataSet1.AllManuf' table. You can move, or remove it, as needed.
            this.allManufTableAdapter.Fill(this.sporttovBAUDataSet1.AllManuf);
            // TODO: This line of code loads data into the 'sporttovBAUDataSet1.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.sporttovBAUDataSet1.User);
            // TODO: This line of code loads data into the 'sporttovBAUDataSet1.Provider' table. You can move, or remove it, as needed.
            this.providerTableAdapter.Fill(this.sporttovBAUDataSet1.Provider);
            // TODO: This line of code loads data into the 'sporttovBAUDataSet1.Product' table. You can move, or remove it, as needed.
            LblRole.Hide();
            this.productTableAdapter.Fill(this.sporttovBAUDataSet1.Product);
            OutPutProduct();
            BtnAdd.Visible = LblRole.Text == "1";
            BtnDel.Visible = LblRole.Text == "1";
        }

        private void TbxFind_TextChanged(object sender, EventArgs e)
        {
            OutPutProduct();
        }

        private void CbxName_CheckedChanged(object sender, EventArgs e)
        {
            OutPutProduct();
        }

        private void CmbManuf_SelectedIndexChanged(object sender, EventArgs e)
        {
            OutPutProduct();
        }

        private void RbtUbiv_CheckedChanged(object sender, EventArgs e)
        {
            OutPutProduct();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            BsOrderProduct.Filter = $"ProductArticleNumber = '{DgvProduct.CurrentRow.Cells[0].Value}'";
            if (MessageBox.Show("Удалить выделенный товар?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            SqlConnection Con = new SqlConnection(FormMain.TxtCon);
            Con.Open();
            string TxtQuery = @"Delete From Product
where ProductArticleNumber = ";
            TxtQuery += $"'{DgvProduct.CurrentRow.Cells[0].Value}'";
            SqlCommand com = new SqlCommand(TxtQuery, Con);
            if (BsOrderProduct.Count == 0)
            {
                com.ExecuteNonQuery();
                MessageBox.Show("Товар удалён.", "Внимание!", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Данный продукт удалить нельзя, он участвуе в заказе.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con.Close();
            OutPutProduct();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FormAddEdit frm = new FormAddEdit();
            frm.edit = true;
            frm.ShowDialog();
            OutPutProduct();
        }

        private void DgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (LblRole.Text == "1")
            {
                FormAddEdit frm = new FormAddEdit();
                frm.edit = false;
                frm.BsProduct.Filter = $"ProductArticleNumber = '{DgvProduct.SelectedCells[0].Value}'";
                frm.ShowDialog();
                OutPutProduct();
            }
        }
    }
}
