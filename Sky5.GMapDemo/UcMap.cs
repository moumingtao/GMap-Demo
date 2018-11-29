using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sky5.GMapDemo
{
    public class UcMap : GMapControl
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
    }
}
