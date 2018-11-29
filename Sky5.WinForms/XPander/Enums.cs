using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sky5.WinForms
{
    public enum CaptionStyle { Normal, Flat }
    public enum ColorScheme
    {
        /// <summary>Draws the panels caption with <see cref="ProfessionalColors">ProfessionalColors</see></summary>
		Professional,
        /// <summary>Draws the panels caption with custom colors.</summary>
		Custom
    }
    /// <summary>
    /// Specifies constants that define the hoverstate at the captionbar or a part of it on a Panel or XPanderPanel.
    /// </summary>
    public enum HoverState
    {
        /// <summary>The hoverstate in its normal state (none of the other states apply).</summary>
        None,
        /// <summary>The hoverstate over which a mouse pointer is resting.</summary>
        Hover
    }
}
