using System;
using System.Collections.Generic;
using System.Text;

namespace Sky5.WinForms
{
    /// <summary>
    /// 提供ColorSchemeChange事件的数据
    /// </summary>
    public class ColorSchemeChangeEventArgs : EventArgs
    {
        /// <summary>获取用于面板的颜色模式</summary>
        public readonly ColorScheme ColorSchema;

        /// <summary>发生ColorSchemeChange事件时使用的参数</summary>
        /// <param name="eColorSchema">用于面板的颜色模式</param>
        public ColorSchemeChangeEventArgs(ColorScheme eColorSchema)
        {
            this.ColorSchema = eColorSchema;
        }
    }
}
