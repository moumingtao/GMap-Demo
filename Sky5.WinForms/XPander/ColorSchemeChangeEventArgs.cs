using System;
using System.Collections.Generic;
using System.Text;

namespace Sky5.WinForms
{
    /// <summary>
    /// �ṩColorSchemeChange�¼�������
    /// </summary>
    public class ColorSchemeChangeEventArgs : EventArgs
    {
        /// <summary>��ȡ����������ɫģʽ</summary>
        public readonly ColorScheme ColorSchema;

        /// <summary>����ColorSchemeChange�¼�ʱʹ�õĲ���</summary>
        /// <param name="eColorSchema">����������ɫģʽ</param>
        public ColorSchemeChangeEventArgs(ColorScheme eColorSchema)
        {
            this.ColorSchema = eColorSchema;
        }
    }
}
