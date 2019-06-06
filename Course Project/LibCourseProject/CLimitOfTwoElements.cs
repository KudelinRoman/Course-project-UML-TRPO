using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCourseProject
{
	public class CLimitOfTwoElements
	{
		public CLimitOfTwoElements():base()
		{

		}
		private bool Check(MLimitOfTwoElements mLimitOfTwoElements)
		{
			Saved saved = new Saved();
			if (saved.mLimitOfTwoElements.IndexOf(mLimitOfTwoElements) > 0)
				return false;
			return true;
		}
		/// <summary>
		/// Метод Добавления
		/// </summary>
		public bool Insert(Model model)
		{
			MLimitOfTwoElements mLimitOfTwoElements = (MLimitOfTwoElements)model;
			if (Check(mLimitOfTwoElements) == true)
			{
				Saved saved = new Saved();
				saved.mLimitOfTwoElements.Add(mLimitOfTwoElements);
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
			MLimitOfTwoElements mLimitOfTwoElements = (MLimitOfTwoElements)model;
			if (saved.mLimitOfTwoElements.Remove(mLimitOfTwoElements) == true)
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
			MLimitOfTwoElements mLimitOfTwoElements = (MLimitOfTwoElements)model;
			if (Check(mLimitOfTwoElements) == false)
			{
				int pos = saved.mLimitOfTwoElements.IndexOf(mLimitOfTwoElements);
				saved.mLimitOfTwoElements[pos].Coordinates = mLimitOfTwoElements.Coordinates;
				saved.mLimitOfTwoElements[pos].Size = mLimitOfTwoElements.Size;
				return true;
			}
			else
				return false;
		}
	}
}
