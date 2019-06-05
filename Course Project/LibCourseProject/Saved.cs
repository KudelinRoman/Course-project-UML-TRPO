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
		public List<CComponent> cComponents = new List<CComponent>();
		public List<CDependence> cDependences = new List<CDependence>();
		public List<CInterface> cInterfaces = new List<CInterface>();
		public List<CLimitOfTwoElements> CLimitOfTwoElements = new List<CLimitOfTwoElements>();
		public List<CNote> cNotes = new List<CNote>();
		public List<CPackage> cPackages = new List<CPackage>();
		public List<CRestriction> cRestrictions = new List<CRestriction>();
		public List<CRestrictionOr> cRestrictionsOr = new List<CRestrictionOr>();
		public List<CUnit> cUnits = new List<CUnit>();
	}
}
