using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoriDori_Inheritance
{
    public partial class Form1 : Form
    {
        COneCycle _cOC;
        Cycle _cC;

        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _cOC = new COneCycle("외발 자전거");
            _cC = new Cycle("자전거");
        }

        private void btnOneCycle_Click(object sender, EventArgs e)
        {
            OneCycleDraw();
            ClearPanel();
        }

        /// <summary>
        /// OneCycle 대한 위치 그림을 그려준다.
        /// </summary>
        private void OneCycleDraw()
        {
            lblName.Text = _cOC.strName;
            Graphics g = pMain.CreateGraphics();

            CBase cb = new CBase();
            Pen p = _cOC.fPenInfo();

            g.DrawRectangle(p, _cOC._rtSquare1);
            g.DrawEllipse(p, _cOC._rtCircle1);
        }
        private void CycleDraw()
        {
            lblName.Text = _cC.strName;
            Graphics g = pMain.CreateGraphics();

            CBase cb = new CBase();
            Pen p = _cC.fPenInfo();

            g.DrawRectangle(p, _cC._rtSquare1);
            g.DrawEllipse(p, _cC._rtCircle1);
            g.DrawEllipse(p, _cC._rtCircle2);
        }

        private void btnCycle_Click(object sender, EventArgs e)
        {
            CycleDraw();
            ClearPanel();
        }

        private void ClearPanel()
        {
            pMain.Invalidate();
        }

    }
}
