using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        private PropertyGrid PropGrid;

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

        internal void Init(UcMap ucMap, PropertyGrid pg)
        {
            this.Map = ucMap;
            this.PropGrid = pg;
        }

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);
            var method = (MethodInfo)this.SelectedItem;
            if(method != null) method.Invoke(this, null);
        }
        void 设置GMapCache为缓存目录()
        {
            Map.CacheLocation = Environment.CurrentDirectory + "\\GMapCache\\"; //缓存位置
        }
        public void 使用GoogleChinaMap提供地图()
        {
            Map.MapProvider = GMapProviders.GoogleChinaMap;
            Map.Position = new PointLatLng(30.6185946, 104.0188572);
            Map.MinZoom = 10;
            Map.MaxZoom = 20;
            Map.Zoom = 15;
            Map.ShowCenter = false; //不显示中心十字点
            Map.DragButton = System.Windows.Forms.MouseButtons.Left; //左键拖拽地图
        }

        public void 去掉地图版权水印()
        {
            if (Map.MapProvider == null) return;
            Map.MapProvider.Copyright = null;
            Map.Refresh();// 得刷新一下地图才生效
        }
        #region GMapMarker
        void 在地图中心位置添加GMarkerGoogle() => AddMarker(new GMarkerGoogle(Map.Position, GMarkerGoogleType.green_pushpin));
        void 在地图中心位置添加GMarkerCross() => AddMarker(new GMarkerCross(Map.Position));
        void 在地图中心位置添加GMapMarkerRect() => AddMarker(new GMapMarkerRect(Map.Position));

        void AddMarker(GMapMarker marker)
        {
            marker.ToolTipText = $"添加于{DateTime.Now}";
            Map.LayerObjects.Markers.Add(marker);
        }
        #endregion

        #region ToolTip
        void 设置提示GMapToolTip() => SetToolTip(m => new GMapToolTip(m));
        void 设置提示GMapBaloonToolTip() => SetToolTip(m => new GMapBaloonToolTip(m));
        void 设置提示GMapRoundedToolTip() => SetToolTip(m => new GMapRoundedToolTip(m));
        void 设置提示MyToolTip() => SetToolTip(m => new MyToolTip(m));

        void SetToolTip(Func<GMapMarker, GMapToolTip> tip)
        {
            var marker = PropGrid.SelectedObject as GMapMarker;
            if (marker == null)
            {
                MessageBox.Show("请在地图上点击要设置的Marker");
                return;
            }
            marker.ToolTip = tip(marker);
        }
        #endregion

        void 添加一个简单的多边形()
        {
            double r = 0.0001;
            GMapPolygon polygon = new GMapPolygon(new List<PointLatLng> {
                new PointLatLng(Map.Position.Lat + r, Map.Position.Lng - r),
                new PointLatLng(Map.Position.Lat + r, Map.Position.Lng + r),
                new PointLatLng(Map.Position.Lat - r, Map.Position.Lng + r),
                new PointLatLng(Map.Position.Lat - r, Map.Position.Lng - r),
            }, "mypolygon");
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.Red, 1);
            Map.LayerPolygons.Polygons.Add(polygon);
        }

        void 导入地图() => Map.ShowImportDialog();
        void 导出地图() => Map.ShowExportDialog();
    }
}
