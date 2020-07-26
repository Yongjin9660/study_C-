using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28_Exception
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                //FormatException
                int iCheck = 0;
                if(int.TryParse(textBox1.Text,out iCheck))
                {

                }
                else
                {
                    label1.Text = "Data form이 맞지않습니다.";
                }

                //ArgumentException
                string strTest = string.Empty;
                List<string> LStringCheck = new List<string>();

                LStringCheck.Add("Test1");

                foreach (string item in LStringCheck)
                {
                    strTest = item;
                }

                // NullReferenceException
                List<object> LObject = null;

                if (LObject != null)
                {
                    object oRet = LObject[0];
                }


            }
            catch (FormatException fe)
            {
                label1.Text = fe.ToString();
            }
            catch (ArgumentException ex)
            {
                label1.Text = ex.ToString();
            }
            catch (NullReferenceException exx)
            {
                label1.Text = exx.ToString();
            }

        }
    }
}
