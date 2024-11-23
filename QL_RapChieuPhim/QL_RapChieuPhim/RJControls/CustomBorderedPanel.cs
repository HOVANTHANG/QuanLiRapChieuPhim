using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_RapChieuPhim.RJControls
{
	public class CustomBorderedPanel : Panel
	{
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			// Vẽ viền tùy chỉnh ở đây
			int borderWidth = 3;
			Color borderColor = Color.Red; // Màu của viền

			using (Pen borderPen = new Pen(borderColor, borderWidth))
			{
				e.Graphics.DrawRectangle(borderPen, new Rectangle(0, 0, Width - 1, Height - 1));
			}
		}
	}
}
