using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33_Layout
{
    public partial class UcColorMenu : UserControl
    {
        // 1) Delegate Event 선언
        public delegate void delColorSender(object sender, Color oColor);
        public event delColorSender eColorSender;

        // 2) 기본 EventHandler
        public event EventHandler oColorEventHandler;

        // 3) 제네릭 형태의 delegate 사용
        public event Action<object, Color> eColorAction;


        public UcColorMenu()
        {
            InitializeComponent();
        }




        private void pColor_Click(object sender, EventArgs e)
        {
            DialogResult dRet = colorDialog1.ShowDialog(); // ColorDialog를 불러서 선택한 뒤 결과 값까지 받아옴

            if (dRet == DialogResult.OK)
            {
                pColor.BackColor = colorDialog1.Color;
            }

        }

        private void btn_Click(object sender, EventArgs e)
        {
            //eColorSender(sender, pColor.BackColor);   // 1)
            //oColorEventHandler(sender, e);            // 2)
            eColorAction(sender, pColor.BackColor);     // 3)
        }


    }
}
