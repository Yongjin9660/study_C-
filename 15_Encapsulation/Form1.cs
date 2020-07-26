using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_Encapsulation
{
    public partial class Form1 : Form
    {
        cData _data = new cData();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnumItem[] ei = (EnumItem[])Enum.GetValues(typeof(EnumItem));

            foreach (EnumItem item in ei)
            {
                cboxItem.Items.Add(item.ToString());
            }
            foreach (EnumRate item in (EnumRate[])Enum.GetValues(typeof(EnumRate)))
            {
                cboxRate.Items.Add(item.ToString());
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _data.StrItem = cboxItem.Text;
            _data.IRate = (int)Enum.Parse(typeof(EnumRate), cboxItem.Text);
            _data.ICount = (int)numCout.Value;

            if (!String.IsNullOrEmpty(_data.StrErrorName))
            {
                tboxErrorMg.Text = _data.StrErrorName;
                return;
            }
            double dPrice = _data.fItemPrice();
            lboxItem.Items.Add(dPrice.ToString());
        }
        
    }
}
