using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33_Layout
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucColorMenu1.eColorAction += UcColorMenu1_eColorAction;

            ucPanelCenter1.eLabelDoubleClickHandler += UcPanel_eLabelDoubleClickHandler;
            ucPanelCenter2.eLabelDoubleClickHandler += UcPanel_eLabelDoubleClickHandler;
            ucPanelTop.eLabelDoubleClickHandler += UcPanel_eLabelDoubleClickHandler;
            ucPanelRight.eLabelDoubleClickHandler += UcPanel_eLabelDoubleClickHandler;

        }

        private void UcPanel_eLabelDoubleClickHandler(object sender, EventArgs e)
        {
            ucPanel oPanel = sender as ucPanel;
            string strPanelName = string.Empty;
            string btnName = string.Empty;
            string strResult = string.Empty;

            switch (oPanel.Name)
            {
                case "ucPanelTop":
                    btnName = "btn1";
                    break;
                case "ucPanelRight":
                    btnName = "btn4";
                    break;
                case "ucPanelCenter1":
                    btnName = "btn2";
                    break;
                case "ucPanelCenter2":
                    btnName = "btn3";
                    break;
                default:
                    break;
            }
            strResult = fBtnSearch(btnName, oPanel.BackColor, oPanel.Name);
            lboxLog.Items.Add(strResult);
        }

        private string fBtnSearch(string strButtonName,Color oColor,string strPanelName)
        {
            string strResult = string.Empty;

            foreach (var item in ucColorMenu1.Controls)
            {
                if(item is Button)
                {
                    Button obtn = item as Button;

                    if(obtn.Name == strButtonName)
                    {
                        obtn.BackColor = oColor;
                        strResult = string.Format("{0} Panel DoubleClick, {1}의 색상을 {2}로 변경", strPanelName, strButtonName, oColor.ToString());
                        return strResult;
                    }
                }
            }
            return null;
        }


        private void UcColorMenu1_eColorAction(object arg1, Color arg2)
        {
            Button obtn = arg1 as Button;
            string strPanelName = string.Empty;

            switch (obtn.Name)
            {
                case "btn1":
                    ucPanelTop.BackColor = arg2;
                    strPanelName = "Panel Top";
                    break;
                case "btn2":
                    ucPanelCenter1.BackColor = arg2;
                    strPanelName = "Panel Center1";
                    break;
                case "btn3":
                    ucPanelCenter2.BackColor = arg2;
                    strPanelName = "Panel Center2";
                    break;
                case "btn4":
                    ucPanelRight.BackColor = arg2;
                    strPanelName = "Panel Right";
                    break;
                default:
                    break; 
            }

            string strResult = string.Format("선택 : {0}, {1}의 색상을 {2}로 변경", obtn.Name, strPanelName, arg2.ToString());
            lboxLog.Items.Add(strResult);
        }
    }
}
