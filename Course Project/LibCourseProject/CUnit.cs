using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCourseProject
{
	public class CUnit
	{
		public CUnit() : base()
		{
		
		}
		private bool Check(MUnit mUnit)
		{
			Saved saved = new Saved();
			if (saved.mUnits.IndexOf(mUnit) > 0)
				return false;
			return true;
		}
		/// <summary>
		/// Метод Добавления
		/// </summary>
		public bool Insert(Model model)
		{
			MUnit mUnit = (MUnit)model;
			if (Check(mUnit) == true)
			{
				Saved saved = new Saved();
				saved.mUnits.Add(mUnit);
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
			MUnit mUnit = (MUnit)model;
			if (saved.mUnits.Remove(mUnit) == true)
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
			MUnit mUnit = (MUnit)model;
			if (Check(mUnit) == false)
			{
				int pos = saved.mUnits.IndexOf(mUnit);
				saved.mUnits[pos].Coordinates = mUnit.Coordinates;
				saved.mUnits[pos].Size = mUnit.Size;
				return true;
			}
			else
				return false;
		}
	}
}
