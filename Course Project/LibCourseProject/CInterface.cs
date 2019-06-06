using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCourseProject
{
	public class CInterface
	{
		public CInterface() : base()
		{

		}
		private bool Check(MInterface mInterface)
		{
			Saved saved = new Saved();
			if (saved.mInterfaces.IndexOf(mInterface) > 0)
				return false;
			return true;
		}
		/// <summary>
		/// Метод Добавления
		/// </summary>
		public bool Insert(Model model)
		{
			MInterface mInterface = (MInterface)model;
			if (Check(mInterface) == true)
			{
				Saved saved = new Saved();
				saved.mInterfaces.Add(mInterface);
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
			MInterface mInterface = (MInterface)model;
			if (saved.mInterfaces.Remove(mInterface) == true)
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
			MInterface mInterface = (MInterface)model;
			if (Check(mInterface) == false)
			{
				int pos = saved.mInterfaces.IndexOf(mInterface);
				saved.mInterfaces[pos].Coordinates = mInterface.Coordinates;
				saved.mInterfaces[pos].Size = mInterface.Size;
				return true;
			}
			else
				return false;
		}
	}
}
