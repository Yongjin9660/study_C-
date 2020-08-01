using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoriDori_Inheritance
{
    class Cycle : CBase
    {
        public Rectangle _rtCircle1;    // 바퀴
        public Rectangle _rtCircle2;    // 바퀴
        public Rectangle _rtSquare1;    // 몸통

        public Cycle(string sName)
        {
            strName = sName;
            _Pen = new Pen(Color.Black, 3);

            _rtCircle1 = new Rectangle(120, 150, 120, 120);
            _rtCircle1 = new Rectangle(120, 150, 120, 120);
            _rtSquare1 = new Rectangle(150, 30, 60, 120);
        }

        public Pen fPenInfo()
        {
            return _Pen;
        }
    }
}
