using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sky5.GMapDemo
{
    public class UcProperty : PropertyGrid
    {
        UcMap Map;
        public void Init(UcMap map)
        {
            this.Map = map;
            map.MouseClick += Map_MouseClick;
        }

        private void Map_MouseClick(object sender, MouseEventArgs e)
        {
            base.OnMouseClick(e);
            foreach (var layer in Map.Overlays)
            {
                foreach (var marker in layer.Markers)
                {
                    if (marker.IsMouseOver)
                    {
                        SelectedObject = marker;
                        return;
                    }
                }
                foreach (var polygon in layer.Polygons)
                {
                    if (polygon.IsMouseOver)
                    {
                        SelectedObject = polygon;
                        return;
                    }
                }
            }
            SelectedObject = Map;
        }
        protected override void OnSelectedObjectsChanged(EventArgs e)
        {
            base.OnSelectedObjectsChanged(e);
            Text = SelectedObject == null ? string.Empty : SelectedObject.ToString();
        }
    }
}
