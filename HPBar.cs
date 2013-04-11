/**
 * An HP bar that changes colour depending on the number of hit points remaining.
 * @author Tom Chataway (although I simply expanded on the work of Chris Persichetti)
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Squire
{
    public class HPBar : ProgressBar
    {
        public HPBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rec = e.ClipRectangle;

            if (Value > -1 && Maximum > 0)
            {
                rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 4;
                if (ProgressBarRenderer.IsSupported)
                    ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
                rec.Height = rec.Height - 4;
                if (Value > (Maximum / 2)) e.Graphics.FillRectangle(Brushes.Green, 2, 2, rec.Width, rec.Height);
                else if (Value > (Maximum / 4)) e.Graphics.FillRectangle(Brushes.Yellow, 2, 2, rec.Width, rec.Height);
                else e.Graphics.FillRectangle(Brushes.Red, 2, 2, rec.Width, rec.Height);
            }
        }
    }
}