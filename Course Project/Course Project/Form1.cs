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
		Image image= null; // переменная которая содержит изображение выбранного элемента
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

		
		private void pictureBox2_MouseDown(object sender, MouseEventArgs e) //метод определяющий какой из элементов удерживается
		{
			if (sender == pictureBox2)
				image = pictureBox2.Image;
			if (sender == pictureBox1)
				image = pictureBox1.Image;
			if (sender == pictureBox3)
				image = pictureBox3.Image;
			if (sender == pictureBox4)
				image = pictureBox4.Image;
			if (sender == pictureBox5)
				image = pictureBox5.Image;
			if (sender == pictureBox6)
				image = pictureBox6.Image;
			if (sender == pictureBox7)
				image = pictureBox7.Image;
			if (sender == pictureBox8)
				image = pictureBox8.Image;
			if (sender == pictureBox9)
				image = pictureBox9.Image;
		}


	}
}
