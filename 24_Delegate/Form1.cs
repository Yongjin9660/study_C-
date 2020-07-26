using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_Delegate
{
    public partial class Form1 : Form
    {
        public delegate int delFuncDow_Edge(int i);
        public delegate int delFunTopping(string strOrder, int Ea);

        public delegate T delFunc<T>(T i);

        int _iTotalPrice = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            delFuncDow_Edge delDow = new delFuncDow_Edge(fDow);
            delFuncDow_Edge delEdge = new delFuncDow_Edge(fEdge);

            delFunTopping delTopping = null;

            Dictionary<string, int> dPizzaOrder = new Dictionary<string, int>();       //pizza 주문을 담을 그릇

            int iDowOrder = 0;
            int iEdgeOrder = 0;

            //Dow 호출
            if (rdoDow1.Checked)
            {
                //fDow(1);
                //delDow(1);
                iDowOrder = 1;
                dPizzaOrder.Add("오리지널", 1);
            }
            else if (rdoDow2.Checked)
            {
                //fDow(2);
                //delDow(2);
                iDowOrder = 2;
                dPizzaOrder.Add("씬", 1);
            }

            //Edge 호출
            if (rdoEdge1.Checked)
            {
                iEdgeOrder = 1;
                dPizzaOrder.Add("리치골드", 1);
            }
            else if (rdoEdge2.Checked)
            {
                iEdgeOrder = 2;
                dPizzaOrder.Add("치즈크러스터", 1);
            }

            //delDow(iDowOrder);
            //delEdge(iEdgeOrder);

            //callback
            fCallBackDelegate(iDowOrder, delDow);
            fCallBackDelegate(iEdgeOrder, delEdge);

            if (cboxTopping1.Checked)
            { 
                delTopping += fTopping1;
                dPizzaOrder.Add("소세지", (int)numEa.Value);
            }
            if (cboxTopping2.Checked)
            {
                delTopping += fTopping2;
                dPizzaOrder.Add("감자", (int)numEa.Value);
            }
            if (cboxTopping3.Checked)
            {
                delTopping += fTopping3;
                dPizzaOrder.Add("치즈", (int)numEa.Value);
            }
            delTopping("토핑", (int)numEa.Value);

            flbowOrderRed("--------------------------");
            flbowOrderRed(string.Format("전체 주문 가격은 {0}원 입니다.", _iTotalPrice));

            formLoading(dPizzaOrder);
        }


        #region Function
        /// <summary>
        /// 0 : 선택안함, 1 : 오리지널, 2 : 씬
        /// </summary>
        /// <param name="iOrder"></param>
        /// <returns></returns>
        private int fDow(int iOrder)
        {
            string strOrder = string.Empty;
            int iPrice = 0;
            if (iOrder == 1)
            {
                iPrice = 10000;
                strOrder = string.Format("도우는 오리지널을 선택하셨습니다. ({0}원)", iPrice.ToString());
            }else if (iOrder == 2)
            {
                iPrice = 11000;
                strOrder = string.Format("도우는 오리지널을 선택하셨습니다. ({0}원)", iPrice.ToString());         
            }
            else
            {
                strOrder = "도우를 선택하지 않았습니다.";
            }
            flbowOrderRed(strOrder);
            return _iTotalPrice += iPrice;
        }

        /// <summary>
        /// 0 : 선택안함, 1 : 리치골드, 2 : 치즈크러스트
        /// </summary>
        /// <param name="iOrder"></param>
        /// <returns></returns>
        private int fEdge(int iOrder)
        {
            string strOrder = string.Empty;
            int iPrice = 0;
            if (iOrder == 1)
            {
                iPrice = 1000;
                strOrder = string.Format("엣지는 리치골드을 선택하셨습니다. ({0}원)", iPrice.ToString());
            }
            else if (iOrder == 2)
            {
                iPrice = 2000;
                strOrder = string.Format("엣지는 치즈크러스트을 선택하셨습니다. ({0}원)", iPrice.ToString());
            }
            else
            {
                strOrder = "엣지를 선택하지 않았습니다.";
            }
            flbowOrderRed(strOrder);
            return _iTotalPrice += iPrice;
        }

        public int fCallBackDelegate(int i,delFuncDow_Edge dFunction)
        {

            return dFunction(i);
        }
        private int fTopping1(string Order,int iEa)
        {
            string strOrder = string.Empty;
            int iPrice = iEa * 500;

            strOrder = string.Format("소시지 {0} {1}개를 선택하였습니다 : ({2})원 (1ea 500원)", Order, iEa, iPrice);
            flbowOrderRed(strOrder);

            return _iTotalPrice += iPrice;
        }
        private int fTopping2(string Order, int iEa)
        {
            string strOrder = string.Empty;
            int iPrice = iEa * 200;

            strOrder = string.Format("감자 {0} {1}개를 선택하였습니다 : ({2})원 (1ea 500원)", Order, iEa, iPrice);
            flbowOrderRed(strOrder);

            return _iTotalPrice += iPrice;
        }
        private int fTopping3(string Order, int iEa)
        {
            string strOrder = string.Empty;
            int iPrice = iEa * 300;

            strOrder = string.Format("치즈 {0} {1}개를 선택하였습니다 : ({2})원 (1ea 500원)", Order, iEa, iPrice);
            flbowOrderRed(strOrder);

            return _iTotalPrice += iPrice;
        }

        private void flbowOrderRed(string strOrder)
        {
            lboxOrder.Items.Add(strOrder);
        }

        #endregion

        #region event 예제
        formPizze fPizza;

        private void formLoading(Dictionary<string,int> dPizzaOrder)
        {
            if (fPizza != null)
            {
                fPizza.Dispose();
                fPizza = null;
            }
            fPizza = new formPizze();
            fPizza.eventdelPizzaComplete += FPizza_eventdelPizzaComplete;
            fPizza.Show();
            fPizza.fPizzrCheck(dPizzaOrder);
        }

        private int FPizza_eventdelPizzaComplete(string strResult, int iTime)
        {
            flbowOrderRed("--------------------------");
            flbowOrderRed(string.Format("{0} / 걸린시간 : {1}", strResult, iTime));

            if (iTime > 5000)
            {
                return -1;
            }
            return 0;
        }
        #endregion
    }
}
