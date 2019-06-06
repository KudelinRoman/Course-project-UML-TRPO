using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCourseProject
{
	/// <summary>
	/// В этом классе храняться все листы для сохранения/изменения/удаления моделей
	/// </summary>
	public class Saved
	{
		public List<MComponent> mComponents = new List<MComponent>();
		public List<MDependence> mDependences = new List<MDependence>();
		public List<MInterface> mInterfaces = new List<MInterface>();
		public List<MLimitOfTwoElements> mLimitOfTwoElements = new List<MLimitOfTwoElements>();
		public List<MNote> mNotes = new List<MNote>();
		public List<MPackage> mPackages = new List<MPackage>();
		public List<MRestriction> mRestrictions = new List<MRestriction>();
		public List<MRestrictionOr> mRestrictionsOr = new List<MRestrictionOr>();
		public List<MUnit> mUnits = new List<MUnit>();
	}
}
