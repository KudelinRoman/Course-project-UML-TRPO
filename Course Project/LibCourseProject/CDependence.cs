using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCourseProject
{
	public class CDependence
	{
		public CDependence():base()
		{

		}
		private bool Check(MDependence mDependence)
		{
			Saved saved = new Saved();
			if (saved.mDependences.IndexOf(mDependence) > 0)
				return false;
			return true;
		}
		/// <summary>
		/// Метод Добавления
		/// </summary>
		public bool Insert(Model model)
		{
			MDependence mDependence = (MDependence)model;
			if (Check(mDependence) == true)
			{
				Saved saved = new Saved();
				saved.mDependences.Add(mDependence);
				return true;
			}
			else
				return false;
		}
		/// <summary>
		/// Метод удаления
		/// </summary>
		public bool Delete(Model model)
		{
			Saved saved = new Saved();
			MDependence mDependence = (MDependence)model;
			if (saved.mDependences.Remove(mDependence) == true)
			{
				return true;
			}
			else
				return false;
		}
		/// <summary>
		/// Метод изменения
		/// </summary>
		public bool Update(Model model)
		{
			Saved saved = new Saved();
			MDependence mDependence = (MDependence)model;
			if (Check(mDependence) == false)
			{
				int pos = saved.mDependences.IndexOf(mDependence);
				saved.mDependences[pos].Coordinates = mDependence.Coordinates;
				saved.mDependences[pos].Size = mDependence.Size;
				return true;
			}
			else
				return false;
		}
	}
}
