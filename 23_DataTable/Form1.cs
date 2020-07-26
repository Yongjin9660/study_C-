using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_DataTable
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }


        private void btnReg_Click(object sender, EventArgs e)
        {
            bool bCheckisTable = false;

            if (ds.Tables.Contains(cboxRegClass.Text))
            {
                bCheckisTable = true;
            }

            DataTable dt = null;

            if (!bCheckisTable)
            {
                dt = new DataTable(cboxRegClass.Text);

                DataColumn colName = new DataColumn("NAME", typeof(string));
                DataColumn colSex = new DataColumn("SEX", typeof(string));
                DataColumn colRef = new DataColumn("REF", typeof(string));

                dt.Columns.Add(colName);
                dt.Columns.Add(colSex);
                dt.Columns.Add(colRef);
            }
            else
            {
                dt = ds.Tables[cboxRegClass.Text];
            }


            // Row 자료를 등록

            DataRow row = dt.NewRow();


            row["NAME"] = tboxRegName.Text;

            if (rdoRegSexMale.Checked)
                row["SEX"] = "남자";
            else if (rdoRegSexFeMale.Checked)
                row["SEX"] = "여자";

            row["REF"] = tboxRegName.Text;



            if (bCheckisTable)
            {
                ds.Tables[cboxRegClass.Text].Rows.Add(row);
            }
            else
            {
                dt.Rows.Add(row);
                ds.Tables.Add(dt);
            }

            cboxViewClass_SelectedIndexChanged(this, null);
        }

        private void btnViewDataDel_Click(object sender, EventArgs e)
        {
            int iSelectRow = dgViewInfo.SelectedRows[0].Index;

            ds.Tables[cboxViewClass.Text].Rows.RemoveAt(iSelectRow);

            cboxViewClass_SelectedIndexChanged(this, null);
        }

        private void cboxViewClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgViewInfo.DataSource = ds.Tables[cboxViewClass.Text];


            // DatagridView Cell 정렬 및 Number를 적용
            foreach (DataGridViewRow oRow in dgViewInfo.Rows)
            {
                oRow.HeaderCell.Value = oRow.Index.ToString();
            }
            dgViewInfo.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
        }
    }
}
