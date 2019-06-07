using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Project
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

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
		
	}
}
