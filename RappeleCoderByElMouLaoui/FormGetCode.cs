using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace RappeleCoderByElMouLaoui
{
    public partial class FormGetCode : Form
    {
        public FormGetCode()
        {
            InitializeComponent();
            cbx_langage.DataSource = new DataAccessLayer().ReadData("getlongage", null);
            cbx_langage.DisplayMember = "nom_longage";
            cbx_langage.ValueMember = "ID_longage";
            cbx_nameCode.DataSource = new Cls_Code().chargecomboboxNameCode(int.Parse(cbx_langage.SelectedValue.ToString()));
            cbx_nameCode.DisplayMember = "nom_code";
            DataTable d=new Cls_Code().chargecomboboxNameCode(int.Parse(cbx_langage.SelectedValue.ToString()));

        }
        public string[] getlist(DataTable d)
        {
            string[] lst = new string[d.Rows.Count];
            for (int i = 0; i < d.Rows.Count; i++)
            {
                lst[i] = d.Rows[i].ItemArray.ToString();
            }
            return lst;
        }

        private void cbx_langage_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbx_nameCode.DataSource = new Cls_Code().chargecomboboxNameCode(int.Parse(cbx_langage.SelectedValue.ToString()));
                cbx_nameCode.DisplayMember = "nom_code";
            }
            catch { }
        }

        private void cbx_nameCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txt_code.Clear();
                txt_code.Text = new Cls_Code().getCode(int.Parse(cbx_langage.SelectedValue.ToString()), cbx_nameCode.Text).Rows[0].ItemArray[0].ToString();
            }
            catch { }
        }

        private void cbx_nameCode_TextChanged(object sender, EventArgs e)
        {
            //   try
            //{
            //    txt_code.Clear();
            //    txt_code.Text = new Cls_Code().getCode(1, cbx_nameCode.Text).Rows[0].ItemArray[0].ToString();
            //}
            //catch { }
        }

        private void نسخToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txt_code.SelectedText);
            }
            catch { }
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

   }
}

