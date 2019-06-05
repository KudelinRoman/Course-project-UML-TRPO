using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCourseProject
{
	class MDependence: Model
	{
		/// <summary>
		/// Размер
		/// </summary>
		double _size;
		/// <summary>
		/// Изображение
		/// </summary>
		object _image;
		/// <summary>
		/// Положение (координаты)
		/// </summary>
		int _coordinates;
		/// <summary>
		/// Возвращает или задает размер
		/// </summary>
		public double Size
		{
			get
			{
				return _size;
			}
			set
			{
				_size = value;
			}
		}
		/// <summary>
		/// Возвращает изображение
		/// </summary>
		public object Image
		{
			get
			{
				return _image;
			}
		}
		/// <summary>
		/// Возвращает или задает координаты
		/// </summary>
		public int Coordinates
		{
			get
			{
				return _coordinates;
			}
			set
			{
				_coordinates = value;
			}
		}

		public MDependence(double size, object image, int coordinates) : base()
		{
			Size = size;
			object Image = image;
			Coordinates = coordinates;
		}

	}
}
