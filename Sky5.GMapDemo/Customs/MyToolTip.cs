using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Sky5.GMapDemo
{
    public class MyToolTip : GMapToolTip
    {
        public MyToolTip(GMapMarker marker) : base(marker)
        {
        }

        protected MyToolTip(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public override void OnRender(Graphics g)
        {
            base.OnRender(g);
        }
    }
}
