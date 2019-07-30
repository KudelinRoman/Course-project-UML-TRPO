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
	/// Класс "Пакет"
	/// </summary>
	public class PaiP
	{
		PictureBox picture = new PictureBox();
		public PaiP(PictureBox picture)
		{
			this.picture = picture;
		}
		/// <summary>
		/// Метод для рисования "Пакет"
		/// </summary>
		/// <param name="e"></param>
		/// <returns></returns>
		public PictureBox Ris(MouseEventArgs e)
		{
			int x1 = e.X;
			int y1 = e.Y;
			Pen p = new Pen(Color.Blue);
			Graphics gr = picture.CreateGraphics();
			Point[] points = { new Point(x1, y1), new Point(x1, y1 + 15), new Point(x1, y1 + 60), new Point(x1 + 90, y1 + 60), new Point(x1 + 90, y1 + 15), new Point(x1 + 25, y1 + 15), new Point(x1, y1 + 15), new Point(x1 + 25, y1 + 15), new Point(x1 + 25, y1) };
			gr.DrawPolygon(p, points);
			gr.Dispose();
			return picture;
		}
		/// <summary>
		/// Метод для перерисовки "Пакет"
		/// </summary>
		/// <param name="e"></param>
		/// <returns></returns>
		public PictureBox Paint(MouseEventArgs e)
		{
			Pen p = new Pen(Color.Blue);
			Graphics gr = picture.CreateGraphics();
			int x1 = e.X;
			int y1 = e.Y;
			Point[] points = { new Point(x1, y1), new Point(x1, y1 + 15), new Point(x1, y1 + 60), new Point(x1 + 90, y1 + 60), new Point(x1 + 90, y1 + 15), new Point(x1 + 25, y1 + 15), new Point(x1, y1 + 15), new Point(x1 + 25, y1 + 15), new Point(x1 + 25, y1) };
			gr.DrawPolygon(p, points);
			return picture;
		}
	}
}
