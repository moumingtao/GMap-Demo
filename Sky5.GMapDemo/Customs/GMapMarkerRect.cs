using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Sky5.GMapDemo
{
    [Serializable]
    public class GMapMarkerRect : GMapMarker
    {
        [NonSerialized]
        public Pen Pen;

        [NonSerialized]
        public GMarkerGoogle InnerMarker;

        public GMapMarkerRect(PointLatLng p) : base(p)
        {
            Pen = new Pen(Brushes.Blue, 2);
            Size = new Size(50, 50);
            Offset = new Point(-Size.Width / 2, -Size.Height / 2);
        }

        public override void OnRender(Graphics g)
        {
            g.DrawRectangle(Pen, LocalPosition.X, LocalPosition.Y, Size.Width, Size.Height);
        }

        public override void Dispose()
        {
            if (Pen != null)
                Pen.Dispose();
            if (InnerMarker != null)
                InnerMarker.Dispose();
            base.Dispose();
        }
    }
}
