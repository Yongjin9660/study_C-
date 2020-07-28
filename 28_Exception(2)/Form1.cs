using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28_Exception_2_
{
    public partial class lboxColor : Form
    {
        Dictionary<string, Color> dColor = new Dictionary<string, Color>();
        Color oSelectColor = new Color();


        public lboxColor()
        {
            InitializeComponent();
        }

        private void pColor_Click(object sender, EventArgs e)
        {
            DialogResult dRet = colorDialog1.ShowDialog();

            if (dRet == DialogResult.OK)
            {
                pColor.BackColor = colorDialog1.Color;
            }
            lblColorInfo.Text = pColor.BackColor.ToString();

        }

        private void tbarAlpha_Scroll(object sender, EventArgs e)
        {
            pColor.BackColor = Color.FromArgb(tbarAlpha.Value, pColor.BackColor);
            lblColorInfo.Text = pColor.BackColor.ToString();
        }

        private void btnColorSave_Click(object sender, EventArgs e)
        {
            Color oColor = pColor.BackColor;
            dColor.Add(oColor.ToString(), oColor);
        }

        private void LBoxRefresh()
        {
            
        }

    }
}
