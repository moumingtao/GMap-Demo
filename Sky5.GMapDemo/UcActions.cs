using GMap.NET;
using GMap.NET.MapProviders;
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
        internal UcMap Map;
        public UcActions()
        {
            var type = this.GetType();
            List<MethodInfo> testMethods = new List<MethodInfo>();
            DisplayMember = nameof(MethodInfo.Name);
            foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                if (method.GetParameters().Length == 0)
                {
                    testMethods.Add(method);
                }
            }
            DataSource = testMethods;
        }

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);
            var method = (MethodInfo)this.SelectedItem;
            method.Invoke(this, null);
        }

        public void 使用GoogleChinaMap提供地图()
        {
            Map.MapProvider = GMapProviders.GoogleChinaMap;
            Map.Position = new PointLatLng(30.6185946, 104.0188572);
            Map.MinZoom = 10;
            Map.MaxZoom = 15;
            Map.Zoom = 15;
        }

    }
}
