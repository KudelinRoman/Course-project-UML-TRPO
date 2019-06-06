using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCourseProject
{
	public class CComponent
	{
		public CComponent () : base()
		{

		}

		private bool Check (MComponent mComponent)
		{
			Saved saved = new Saved();
			if (saved.mComponents.IndexOf(mComponent) > 0)
				return false;
			return true;
		}
		/// <summary>
		/// Метод Добавления
		/// </summary>
		public bool Insert(Model model)
		{
			MComponent mComponent = (MComponent)model;
			if (Check(mComponent)== true)
			{
				Saved saved = new Saved();
				saved.mComponents.Add(mComponent);
				return true;
			}
			else
				return false;
		}
		/// <summary>
		/// Метод удаления
		/// </summary>
		public bool Delete (Model model)
		{
			Saved saved = new Saved();
			MComponent mComponent = (MComponent)model;
			if (saved.mComponents.Remove(mComponent)==true)
			{
				return true;
			}
			else
				return false;
		}
		/// <summary>
		/// Метод изменения
		/// </summary>
		public bool Update (Model model)
		{
			Saved saved = new Saved();
			MComponent mComponent = (MComponent)model;
			if (Check(mComponent) == false)
			{
				int pos = saved.mComponents.IndexOf(mComponent);
				saved.mComponents[pos].Coordinates = mComponent.Coordinates;
				saved.mComponents[pos].Size = mComponent.Size;
				return true;
			}
			else
				return false;
		}
	}
}
