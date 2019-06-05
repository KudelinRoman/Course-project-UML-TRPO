using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCourseProject
{
	/// <summary>
	/// В этом классе хранятся все экземпляры контроллеров.
	/// </summary>
	public static class Controllers
	{
		public static CComponent CComponent = new CComponent();
		public static CDependence CDependence = new CDependence();
		public static CInterface CInterface = new CInterface();
		public static CLimitOfTwoElements CLimitOfTwoElements = new CLimitOfTwoElements();
		public static CNote CNote = new CNote();
		public static CPackage CPackage = new CPackage();
		public static CRestriction CRestriction = new CRestriction();
		public static CRestrictionOr CRestrictionOr = new CRestrictionOr();
		public static CUnit CUnit = new CUnit();
	}
}
