using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ArrayTest();
        }
        private void ArrayTest()
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };
            
        }
        private void ArrayClassTest()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };

            dgDay["colDay1", 0].Value = arr[0];
            dgDay["colDay2", 0].Value = arr[1];
            dgDay["colDay3", 0].Value = arr[2];
            dgDay["colDay4", 0].Value = arr[3];
            dgDay["colDay5", 0].Value = arr[4];
            dgDay["colDay6", 0].Value = arr[5];
            dgDay["colDay7", 0].Value = arr[6];
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgDay.Rows.Clear();
            int[,] arr = { { 1, 2, 3, 4, 5, 6, 7 }, { 10, 20, 30, 40, 50, 60, 70 } };
            dgDay.Rows.Add();

            dgDay["colDay1", 0].Value = arr[0, 0];
            dgDay["colDay2", 0].Value = arr[0,1];
            dgDay["colDay3", 0].Value = arr[0,2];
            dgDay["colDay4", 0].Value = arr[0,3];
            dgDay["colDay5", 0].Value = arr[0,4];
            dgDay["colDay6", 0].Value = arr[0,5];
            dgDay["colDay7", 0].Value = arr[0,6];

            dgDay["colDay1", 1].Value = arr[1,0];
            dgDay["colDay2", 1].Value = arr[1,1];
            dgDay["colDay3", 1].Value = arr[1,2];
            dgDay["colDay4", 1].Value = arr[1,3];
            dgDay["colDay5", 1].Value = arr[1,4];
            dgDay["colDay6", 1].Value = arr[1,5];
            dgDay["colDay7", 1].Value = arr[1,6];
        }
    }
}
