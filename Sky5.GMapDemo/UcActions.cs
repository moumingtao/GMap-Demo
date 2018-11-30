using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sky5.GMapDemo
{
    class UcActions: ListBox
    {
        UcMap Map;

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (DesignMode || this.DataSource != null) return;
            List<MethodInfo> testMethods = new List<MethodInfo>();
            DisplayMember = nameof(MethodInfo.Name);
            foreach (var method in this.GetType().GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                if (method.GetParameters().Length == 0)
                {
                    testMethods.Add(method);
                }
            }
            DataSource = testMethods;
        }

        internal void Init(UcMap ucMap)
        {
            this.Map = ucMap;
        }

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);
            var method = (MethodInfo)this.SelectedItem;
            if(method != null) method.Invoke(this, null);
        }
        public void 使用GoogleChinaMap提供地图()
        {
            Map.MapProvider = GMapProviders.GoogleChinaMap;
            Map.Position = new PointLatLng(30.6185946, 104.0188572);
            Map.MinZoom = 10;
            Map.MaxZoom = 15;
            Map.Zoom = 15;
        }

        public void 去掉地图版权水印()
        {
            if (Map.MapProvider == null) return;
            Map.MapProvider.Copyright = null;
            Map.Refresh();// 得刷新一下地图才生效
        }

        void 在地图中心位置添加GMarkerGoogle()
        {
            GMarkerGoogle m = new GMarkerGoogle(Map.Position, GMarkerGoogleType.green_pushpin);
            m.ToolTipText = $"添加于{DateTime.Now}";
            Map.LayerObjects.Markers.Add(m);
        }

        void 添加自定义的GMapMarkerRect()
        {
            GMapMarkerRect m = new GMapMarkerRect(Map.Position);
            m.ToolTipText = $"添加于{DateTime.Now}";
            Map.LayerObjects.Markers.Add(m);
        }
    }
}
