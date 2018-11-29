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
        // 图层
        readonly GMapOverlay top = new GMapOverlay();
        internal readonly GMapOverlay objects = new GMapOverlay("objects");
        internal readonly GMapOverlay routes = new GMapOverlay("routes");
        internal readonly GMapOverlay polygons = new GMapOverlay("polygons");

        // 标记
        GMapMarker currentMarker;

        // 多边形
        GMapPolygon polygon;

        // 其他

        public FrmMain()
        {
            InitializeComponent();
            if (!GMapControl.IsDesignerHosted) this.Load += DesignerHost;
            propertyGrid1.SelectedObject = gMap;
        }

        private void DesignerHost(object sender, EventArgs e)
        {
            gMap.MapProvider = GMapProviders.GoogleChinaMap;
            gMap.Position = new PointLatLng(30.6185946, 104.0188572);
            gMap.MinZoom = 10;
            gMap.MaxZoom = 15;
            gMap.Zoom = 15;
        }
    }
}
