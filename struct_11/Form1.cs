using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace struct_11
{
    public partial class Form1 : Form
    {
        struct structPlayer
        {
            public int cnt;

            public int sun;
            public int moon;
            public int star;

            public int sum;
            public int Cardsum(int sun, int moon, int star)
            {
                return sun + moon + star;
            }
            public string text()
            {
                return string.Format("{0}회 해:{1}, 달:{2}, 별:{3}, 합계는 {4}입니다.", cnt, sun, moon, star, sum);
            }
        }

        structPlayer _p1;
        structPlayer _p2;
        Random _rd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void sun_Click(object sender, EventArgs e)
        {

            int number = _rd.Next(1, 21);

            if (radioPlayer1.Checked)
            {
                _p1.sun = number;
            }
            else
            {
                _p2.sum = number;
            }
            Result();
            change();
        }

        private void moon_Click(object sender, EventArgs e)
        {
            int number = _rd.Next(1, 21);

            if (radioPlayer1.Checked)
            {
                _p1.moon = number;
            }
            else
            {
                _p2.moon = number;
            }
            Result();
            change();
        }

        private void star_Click(object sender, EventArgs e)
        {
            int number = _rd.Next(1, 21);

            if (radioPlayer1.Checked)
            {
                _p1.star = number;
            }
            else
            {
                _p2.star = number;
            }
            Result();
            change();
        }

        private void none_Click(object sender, EventArgs e)
        {
            change();
        }

        private void change()
        {
            if (radioPlayer1.Checked)
            {
                radioPlayer2.Checked = true;
            }
            else
            {
                radioPlayer1.Checked = true;
            }
        }
        private void Result()
        {
            string str = string.Empty;
            int cardSum = 0;
            if (radioPlayer1.Checked)
            {
                _p1.cnt++;
                cardSum=_p1.Cardsum(_p1.sun, _p1.moon, _p1.star);
                str = _p1.text();
                result1.Items.Add(str);
            }
            else
            {
                _p2.cnt++;
                cardSum = _p2.Cardsum(_p2.sun, _p2.moon, _p2.star);
                str = _p2.text();
                result2.Items.Add(str);
            }

        }
    }
}
