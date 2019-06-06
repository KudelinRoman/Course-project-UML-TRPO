using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCourseProject
{
	public class CRestrictionOr
	{
		public CRestrictionOr():base()
		{

		}
		private bool Check(MRestrictionOr mRestrictionOr)
		{
			Saved saved = new Saved();
			if (saved.mRestrictionsOr.IndexOf(mRestrictionOr) > 0)
				return false;
			return true;
		}
		/// <summary>
		/// Метод Добавления
		/// </summary>
		public bool Insert(Model model)
		{
			MRestrictionOr mRestrictionOr = (MRestrictionOr)model;
			if (Check(mRestrictionOr) == true)
			{
				Saved saved = new Saved();
				saved.mRestrictionsOr.Add(mRestrictionOr);
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
			MRestrictionOr mRestrictionOr = (MRestrictionOr)model;
			if (saved.mRestrictionsOr.Remove(mRestrictionOr) == true)
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
			MRestrictionOr mRestrictionOr = (MRestrictionOr)model;
			if (Check(mRestrictionOr) == false)
			{
				int pos = saved.mRestrictionsOr.IndexOf(mRestrictionOr);
				saved.mRestrictionsOr[pos].Coordinates = mRestrictionOr.Coordinates;
				saved.mRestrictionsOr[pos].Size = mRestrictionOr.Size;
				return true;
			}
			else
				return false;
		}
	}
}
