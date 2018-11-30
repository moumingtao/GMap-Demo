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
        internal readonly GMapOverlay LayerTop = new GMapOverlay();
        internal readonly GMapOverlay LayerObjects = new GMapOverlay("objects");
        internal readonly GMapOverlay LayerRoutes = new GMapOverlay("routes");
        internal readonly GMapOverlay LayerPolygons = new GMapOverlay("polygons");

        // 标记
        internal GMapMarker currentMarker;

        // 多边形
        internal GMapPolygon polygon;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Overlays.Add(LayerTop);
            this.Overlays.Add(LayerObjects);
            this.Overlays.Add(LayerRoutes);
            this.Overlays.Add(LayerPolygons);
        }
    }
}
