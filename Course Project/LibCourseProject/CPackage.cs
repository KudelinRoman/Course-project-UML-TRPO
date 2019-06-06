using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCourseProject
{
	public class CPackage
	{
		public CPackage():base()
		{

		}
		private bool Check(MPackage mPackage)
		{
			Saved saved = new Saved();
			if (saved.mPackages.IndexOf(mPackage) > 0)
				return false;
			return true;
		}
		/// <summary>
		/// Метод Добавления
		/// </summary>
		public bool Insert(Model model)
		{
			MPackage mPackage = (MPackage)model;
			if (Check(mPackage) == true)
			{
				Saved saved = new Saved();
				saved.mPackages.Add(mPackage);
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
			MPackage mPackage = (MPackage)model;
			if (saved.mPackages.Remove(mPackage) == true)
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
			MPackage mPackage = (MPackage)model;
			if (Check(mPackage) == false)
			{
				int pos = saved.mPackages.IndexOf(mPackage);
				saved.mPackages[pos].Coordinates = mPackage.Coordinates;
				saved.mPackages[pos].Size = mPackage.Size;
				return true;
			}
			else
				return false;
		}
	}
}
