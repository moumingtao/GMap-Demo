using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sky5.GMapDemo
{
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ucProperty.Init(ucMap);
            ucProperty.TextChanged += UcProperty_TextChanged;
            ucOthers1.Init(ucMap, ucProperty);
        }

        private void UcProperty_TextChanged(object sender, EventArgs e)
        {
            pnlPropertyView.Text = $"属性[{((Control)sender).Text}]";
        }
    }
}
