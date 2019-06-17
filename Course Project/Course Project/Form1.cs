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
		Saved sev = new Saved();
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
		public List<MouseEventArgs> Komponent = new List<MouseEventArgs>();
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
			{
				deli = PaiP;
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
			if (sender == pictureBox8) 
			{
				deli = null;
				deli2 = PaiL;
			}
			if (sender == pictureBox9)
			{
				deli = null;
				deli2 = PaiM;
			}

		}
		
		private void PaiK(MouseEventArgs e)// для картинки 1
		{
			int x1 = e.X;
			int y1 = e.Y;
			Pen p = new Pen(Color.Blue);
			Graphics gr = picture.CreateGraphics();
			Point[] points = { new Point(x1, y1), new Point(x1+90, y1), new Point(x1 + 90, y1 +80), new Point(x1 , y1 + 80), new Point(x1 , y1 + 70), new Point(x1 + 15, y1+70), new Point(x1 + 15, y1 + 55), new Point(x1 + 15, y1 + 70), new Point(x1 -15, y1 + 70), new Point(x1 -15, y1+55), new Point(x1+15, y1 + 55), new Point(x1, y1 + 55), new Point(x1, y1 + 25), new Point(x1+15, y1 + 25), new Point(x1 + 15, y1 + 10), new Point(x1 + 15, y1 + 25), new Point(x1-15, y1 + 25), new Point(x1-15, y1 + 10), new Point(x1+15, y1 + 10), new Point(x1, y1 +10) };
			gr.DrawPolygon(p, points);
			sev.Component.Add(e);
			gr.Dispose();
		}
		private void PaiC(MouseEventArgs e)// для картинки 2
		{
		//	Saved sev = new Saved();
			int x1 = e.X;
			int y1 = e.Y;
			Pen p = new Pen(Color.Blue);
			Graphics gr = picture.CreateGraphics();
			Point[] points = { new Point(x1, y1), new Point(x1, y1 + 80), new Point(x1 + 80, y1 + 80), new Point(x1 + 80, y1 ), new Point(x1 , y1), new Point(x1 + 15, y1-15), new Point(x1 + 95, y1 -15), new Point(x1+80, y1), new Point(x1 + 80, y1+80), new Point(x1 + 95, y1+65), new Point(x1 + 95, y1-15), new Point(x1 + 80, y1) };
			gr.DrawPolygon(p, points);
			sev.Unit.Add(e);
			gr.Dispose();
			
		}
		private void PaiU(MouseEventArgs e)// для картинки 6 u 7
		{
			int x1 = e.X;
			int y1 = e.Y;
			Pen p = new Pen(Color.Blue);
			Graphics gr= picture.CreateGraphics();
			Point[] points = { new Point(x1, y1 ), new Point(x1 , y1 + 80), new Point(x1 + 90, y1 + 80), new Point(x1 + 90, y1 + 25), new Point(x1 + 75, y1 + 25), new Point(x1 + 75, y1 ),  new Point(x1 + 90, y1 + 25), new Point(x1 + 75, y1 ) };
			gr.DrawPolygon(p,points);
			sev.Prim.Add(e);
			gr.Dispose();
		}
		private void PaiP(MouseEventArgs e)// для картинки 3
		{
			int x1 = e.X;
			int y1 = e.Y;
			Pen p = new Pen(Color.Blue);
			Graphics gr = picture.CreateGraphics();
			Point[] points = { new Point(x1, y1), new Point(x1, y1 + 15), new Point(x1 , y1 + 60), new Point(x1 + 90, y1 + 60), new Point(x1 + 90, y1 + 15), new Point(x1 + 25, y1+15), new Point(x1 , y1 + 15), new Point(x1 + 25, y1+15), new Point(x1 + 25, y1) };
			gr.DrawPolygon(p, points);
			sev.Pac.Add(e);
			gr.Dispose();
		}
		private void PaiI(MouseEventArgs e ,MouseEventArgs e2)// для картинки 4
		{
			float x1 = e.X;
			float y1 = e.Y;
			float x2 = e2.X;
			float y2 = e2.Y;
			Pen p = new Pen(Color.Blue,5);
			p.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor; 
			Graphics gr = picture.CreateGraphics();
			gr.DrawLine(p, x1 , y1 , x2, y2);
			sev.Intrf.Add(e);
			sev.Intrf.Add(e2);
			gr.Dispose();
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
			sev.Zav.Add(e);
			sev.Zav.Add(e2);
			gr.Dispose();
		}
		private void PaiL (MouseEventArgs e, MouseEventArgs e2)
		{
			float x1 = e.X;
			float y1 = e.Y;
			float x2 = e2.X;
			float y2 = e2.Y;
			Pen p = new Pen(Color.Black, 5);
			p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
			Graphics gr = picture.CreateGraphics();
			gr.DrawLine(p, x1, y1, x2, y2);
			sev.Organ2.Add(e);
			sev.Organ2.Add(e2);
			gr.Dispose();
		}
		private void PaiM(MouseEventArgs e, MouseEventArgs e2)
		{
			float x1 = e.X;
			float y1 = e.Y;
			float x2 = e2.X;
			float y2 = e2.Y;
			Pen p = new Pen(Color.Black, 5);
			p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
			p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
			Graphics gr = picture.CreateGraphics();
			gr.DrawLine(p, x1, y1, x2, y2);
			sev.OrganOR.Add(e);
			sev.OrganOR.Add(e2);
			gr.Dispose();
		}

		private void picture_MouseClick(object sender, MouseEventArgs e)
		{
			if (deli != null)
			{
				deli(e);
			}
			if (this.Cursor==Cursors.Hand)
			{
				for (int i = 0; i < sev.Component.Count(); i++)
				{
					if (e.X < sev.Component[i].X + 3 && e.X > sev.Component[i].X - 3 && e.Y < sev.Component[i].Y + 3 && e.Y > sev.Component[i].Y - 3)
					{
						sev.Component.RemoveAt(i);
					}
				}
				for (int i = 0; i < sev.Unit.Count(); i++)
				{
					if (e.X < sev.Unit[i].X + 3 && e.X > sev.Unit[i].X - 3 && e.Y < sev.Unit[i].Y + 3 && e.Y > sev.Unit[i].Y - 3)
					{
						sev.Unit.RemoveAt(i);
					}
				}
				for (int i = 0; i < sev.Prim.Count(); i++)
				{
					if (e.X < sev.Prim[i].X + 3 && e.X > sev.Prim[i].X - 3 && e.Y < sev.Prim[i].Y + 3 && e.Y > sev.Prim[i].Y - 3)
					{
						sev.Prim.RemoveAt(i);
					}
				}
				for (int i = 0; i < sev.Pac.Count(); i++)
				{
					if (e.X < sev.Pac[i].X + 3 && e.X > sev.Pac[i].X - 3 && e.Y < sev.Pac[i].Y + 3 && e.Y > sev.Pac[i].Y - 3)
					{
						sev.Pac.RemoveAt(i);
					}
				}
				for (int i = 0; i < sev.Intrf.Count(); i++)
				{
					if (e.X < sev.Intrf[i].X + 3 && e.X > sev.Intrf[i].X - 3 && e.Y < sev.Intrf[i].Y + 3 && e.Y > sev.Intrf[i].Y - 3)
					{
						if (i % 2 == 0)
						{
							sev.Intrf.RemoveAt(i + 1);
							sev.Intrf.RemoveAt(i);
						}
						else
						{
							sev.Intrf.RemoveAt(i - 1);
							sev.Intrf.RemoveAt(i-1);
						}

					}
				}
				for (int i = 0; i < sev.Organ2.Count(); i++)
				{
					if (e.X < sev.Organ2[i].X + 3 && e.X > sev.Organ2[i].X - 3 && e.Y < sev.Organ2[i].Y + 3 && e.Y > sev.Organ2[i].Y - 3)
					{
						if (i % 2 == 0)
						{
							sev.Organ2.RemoveAt(i + 1);
							sev.Organ2.RemoveAt(i);
						}
						else
						{
							sev.Organ2.RemoveAt(i - 1);
							sev.Organ2.RemoveAt(i - 1);
						}
					}
				}
				for (int i = 0; i < sev.OrganOR.Count(); i++)
				{
					if (e.X < sev.OrganOR[i].X + 3 && e.X > sev.OrganOR[i].X - 3 && e.Y < sev.OrganOR[i].Y + 3 && e.Y > sev.OrganOR[i].Y - 3)
					{
						if (i % 2 == 0)
						{
							sev.OrganOR.RemoveAt(i + 1);
							sev.OrganOR.RemoveAt(i);
						}
						else
						{
							sev.OrganOR.RemoveAt(i - 1);
							sev.OrganOR.RemoveAt(i - 1);
						}
					}
				}
				for (int i = 0; i < sev.Zav.Count(); i++)
				{
					if (e.X < sev.Zav[i].X + 3 && e.X > sev.Zav[i].X - 3 && e.Y < sev.Zav[i].Y + 3 && e.Y > sev.Zav[i].Y - 3)
					{
						if (i % 2 == 0)
						{
							sev.Zav.RemoveAt(i + 1);
							sev.Zav.RemoveAt(i);
						}
						else
						{
							sev.Zav.RemoveAt(i - 1);
							sev.Zav.RemoveAt(i - 1);
						}
					}
				}
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
			if (this.Cursor == Cursors.SizeAll)
			{
				picture.Refresh();
				picture_Paint();
				Points();
			}
			if (this.Cursor == Cursors.Hand)
			{
				picture.Refresh();
				picture_Paint();
				Points();
			}

		}
		/// <summary>
		/// Метод перерисовки созданных элементов
		/// </summary>
		private void picture_Paint()
		{
			Pen p = new Pen(Color.Blue);
			Graphics gr = picture.CreateGraphics(); 
			for (int i = 0; i < sev.Unit.Count(); i++)
			{
				MouseEventArgs e = sev.Unit[i];
				int x1 = sev.Unit[i].X;
				int y1 = sev.Unit[i].Y;
				Point[] points = { new Point(x1, y1), new Point(x1, y1 + 80), new Point(x1 + 80, y1 + 80), new Point(x1 + 80, y1), new Point(x1, y1), new Point(x1 + 15, y1 - 15), new Point(x1 + 95, y1 - 15), new Point(x1 + 80, y1), new Point(x1 + 80, y1 + 80), new Point(x1 + 95, y1 + 65), new Point(x1 + 95, y1 - 15), new Point(x1 + 80, y1) };
				gr.DrawPolygon(p, points);
			}
			for (int i = 0; i < sev.Component.Count(); i++)
			{
				MouseEventArgs e = sev.Component[i];
				int x1 = e.X;
				int y1 = e.Y;
				Point[] points = { new Point(x1, y1), new Point(x1 + 90, y1), new Point(x1 + 90, y1 + 80), new Point(x1, y1 + 80), new Point(x1, y1 + 70), new Point(x1 + 15, y1 + 70), new Point(x1 + 15, y1 + 55), new Point(x1 + 15, y1 + 70), new Point(x1 - 15, y1 + 70), new Point(x1 - 15, y1 + 55), new Point(x1 + 15, y1 + 55), new Point(x1, y1 + 55), new Point(x1, y1 + 25), new Point(x1 + 15, y1 + 25), new Point(x1 + 15, y1 + 10), new Point(x1 + 15, y1 + 25), new Point(x1 - 15, y1 + 25), new Point(x1 - 15, y1 + 10), new Point(x1 + 15, y1 + 10), new Point(x1, y1 + 10) };
				gr.DrawPolygon(p, points);
			}
			for (int i = 0; i < sev.Prim.Count(); i++)
			{
				MouseEventArgs e = sev.Prim[i];
				int x1 = e.X;
				int y1 = e.Y;
				Point[] points = { new Point(x1, y1), new Point(x1, y1 + 80), new Point(x1 + 90, y1 + 80), new Point(x1 + 90, y1 + 25), new Point(x1 + 75, y1 + 25), new Point(x1 + 75, y1), new Point(x1 + 90, y1 + 25), new Point(x1 + 75, y1) };
				gr.DrawPolygon(p, points);
			}
			for (int i = 0; i < sev.Pac.Count(); i++)
			{
				MouseEventArgs e = sev.Pac[i];
				int x1 = e.X;
				int y1 = e.Y;
				Point[] points = { new Point(x1, y1), new Point(x1, y1 + 15), new Point(x1, y1 + 60), new Point(x1 + 90, y1 + 60), new Point(x1 + 90, y1 + 15), new Point(x1 + 25, y1 + 15), new Point(x1, y1 + 15), new Point(x1 + 25, y1 + 15), new Point(x1 + 25, y1) };
				gr.DrawPolygon(p, points);
			}
			for (int i = 0; i < sev.Intrf.Count(); i=i+2)
			{
				MouseEventArgs e = sev.Intrf[i];
				MouseEventArgs e2 = sev.Intrf[i+1];
				float x1 = e.X;
				float y1 = e.Y;
				float x2 = e2.X;
				float y2 = e2.Y;
				Pen pe = new Pen(Color.Blue, 5);
				pe.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
				gr.DrawLine(pe, x1, y1, x2, y2);
				pe.Dispose();
			}
			for (int i = 0; i < sev.Zav.Count(); i = i + 2)
			{
				MouseEventArgs e = sev.Zav[i];
				MouseEventArgs e2 = sev.Zav[i+1];
				float x1 = e.X;
				float y1 = e.Y;
				float x2 = e2.X;
				float y2 = e2.Y;
				Pen pe = new Pen(Color.Black, 5);
				pe.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
				pe.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
				gr.DrawLine(pe, x1, y1, x2, y2);
				pe.Dispose();
			}
			for (int i = 0; i < sev.Organ2.Count(); i = i + 2)
			{
				MouseEventArgs e = sev.Organ2[i];
				MouseEventArgs e2 = sev.Organ2[i+1];
				float x1 = e.X;
				float y1 = e.Y;
				float x2 = e2.X;
				float y2 = e2.Y;
				Pen pe = new Pen(Color.Black, 5);
				pe.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
				pe.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
				gr.DrawLine(pe, x1, y1, x2, y2);
				pe.Dispose();
			}
			for (int i = 0; i < sev.OrganOR.Count(); i = i + 2)
			{
				MouseEventArgs e = sev.OrganOR[i];
				MouseEventArgs e2 = sev.OrganOR[i+1];
				float x1 = e.X;
				float y1 = e.Y;
				float x2 = e2.X;
				float y2 = e2.Y;
				Pen pe = new Pen(Color.Black, 5);
				pe.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
				pe.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
				gr.DrawLine(pe, x1, y1, x2, y2);
				pe.Dispose();
			}
		}

		private void picture_Paint(object sender, PaintEventArgs e)
		{
			picture_Paint();
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.SizeAll; 
			pictureBox1.Enabled = false;
			pictureBox2.Enabled = false;
			pictureBox3.Enabled = false;
			pictureBox4.Enabled = false;
			pictureBox5.Enabled = false;
			pictureBox6.Enabled = false;
			pictureBox7.Enabled = false;
			pictureBox8.Enabled = false;
			pictureBox9.Enabled = false;
			deli = null;deli2 = null;
			Points();
		}
		/// <summary>
		/// Метод, который выделяет главный угол (точку)
		/// </summary>
		private void Points ()
		{
			Pen pen = new Pen(Color.Blue, 6);
			Graphics gr = picture.CreateGraphics();
			for (int i = 0; i < sev.Unit.Count(); i++)
				gr.DrawRectangle(pen, sev.Unit[i].X, sev.Unit[i].Y, 3, 3);
			for (int i = 0; i < sev.Component.Count(); i++)
				gr.DrawRectangle(pen, sev.Component[i].X, sev.Component[i].Y, 3, 3);
			for (int i = 0; i < sev.Pac.Count(); i++)
				gr.DrawRectangle(pen, sev.Pac[i].X, sev.Pac[i].Y, 3, 3);
			for (int i = 0; i < sev.Prim.Count(); i++)
				gr.DrawRectangle(pen, sev.Prim[i].X, sev.Prim[i].Y, 3, 3);
			for (int i = 0; i < sev.Intrf.Count(); i = i + 2)
			{
				gr.DrawRectangle(pen, sev.Intrf[i].X, sev.Intrf[i].Y, 3, 3);
				gr.DrawRectangle(pen, sev.Intrf[i+1].X, sev.Intrf[i+1].Y, 3, 3);
			}
			for (int i = 0; i < sev.Zav.Count(); i = i + 2)
			{
				gr.DrawRectangle(pen, sev.Zav[i].X, sev.Zav[i].Y, 3, 3);
				gr.DrawRectangle(pen, sev.Zav[i + 1].X, sev.Zav[i + 1].Y, 3, 3);
			}
			for (int i = 0; i < sev.Organ2.Count(); i = i + 2)
			{
				gr.DrawRectangle(pen, sev.Organ2[i].X, sev.Organ2[i].Y, 3, 3);
				gr.DrawRectangle(pen, sev.Organ2[i + 1].X, sev.Organ2[i + 1].Y, 3, 3);
			}
			for (int i = 0; i < sev.OrganOR.Count(); i = i + 2)
			{
				gr.DrawRectangle(pen, sev.OrganOR[i].X, sev.OrganOR[i].Y, 3, 3);
				gr.DrawRectangle(pen, sev.OrganOR[i + 1].X, sev.OrganOR[i + 1].Y, 3, 3);
			}
			pen.Dispose();
			gr.Dispose();
		}
		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Arrow;
			pictureBox1.Enabled = true;
			pictureBox2.Enabled = true;
			pictureBox3.Enabled = true;
			pictureBox4.Enabled = true;
			pictureBox5.Enabled = true;
			pictureBox6.Enabled = true;
			pictureBox7.Enabled = true;
			pictureBox8.Enabled = true;
			pictureBox9.Enabled = true;
			picture.Refresh();
			picture_Paint();
		}

		private void picture_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.Cursor == Cursors.SizeAll)
			{
				if (e.Button == System.Windows.Forms.MouseButtons.Left)
				{
					for (int i = 0; i < sev.Component.Count(); i++)
					{
						if (e.X < sev.Component[i].X + 3 && e.X > sev.Component[i].X - 3 && e.Y < sev.Component[i].Y + 3 && e.Y > sev.Component[i].Y - 3)
						{
							sev.Component[i] = e;
						}
					}
					for (int i = 0; i < sev.Unit.Count(); i++)
					{
						if (e.X < sev.Unit[i].X + 3 && e.X > sev.Unit[i].X - 3 && e.Y < sev.Unit[i].Y + 3 && e.Y > sev.Unit[i].Y - 3)
						{
							sev.Unit[i] = e;
						}
					}
					for (int i = 0; i < sev.Prim.Count(); i++)
					{
						if (e.X < sev.Prim[i].X + 3 && e.X > sev.Prim[i].X - 3 && e.Y < sev.Prim[i].Y + 3 && e.Y > sev.Prim[i].Y - 3)
						{
							sev.Prim[i] = e;
						}
					}
					for (int i = 0; i < sev.Pac.Count(); i++)
					{
						if (e.X < sev.Pac[i].X + 3 && e.X > sev.Pac[i].X - 3 && e.Y < sev.Pac[i].Y + 3 && e.Y > sev.Pac[i].Y - 3)
						{
							sev.Pac[i] = e;
						}
					}
					for (int i = 0; i < sev.Intrf.Count(); i++)
					{
						if (e.X < sev.Intrf[i].X + 3 && e.X > sev.Intrf[i].X - 3 && e.Y < sev.Intrf[i].Y + 3 && e.Y > sev.Intrf[i].Y - 3)
						{
							sev.Intrf[i] = e;
						}
					}
					for (int i = 0; i < sev.Organ2.Count(); i++)
					{
						if (e.X < sev.Organ2[i].X + 3 && e.X > sev.Organ2[i].X - 3 && e.Y < sev.Organ2[i].Y + 3 && e.Y > sev.Organ2[i].Y - 3)
						{
							sev.Organ2[i] = e;
						}
					}
					for (int i = 0; i < sev.OrganOR.Count(); i++)
					{
						if (e.X < sev.OrganOR[i].X + 3 && e.X > sev.OrganOR[i].X - 3 && e.Y < sev.OrganOR[i].Y + 3 && e.Y > sev.OrganOR[i].Y - 3)
						{
							sev.OrganOR[i] = e;
						}
					}
					for (int i = 0; i < sev.Zav.Count(); i++)
					{
						if (e.X < sev.Zav[i].X + 3 && e.X > sev.Zav[i].X - 3 && e.Y < sev.Zav[i].Y + 3 && e.Y > sev.Zav[i].Y - 3)
						{
							sev.Zav[i] = e;
						}
					}
				}
			}
		}

		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Hand;
			pictureBox1.Enabled = false;
			pictureBox2.Enabled = false;
			pictureBox3.Enabled = false;
			pictureBox4.Enabled = false;
			pictureBox5.Enabled = false;
			pictureBox6.Enabled = false;
			pictureBox7.Enabled = false;
			pictureBox8.Enabled = false;
			pictureBox9.Enabled = false;
			deli = null; deli2 = null;
			Points();
		}
	}
	/// <summary>
	/// Класс для сохранения элементов
	/// </summary>
	[Serializable]
	public class Saved
	{
		public List<MouseEventArgs> Unit = new List<MouseEventArgs> { };
		public List<MouseEventArgs> Component = new List<MouseEventArgs> { };
		public List<MouseEventArgs> Pac = new List<MouseEventArgs> { };
		public List<MouseEventArgs> Intrf = new List<MouseEventArgs> { };
		public List<MouseEventArgs> Zav = new List<MouseEventArgs> { };
		public List<MouseEventArgs> Prim = new List<MouseEventArgs> { };
		public List<MouseEventArgs> Organ2 = new List<MouseEventArgs> { };
		public List<MouseEventArgs> OrganOR = new List<MouseEventArgs> { };

	}
}
