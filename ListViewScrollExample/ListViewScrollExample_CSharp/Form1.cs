using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListViewScrollExample_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Guna.UI.Lib.ScrollBar.ListViewScrollHelper vScrollHelper;
        private void Form1_Load(object sender, EventArgs e)
        {
            vScrollHelper = new Guna.UI.Lib.ScrollBar.ListViewScrollHelper(ListView1, GunaVScrollBar1, true);
            Random r = new Random();
            for (int i = 0; i <= 40; i++)
            {
                ListViewItem l = new ListViewItem();
                l.Text = i.ToString();
                l.SubItems.Add(r.Next(200000, 500000).ToString());
                l.SubItems.Add(r.Next(200000, 500000).ToString());
                l.SubItems.Add(r.Next(200000, 500000).ToString());
                l.SubItems.Add(r.Next(200000, 500000).ToString());
                l.SubItems.Add(r.Next(200000, 500000).ToString());
                ListView1.Items.Add(l);
            }
            vScrollHelper.UpdateScrollBar();
        }

        private void ListView1_Resize(object sender, EventArgs e)
        {
            if (vScrollHelper != null) vScrollHelper.UpdateScrollBar();
        }
    }
}
