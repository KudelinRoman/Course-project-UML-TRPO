using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibCourseProject
{
	public class MDependence: Model
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
		/// Положение (координатa X)
		/// </summary>
		int _coordinatesX;
		/// <summary>
		/// Положение (координатa Y)
		/// </summary>
		int _coordinatesY;
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
			set
			{
				_image = value;
			}
		}
		/// <summary>
		/// Возвращает или задает координатy X
		/// </summary>
		public int CoordinatesX
		{
			get
			{
				return _coordinatesX;
			}
			set
			{
				_coordinatesX = value;
			}
		}
		/// <summary>
		/// Возвращает или задает координатy Y
		/// </summary>
		public int CoordinatesY
		{
			get
			{
				return _coordinatesY;
			}
			set
			{
				_coordinatesY = value;
			}
		}

		public MDependence(double size, object image, int coordinatesX, int coordinatesY) : base()
		{
			Size = size;
			object Image = image;
			CoordinatesX = coordinatesX;
			CoordinatesY = coordinatesY;
		}

	}
}
