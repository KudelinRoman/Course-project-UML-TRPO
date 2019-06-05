using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCourseProject
{
	class MRestrictionOr: Model
	{
		double _size;
		object _image;
		int _coordinates;

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

		public object Image
		{
			get
			{
				return _image;
			}
		}

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

		public MRestrictionOr(double size, object image, int coordinates) : base()
		{
			Size = size;
			object Image = image;
			Coordinates = coordinates;
		}

	}
}
