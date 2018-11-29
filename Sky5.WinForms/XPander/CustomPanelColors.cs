﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sky5.WinForms
{
    /// <summary>
    /// Panel控件的自定义颜色类. 
    /// </summary>
    public class CustomPanelColors : CustomColors
    {
        #region FieldsPrivate
        private Color m_captionSelectedGradientBegin = ProfessionalColors.ButtonSelectedGradientBegin;
        private Color m_captionSelectedGradientEnd = ProfessionalColors.ButtonSelectedGradientEnd;
        private Color m_collapsedCaptionText = SystemColors.ControlText;
        private Color m_contentGradientBegin = ProfessionalColors.ToolStripContentPanelGradientBegin;
        private Color m_contentGradientEnd = ProfessionalColors.ToolStripContentPanelGradientEnd;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the starting color of the gradient used when the hover icon in the captionbar on the Panel is selected.
        /// </summary>
        [Description("The starting color of the hover icon in the captionbar on the Panel.")]
        public virtual Color CaptionSelectedGradientBegin
        {
            get { return this.m_captionSelectedGradientBegin; }
            set
            {
                if (value.Equals(this.m_captionSelectedGradientBegin) == false)
                {
                    this.m_captionSelectedGradientBegin = value;
                    OnCustomColorsChanged(this, EventArgs.Empty);
                }
            }
        }
        /// <summary>
        /// Gets or sets the end color of the gradient used when the hover icon in the captionbar on the Panel is selected.
        /// </summary>
        [Description("The end color of the hover icon in the captionbar on the Panel.")]
        public virtual Color CaptionSelectedGradientEnd
        {
            get { return this.m_captionSelectedGradientEnd; }
            set
            {
                if (value.Equals(this.m_captionSelectedGradientEnd) == false)
                {
                    this.m_captionSelectedGradientEnd = value;
                    OnCustomColorsChanged(this, EventArgs.Empty);
                }
            }
        }
        /// <summary>
        /// Gets or sets the text color of a Panel when it's collapsed.
        /// </summary>
        [Description("The text color of a Panel when it's collapsed.")]
        public virtual Color CollapsedCaptionText
        {
            get { return this.m_collapsedCaptionText; }
            set
            {
                if (value.Equals(this.m_collapsedCaptionText) == false)
                {
                    this.m_collapsedCaptionText = value;
                    OnCustomColorsChanged(this, EventArgs.Empty);
                }
            }
        }
        /// <summary>
        /// Gets or sets the starting color of the gradient used in the Panel.
        /// </summary>
        [Description("The starting color of the gradient used in the Panel.")]
        public virtual Color ContentGradientBegin
        {
            get { return this.m_contentGradientBegin; }
            set
            {
                if (value.Equals(this.m_contentGradientBegin) == false)
                {
                    this.m_contentGradientBegin = value;
                    OnCustomColorsChanged(this, EventArgs.Empty);
                }
            }
        }
        /// <summary>
        /// Gets or sets the end color of the gradient used in the Panel.
        /// </summary>
        [Description("The end color of the gradient used in the Panel.")]
        public virtual Color ContentGradientEnd
        {
            get { return this.m_contentGradientEnd; }
            set
            {
                if (value.Equals(this.m_contentGradientEnd) == false)
                {
                    this.m_contentGradientEnd = value;
                    OnCustomColorsChanged(this, EventArgs.Empty);
                }
            }
        }
        #endregion
    }
}
