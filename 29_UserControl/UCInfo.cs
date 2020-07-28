using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29_UserControl
{
    public partial class UCInfo : UserControl
    {
        public delegate int delEvent(object Sender, string strText);    // delegate 선언
        public event delEvent eventdelSender;      // delegate event 선언


        [Category("UserProperty"),Description("image")]
        public Image UserFace
        {
            get
            {
                return this.pboxFace.BackgroundImage;
            }
            set
            {
                this.pboxFace.BackgroundImage = value;
            }
        }

        [Category("UserProperty"), Description("No")]
        public String UserNo
        {
            get
            {
                return this.lblNo.Text;
            }
            set
            {
                this.lblNo.Text = value;
            }
        }

        [Category("UserProperty"), Description("현상범의 이름")]
        public String UserName
        {
            get
            {
                return this.lblName.Text;
            }
            set
            {
                this.lblName.Text = value;
            }
        }

        [Category("UserProperty"), Description("현상범의 금액")]
        public String UserGold
        {
            get
            {
                return this.lblGold.Text;
            }
            set
            {
                this.lblGold.Text = value;
            }
        }


        public UCInfo()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button oBtn = sender as Button;

            switch (oBtn.Name)
            {
                case "btnReg":
                    this.BackColor = Color.Red;
                    eventdelSender(this, string.Format("{0}은 금액 {1}으로 수배중입니다", lblName.Text, lblGold.Text));
                    break;
                case "btnIdle":
                    this.BackColor = Color.Yellow;
                    eventdelSender(this, string.Format("{0}은 수배중지 상태입니다", lblName.Text));
                    break;
                case "btnCatch":
                    this.BackColor = Color.Green;
                    eventdelSender(this, string.Format("{0}은 잡혔습니다", lblName.Text));
                    break;
                default:
                    break;
            }
        }


    }
}
