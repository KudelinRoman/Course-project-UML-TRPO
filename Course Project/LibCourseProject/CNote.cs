using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCourseProject
{
	public class CNote
	{
		public CNote():base()
		{

		}
		private bool Check(MNote mNote)
		{
			Saved saved = new Saved();
			if (saved.mNotes.IndexOf(mNote) > 0)
				return false;
			return true;
		}
		/// <summary>
		/// Метод Добавления
		/// </summary>
		public bool Insert(Model model)
		{
			MNote mNote = (MNote)model;
			if (Check(mNote) == true)
			{
				Saved saved = new Saved();
				saved.mNotes.Add(mNote);
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
			MNote mNote = (MNote)model;
			if (saved.mNotes.Remove(mNote) == true)
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
			MNote mNote = (MNote)model;
			if (Check(mNote) == false)
			{
				int pos = saved.mNotes.IndexOf(mNote);
				saved.mNotes[pos].Coordinates = mNote.Coordinates;
				saved.mNotes[pos].Size = mNote.Size;
				return true;
			}
			else
				return false;
		}
	}
}
