using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SRPGMaker
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void barSubItem_About_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new AboutDialog().Show();
        }
    }
}
