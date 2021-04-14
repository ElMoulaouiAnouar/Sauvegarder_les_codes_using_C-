using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RappeleCoderByElMouLaoui
{
    public partial class FormSetCode : Form
    {
        public FormSetCode()
        {
            InitializeComponent();
            cbx_langage.DataSource = new DataAccessLayer().ReadData("getlongage", null);
            cbx_langage.DisplayMember = "nom_longage";
            cbx_langage.ValueMember = "ID_longage";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Cls_Code().SetCode(int.Parse(cbx_langage.SelectedValue.ToString()), txt_nameCode.Text, txt_code.Text);
            txt_code.Text = txt_nameCode.Text = "";
        }
    }
}
