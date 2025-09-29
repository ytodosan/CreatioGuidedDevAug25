namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrYachtEventsSchema

	/// <exclude/>
	public class UsrYachtEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrYachtEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrYachtEventsSchema(UsrYachtEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("039963af-8453-4799-bee3-a994fdd9f3e6");
			Name = "UsrYachtEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4b72368a-0e03-4ce7-b013-a7f94b8b1864");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,223,107,219,48,16,199,223,11,253,31,14,63,217,16,68,247,186,110,133,37,164,163,80,182,209,56,131,50,246,160,200,23,71,67,63,140,78,78,151,141,254,239,59,89,73,155,58,29,244,94,108,157,190,250,220,125,143,115,210,34,117,82,33,212,24,130,36,191,142,98,230,221,90,183,125,144,81,123,119,126,246,247,252,12,56,122,210,174,133,197,142,34,218,203,227,212,241,67,107,189,251,239,101,64,49,119,81,71,141,244,22,141,152,111,209,197,131,244,199,144,222,13,185,91,205,77,56,12,229,66,109,208,202,47,236,1,62,66,177,164,112,47,213,38,22,213,207,252,166,235,87,70,43,80,70,18,193,112,245,10,4,222,195,84,18,190,114,147,33,123,251,71,60,191,229,134,117,131,176,245,186,129,175,110,33,183,108,163,244,171,95,168,34,16,186,6,195,4,50,112,138,107,246,52,96,63,133,150,0,171,103,220,17,57,197,138,187,16,79,180,3,6,171,203,151,178,204,133,93,178,195,174,203,124,174,178,126,164,109,80,105,43,13,116,65,171,52,162,225,145,248,140,177,222,117,216,204,188,233,173,251,46,77,143,31,246,202,171,50,77,241,91,146,23,227,194,122,13,101,6,93,193,187,139,20,213,75,193,200,79,10,20,55,52,147,78,161,193,134,235,199,208,35,83,79,117,20,67,218,4,222,69,146,45,214,104,59,35,99,234,216,225,3,220,122,37,141,254,35,87,6,23,131,174,204,62,150,132,129,119,213,241,212,121,81,197,29,146,239,131,98,141,15,12,153,156,86,73,241,180,37,121,187,138,9,20,39,124,18,195,80,110,168,246,126,170,219,124,42,42,81,251,125,253,234,13,38,184,249,156,16,215,62,88,25,203,145,57,46,204,83,4,30,35,204,151,119,39,211,78,17,55,193,63,12,35,152,255,86,216,37,151,7,202,88,254,248,124,220,255,242,231,241,31,116,118,32,161,222,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("282b757b-850b-172b-996f-9ad124183c24"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("4b72368a-0e03-4ce7-b013-a7f94b8b1864"),
				CreatedInSchemaUId = new Guid("039963af-8453-4799-bee3-a994fdd9f3e6"),
				ModifiedInSchemaUId = new Guid("039963af-8453-4799-bee3-a994fdd9f3e6")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("039963af-8453-4799-bee3-a994fdd9f3e6"));
		}

		#endregion

	}

	#endregion

}

