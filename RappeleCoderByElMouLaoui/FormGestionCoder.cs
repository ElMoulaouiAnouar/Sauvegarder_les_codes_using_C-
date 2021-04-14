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
    public partial class FormGestionCoder : Form
    {
        public FormGestionCoder()
        {
            InitializeComponent();
            chargeLescombobox();
        }
        public void chargeLescombobox()
        {
            cbx_langage.DataSource = new DataAccessLayer().ReadData("getlongage", null);
            cbx_langage.DisplayMember = "nom_longage";
            cbx_langage.ValueMember = "ID_longage";
            comboBox1.DataSource = new DataAccessLayer().ReadData("getlongage", null);
            comboBox1.DisplayMember = "nom_longage";
            comboBox1.ValueMember = "ID_longage";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            new Cls_Code().AddLongage(txt_longage.Text);
            txt_longage.Clear();
            MessageBox.Show("operaation successfully","Add",MessageBoxButtons.OK,MessageBoxIcon.Information);
            chargeLescombobox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Cls_Code().Remove(cbx_langage.Text);
            MessageBox.Show("operaation successfully", "remove", MessageBoxButtons.OK, MessageBoxIcon.Information);
            chargeLescombobox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Cls_Code().Remove(int.Parse(comboBox1.SelectedValue.ToString()), txt_nameCode.Text);
            txt_nameCode.Clear();
            MessageBox.Show("operaation successfully", "remove", MessageBoxButtons.OK, MessageBoxIcon.Information);
            chargeLescombobox();
        }
    }
}
