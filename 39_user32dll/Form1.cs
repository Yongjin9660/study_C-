using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _39_user32dll
{
    public partial class Form1 : Form
    {
        CGlobalKeyboardHook _kbdHook = new CGlobalKeyboardHook();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {
            _kbdHook.hook();
            _kbdHook.KeyDown += _kbdHook_KeyDown;
        }

        private void _kbdHook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                Thread.Sleep(400);

                lboxTestSave.Items.Add(Clipboard.GetData(System.Windows.Forms.DataFormats.UnicodeText).ToString());
            }
        }
        private void lboxTestSave_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lboxTestSave.SelectedIndex != -1)
            {
                Clipboard.SetData(System.Windows.Forms.DataFormats.UnicodeText, lboxTestSave.SelectedItem.ToString());
            }
        }
    }
}
