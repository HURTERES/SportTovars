using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СУБД__Спортивные_товары_
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportTovarDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter1.Fill(this.sportTovarDataSet.User);
            // TODO: This line of code loads data into the 'sporttovBAUDataSet1.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.sporttovBAUDataSet1.User);

        }

        public static string TxtCon = $"Data Source=213.155.192.79,3002;Initial Catalog=SporttovBAU;Persist Security Info=True;User ID=u21baranov;Password=au5p";

        string Capcha;

        /// <summary>
        /// сгенерировать символы капчи
        /// </summary>
        void GetCapcha()
        {
            Capcha = Guid.NewGuid().ToString().Substring(0, 4).ToUpper();
            LblC1.Text = Capcha[0].ToString();
            LblC2.Text = Capcha[1].ToString();
            LblC3.Text = Capcha[2].ToString();
            LblC4.Text = Capcha[3].ToString();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            BsUser.Filter = $"UserLogin = '{TbxLog.Text}' and UserPassword = '{TbxPass.Text}'";
            if (BsUser.Count > 0 && (TbxLog.Text != "-" || TbxPass.Text != "-"))
            {
                if (PanelImputCapcha.Visible && TbxCapcha.Text.ToUpper() != Capcha)
                {
                    MessageBox.Show("Неверная капча", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    GetCapcha();
                    BtnLogin.Enabled = false;
                    timer1.Start();
                }
                else
                {
                    FormTovar frmT = new FormTovar();
                    frmT.BSUser.Filter = BsUser.Filter;
                    this.Hide();
                    frmT.ShowDialog();
                    this.Show();
                    TbxLog.Clear();
                    TbxPass.Clear();
                    TbxCapcha.Clear();  
                    TbxLog.Focus();
                }
            }
            else
            {
                MessageBox.Show("Пользователя с таким логином и паролем не существует.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (PanelImputCapcha.Visible == false)
                {
                    PanelImputCapcha.Visible = true;
                    GetCapcha();
                }
                else
                {
                    BtnLogin.Enabled= false;
                    timer1.Start();
                    PanelCapcha.Refresh();
                }
            }
        }

        private void PanelCapcha_Paint(object sender, PaintEventArgs e)
        {
            Random Rnd = new Random();
            int t = Rnd.Next(6,11);
            for (int i = 0; i < t; i++)
            {
                e.Graphics.DrawLine(new Pen(Color.Black, 3), Rnd.Next(100), Rnd.Next(100), Rnd.Next(PanelCapcha.Width), Rnd.Next(PanelCapcha.Height));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BtnLogin.Enabled= true;
        }

        private void BtnGuest_Click(object sender, EventArgs e)
        {
            FormTovar Frm = new FormTovar();
            Frm.BSUser.Filter = "UserLogin = '-' and UserPassword = '-'";
            this.Hide();
            Frm.ShowDialog();
            this.Show();
            TbxLog.Clear();
            TbxPass.Clear();
            TbxCapcha.Clear();
            TbxLog.Focus();
        }
    }
}
