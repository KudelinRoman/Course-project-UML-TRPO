using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCourseProject
{
	public class CRestriction
	{
		public CRestriction():base()
		{

		}
		private bool Check(MRestriction mRestriction)
		{
			Saved saved = new Saved();
			if (saved.mRestrictions.IndexOf(mRestriction) > 0)
				return false;
			return true;
		}
		/// <summary>
		/// Метод Добавления
		/// </summary>
		public bool Insert(Model model)
		{
			MRestriction mRestriction = (MRestriction)model;
			if (Check(mRestriction) == true)
			{
				Saved saved = new Saved();
				saved.mRestrictions.Add(mRestriction);
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
			MRestriction mRestriction = (MRestriction)model;
			if (saved.mRestrictions.Remove(mRestriction) == true)
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
			MRestriction mRestriction = (MRestriction)model;
			if (Check(mRestriction) == false)
			{
				int pos = saved.mRestrictions.IndexOf(mRestriction);
				saved.mRestrictions[pos].Coordinates = mRestriction.Coordinates;
				saved.mRestrictions[pos].Size = mRestriction.Size;
				return true;
			}
			else
				return false;
		}
	}
}
