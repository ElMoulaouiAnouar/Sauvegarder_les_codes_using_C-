using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RappeleCoderByElMouLaoui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Afficcher(new FormSetCode());
        }

        
        int px, py; bool ver;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            px = e.X; py = e.Y; ver = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ver)
                SetDesktopLocation(MousePosition.X - px, MousePosition.Y - py);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            ver = false;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void Afficcher(Form f)
        {
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.WindowState = FormWindowState.Maximized;
            f.FormBorderStyle = FormBorderStyle.None;
            if (panelform.Controls.Count > 0)
                panelform.Controls.RemoveAt(0);
            panelform.Controls.Add(f);
            f.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Afficcher(new FormGetCode());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Afficcher(new FormGestionCoder());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Afficcher(new FormGetCode());
        }
    }
}
