using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibCourseProject;
using static System.Drawing.Drawing2D.LineCap;

namespace Course_Project
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		delegate void del (MouseEventArgs e);
		del deli;
		delegate void del2 (MouseEventArgs e, MouseEventArgs e2);
		del2 deli2;
		// Обработка событий MouseEnter и MousLeave для изображений
		#region

		private void pictureBox2_MouseEnter(object sender, EventArgs e)
		{
			label1.Text = "Узел";
		}

		private void pictureBox2_MouseLeave(object sender, EventArgs e)
		{
			label1.Text = "";
		}

		private void pictureBox1_MouseEnter(object sender, EventArgs e)
		{
			label1.Text = "Компонент";
		}

		private void pictureBox1_MouseLeave(object sender, EventArgs e)
		{
			label1.Text = "";
		}

		private void pictureBox3_MouseEnter(object sender, EventArgs e)
		{
			label1.Text = "Пакет";
		}

		private void pictureBox3_MouseLeave(object sender, EventArgs e)
		{
			label1.Text = "";
		}

		private void pictureBox4_MouseEnter(object sender, EventArgs e)
		{
			label1.Text = "Интерфейс";
		}

		private void pictureBox4_MouseLeave(object sender, EventArgs e)
		{
			label1.Text = "";
		}

		private void pictureBox5_MouseEnter(object sender, EventArgs e)
		{
			label1.Text = "Зависимость";
		}

		private void pictureBox5_MouseLeave(object sender, EventArgs e)
		{
			label1.Text = "";
		}

		private void pictureBox6_MouseEnter(object sender, EventArgs e)
		{
			label1.Text = "Ограничение";
		}

		private void pictureBox6_MouseLeave(object sender, EventArgs e)
		{
			label1.Text = "";
		}

		private void pictureBox7_MouseEnter(object sender, EventArgs e)
		{
			label1.Text = "Примечание";
		}

		private void pictureBox7_MouseLeave(object sender, EventArgs e)
		{
			label1.Text = "";
		}

		private void pictureBox8_MouseEnter(object sender, EventArgs e)
		{
			label1.Text = "Ограничение 2 элементов";
		}

		private void pictureBox8_MouseLeave(object sender, EventArgs e)
		{
			label1.Text = "";
		}

		private void pictureBox9_MouseEnter(object sender, EventArgs e)
		{
			label1.Text = "Ограничение ИЛИ";
		}

		private void pictureBox9_MouseLeave(object sender, EventArgs e)
		{
			label1.Text = "";
		}
		#endregion
		MouseEventArgs Ef;
		MouseEventArgs Ef2;

		private void pictureBox2_MouseDown(object sender, MouseEventArgs e) //метод определяющий какой из элементов удерживается
		{
			if (sender == pictureBox2)
			{
				deli = PaiC;
				deli2 = null;
			}
			if (sender == pictureBox1)
			{
				deli = PaiK;
				deli2 = null;
			}
			if (sender == pictureBox3)
			{		deli = PaiP;
				deli2 = null;
			}
			if (sender == pictureBox4)
			{
				deli2 = PaiI;
				deli = null;
			}
			if (sender == pictureBox5)
			{
				deli2 = PaiS;
				deli = null;
			}
			if (sender == pictureBox6)
			{
				deli = PaiU;
				deli2 = null;
			}
			if (sender == pictureBox7)
				{
					deli = PaiU;
					deli2 = null;
				}
			if (sender == pictureBox8) ;
			//image = pictureBox8.Image;
			if (sender == pictureBox9) ;
				//image = pictureBox9.Image;
		}

		private void PaiK(MouseEventArgs e)// для картинки 1
		{
			int x1 = e.X;
			int y1 = e.Y;
			Pen p = new Pen(Color.Blue);
			Graphics gr = picture.CreateGraphics();
			Point[] points = { new Point(x1, y1), new Point(x1+90, y1), new Point(x1 + 90, y1 +80), new Point(x1 , y1 + 80), new Point(x1 , y1 + 70), new Point(x1 + 15, y1+70), new Point(x1 + 15, y1 + 55), new Point(x1 + 15, y1 + 70), new Point(x1 -15, y1 + 70), new Point(x1 -15, y1+55), new Point(x1+15, y1 + 55), new Point(x1, y1 + 55), new Point(x1, y1 + 25), new Point(x1+15, y1 + 25), new Point(x1 + 15, y1 + 10), new Point(x1 + 15, y1 + 25), new Point(x1-15, y1 + 25), new Point(x1-15, y1 + 10), new Point(x1+15, y1 + 10), new Point(x1, y1 +10) };
			gr.DrawPolygon(p, points);
		}
		private void PaiC(MouseEventArgs e)// для картинки 2
		{
			int x1 = e.X;
			int y1 = e.Y;
			Pen p = new Pen(Color.Blue);
			Graphics gr = picture.CreateGraphics();
			Point[] points = { new Point(x1, y1), new Point(x1, y1 + 80), new Point(x1 + 80, y1 + 80), new Point(x1 + 80, y1 ), new Point(x1 , y1), new Point(x1 + 15, y1-15), new Point(x1 + 95, y1 -15), new Point(x1+80, y1), new Point(x1 + 80, y1+80), new Point(x1 + 95, y1+65), new Point(x1 + 95, y1-15), new Point(x1 + 80, y1) };
			gr.DrawPolygon(p, points);
		}
		private void PaiU(MouseEventArgs e)// для картинки 6 u 7
		{
			int x1 = e.X;
			int y1 = e.Y;
			Pen p = new Pen(Color.Blue);
			Graphics gr= picture.CreateGraphics();
			Point[] points = { new Point(x1, y1 ), new Point(x1 , y1 + 80), new Point(x1 + 90, y1 + 80), new Point(x1 + 90, y1 + 25), new Point(x1 + 75, y1 + 25), new Point(x1 + 75, y1 ),  new Point(x1 + 90, y1 + 25), new Point(x1 + 75, y1 ) };
			gr.DrawPolygon(p,points);
		}
		private void PaiP(MouseEventArgs e)// для картинки 3
		{
			int x1 = e.X;
			int y1 = e.Y;
			Pen p = new Pen(Color.Blue);
			Graphics gr = picture.CreateGraphics();
			Point[] points = { new Point(x1, y1), new Point(x1, y1 + 15), new Point(x1 , y1 + 60), new Point(x1 + 90, y1 + 60), new Point(x1 + 90, y1 + 15), new Point(x1 + 25, y1+15), new Point(x1 , y1 + 15), new Point(x1 + 25, y1+15), new Point(x1 + 25, y1) };
			gr.DrawPolygon(p, points);
		}
		private void PaiI(MouseEventArgs e ,MouseEventArgs e2)// для картинки 4
		{
			float x1 = e.X;
			float y1 = e.Y;
			float x2 = e2.X;
			float y2 = e2.Y;
			Pen p = new Pen(Color.Blue,5);
			p.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor; ;
			
			Graphics gr = picture.CreateGraphics();
				gr.DrawLine(p, x1 , y1 , x2, y2);
		}
		private void PaiS(MouseEventArgs e, MouseEventArgs e2)// для картинки 5

		{
			float x1 = e.X;
			float y1 = e.Y;
			float x2 = e2.X;
			float y2 = e2.Y;
			Pen p = new Pen(Color.Black, 5);
			p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash ;
			p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor ;

			Graphics gr = picture.CreateGraphics();
			
			gr.DrawLine(p, x1, y1, x2, y2);
			
		}

		private void picture_MouseClick(object sender, MouseEventArgs e)
		{
			if (deli != null)
			{
				deli(e);
			}
			
		}

		private void picture_MouseDown(object sender, MouseEventArgs e)
		{
			Ef = e;
		}

		private void picture_MouseUp(object sender, MouseEventArgs e)
		{
			Ef2 = e;
			if (deli2 != null)
			{
				deli2(Ef, Ef2);
			}
		}
	}
}
