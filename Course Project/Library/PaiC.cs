using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Library
{
	/// <summary>
	/// Класс для "Компонента"
	/// </summary>
	public class PaiC
	{
		PictureBox picture = new PictureBox();
		public PaiC(PictureBox picture)
		{
			this.picture = picture;
		}
		/// <summary>
		/// Метод создания "Компонента"
		/// </summary>
		/// <param name="e"></param>
		/// <returns></returns>
		public PictureBox Ris(MouseEventArgs e)
		{
			int x1 = e.X;
			int y1 = e.Y;
			Pen p = new Pen(Color.Blue);
			Graphics gr = picture.CreateGraphics();
			Point[] points = { new Point(x1, y1), new Point(x1, y1 + 80), new Point(x1 + 80, y1 + 80), new Point(x1 + 80, y1), new Point(x1, y1), new Point(x1 + 15, y1 - 15), new Point(x1 + 95, y1 - 15), new Point(x1 + 80, y1), new Point(x1 + 80, y1 + 80), new Point(x1 + 95, y1 + 65), new Point(x1 + 95, y1 - 15), new Point(x1 + 80, y1) };
			gr.DrawPolygon(p, points);
			gr.Dispose();
			return picture;
		}
		/// <summary>
		/// Метод перерисовки "Компонента"
		/// </summary>
		/// <param name="e"></param>
		/// <returns></returns>
		public PictureBox Paint(MouseEventArgs e)
		{
			Pen p = new Pen(Color.Blue);
			Graphics gr = picture.CreateGraphics();
			int x1 = e.X;
			int y1 = e.Y;
			Point[] points = { new Point(x1, y1), new Point(x1, y1 + 80), new Point(x1 + 80, y1 + 80), new Point(x1 + 80, y1), new Point(x1, y1), new Point(x1 + 15, y1 - 15), new Point(x1 + 95, y1 - 15), new Point(x1 + 80, y1), new Point(x1 + 80, y1 + 80), new Point(x1 + 95, y1 + 65), new Point(x1 + 95, y1 - 15), new Point(x1 + 80, y1) };
			gr.DrawPolygon(p, points);
			return picture;
		}
	}
}
