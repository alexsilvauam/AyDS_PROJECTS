using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ayds_proyecto2
{
    public partial class Form : MetroFramework.Forms.MetroForm
    {
        public Form()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if(metroToggle1.Checked)
            {
                metroStyleManager1.Theme= MetroFramework.MetroThemeStyle.Dark;
            }
            else
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            }    

        }
    }
}
