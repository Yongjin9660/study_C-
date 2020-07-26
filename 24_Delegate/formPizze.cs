using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_Delegate
{
    public partial class formPizze : Form
    {
        private Dictionary<string, int> dPizzaOrder;

        public delegate int delPizzaComplete(string strResult, int iTime);
        public event delPizzaComplete eventdelPizzaComplete;    //delegate event 선언


        public formPizze()
        {
            InitializeComponent();
        }

        public formPizze(Dictionary<string, int> dPizzaOrder)
        {
            InitializeComponent();
        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public void fPizzrCheck(Dictionary<string, int> dPizzaOrder)
        {
            int iTotalTime = 0;
            foreach (KeyValuePair<string,int> order in dPizzaOrder)
            {
                int iTime = 0;
                string iType = string.Empty;
                int Time = 0;
                int iCount = order.Value;

                switch (order.Key)
                {
                    //도우
                    case "오리지널":
                        iTime = 3000;
                        iType = "도우";
                        break;
                    case "씬":
                        iTime = 3500;
                        iType = "도우";
                        break;
                    //엣지
                    case "리치골드":
                        iTime = 500;
                        iType = "엣지";
                        break;
                    case "치즈크러스터":
                        iTime = 400;
                        iType = "엣지";
                        break;
                    //토핑
                    case "소세지":
                        iTime = 32;
                        iType = "토핑";
                        break;
                    case "감자":
                        iTime = 17;
                        iType = "토핑";
                        break;
                    case "치즈":
                        iTime = 48;
                        iType = "토핑";
                        break;
                    default:
                        break;
                }
                Time = iTime * iCount;
                lboxMake.Items.Add(String.Format("{0}) {1} : {2} 초 {3} 초, {4}개", iType, order.Key, Time, iTime, iCount));
                iTotalTime += Time;
                this.Refresh();
                Thread.Sleep(1000);
            }
            int iRet = eventdelPizzaComplete("Pizza가 완성되었습니다.", iTotalTime);
            lboxMake.Items.Add("---------------");
            if (iRet == 0)
                lboxMake.Items.Add("주문완료~~~");
            else
                lboxMake.Items.Add("시간초과");
            
        }
    }
}
