using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concesionaria
{
    class txtSeparador: Control
    {
        private int thckness = 1;
        private bool isVertical;

        protected override void OnPaint(PaintEventArgs e) 
        {
            base.OnPaint(e);
            var sz = isVertical ? Height / 2 : Width / 2;
            e.Graphics.TranslateTransform(Width / 2f, Height / 2f);

            using (var pen = new Pen(ForeColor, thckness)) 
            {
                if (!isVertical) 
                {
                    e.Graphics.DrawLine(pen, -sz + Padding.Left, 0, sz - Padding.Right, 0);
                }
            }

        }
        protected override void OnPaddingChanged(EventArgs e)
        {
            base.OnPaddingChanged(e);
            Invalidate();
        }
    }
}
