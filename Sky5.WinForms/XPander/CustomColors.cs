using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sky5.WinForms
{
    /// <summary>
    /// 面板或xpanderpanel控件上自定义颜色的基类
    /// </summary>
    /// <remarks>
    /// If you use the <see cref="ColorScheme.Custom"/> ColorScheme, this is the base class for the custom colors.
    /// </remarks>
    [TypeConverter(typeof(ExpandableObjectConverter))]
    [Description("The colors used in a panel")]
    public class CustomColors
    {
        #region Events
        /// <summary>
        /// 在CustomColors属性的值更改时发生
        /// </summary>
        [Description("Occurs when the value of the CustomColors property changes.")]
        public event EventHandler<EventArgs> CustomColorsChanged;
        #endregion
        
        #region FieldsPrivate
        private Color m_borderColor = ProfessionalColors.GripDark;
        private Color m_captionCloseIcon = SystemColors.ControlText;
        private Color m_captionExpandIcon = SystemColors.ControlText;
        private Color m_captionGradientBegin = ProfessionalColors.ToolStripGradientBegin;
        private Color m_captionGradientEnd = ProfessionalColors.ToolStripGradientEnd;
        private Color m_captionGradientMiddle = ProfessionalColors.ToolStripGradientMiddle;
        private Color m_captionText = SystemColors.ControlText;
        private Color m_innerBorderColor = ProfessionalColors.GripLight;

        #endregion

        #region 获取或设置颜色属性，触发OnCustomColorsChanged事件
        /// <summary>
        /// 获取或设置Panel或XPanderPanel的边框颜色
        /// </summary>
        [Description("获取或设置Panel或XPanderPanel的边框颜色")]
        public virtual Color BorderColor
        {
            get => m_borderColor;
            set
            {
                if (value == m_borderColor) return;
                m_borderColor = value;
                OnCustomColorsChanged(this, EventArgs.Empty);
            }
        }
        /// <summary>
        /// 获取或设置Panel或XPanderPanel中关闭图标的前景色
        /// </summary>
        [Description("获取或设置Panel或XPanderPanel中关闭图标的前景色")]
        public virtual Color CaptionCloseIcon
        {
            get => m_captionCloseIcon;
            set
            {
                if (value == m_captionCloseIcon) return;
                m_captionCloseIcon = value;
                OnCustomColorsChanged(this, EventArgs.Empty);
            }
        }
        /// <summary>
        /// 获取或设置Panel或XPanderPanel中展开图标的前景色
        /// </summary>
        [Description("获取或设置Panel或XPanderPanel中展开图标的前景色")]
        public virtual Color CaptionExpandIcon
        {
            get => m_captionExpandIcon;
            set
            {
                if (value == m_captionExpandIcon) return;
                m_captionExpandIcon = value;
                OnCustomColorsChanged(this, EventArgs.Empty);
            }
        }
        /// <summary>
        /// 获取或设置Panel或XPanderPanel上标题的渐变的起始颜色
        /// </summary>
        [Description("获取或设置Panel或XPanderPanel上标题的渐变的起始颜色")]
        public virtual Color CaptionGradientBegin
        {
            get => m_captionGradientBegin;
            set
            {
                if (value == m_captionGradientBegin) return;
                m_captionGradientBegin = value;
                OnCustomColorsChanged(this, EventArgs.Empty);
            }
        }
        /// <summary>
        /// 获取或设置Panel或XPanderPanel上标题的渐变结束颜色
        /// </summary>
        [Description("获取或设置Panel或XPanderPanel上标题的渐变结束颜色")]
        public virtual Color CaptionGradientEnd
        {
            get => m_captionGradientEnd;
            set
            {
                if (value == m_captionGradientEnd) return;
                m_captionGradientEnd = value;
                OnCustomColorsChanged(this, EventArgs.Empty);
            }
        }
        /// <summary>
        /// 获取或设置Panel或XPanderPanel上标题的渐变的中间颜色
        /// </summary>
        [Description("The middle color of the gradient at the caption on a Panel or XPanderPanel.")]
        public virtual Color CaptionGradientMiddle
        {
            get => m_captionGradientMiddle;
            set
            {
                if (value == m_captionGradientMiddle) return;
                m_captionGradientMiddle = value;
                OnCustomColorsChanged(this, EventArgs.Empty);
            }
        }
        /// <summary>
        /// 获取或设置Panel或XPanderPanel上标题的文本颜色
        /// </summary>
        [Description("获取或设置Panel或XPanderPanel上标题的文本颜色")]
        public virtual Color CaptionText
        {
            get => m_captionText;
            set
            {
                if (value == m_captionText) return;
                m_captionText = value;
                OnCustomColorsChanged(this, EventArgs.Empty);
            }
        }
        /// <summary>
        /// 获取或设置Panel的内边框颜色
        /// </summary>
        [Description("获取或设置Panel的内边框颜色")]
        public virtual Color InnerBorderColor
        {
            get => m_innerBorderColor;
            set
            {
                if (value == m_innerBorderColor) return;
                m_innerBorderColor = value;
                OnCustomColorsChanged(this, EventArgs.Empty);
            }
        }
        #endregion

        #region MethodsProtected
        /// <summary>
        /// 引发CustomColors更改的事件
        /// </summary>
        /// <param name="sender">事件的来源</param>
        /// <param name="e">包含事件数据的EventArgs</param>
        protected virtual void OnCustomColorsChanged(object sender, EventArgs e) => CustomColorsChanged?.Invoke(sender, e);
        #endregion
    }
}
