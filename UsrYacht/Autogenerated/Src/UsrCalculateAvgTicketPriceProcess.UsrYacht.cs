namespace Terrasoft.Core.Process
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: UsrCalculateAvgTicketPriceProcessMethodsWrapper

	/// <exclude/>
	public class UsrCalculateAvgTicketPriceProcessMethodsWrapper : ProcessModel
	{

		public UsrCalculateAvgTicketPriceProcessMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("ScriptTask1Execute", ScriptTask1Execute);
		}

		#region Methods: Private

		private bool ScriptTask1Execute(ProcessExecutingContext context) {
			// IMPORTANT: When implementing
			// long-running operations,
			// it is crucial to enable timely and
			// responsive cancellation. To achieve
			// this, ensure that your code
			// is designed to respond appropriately
			// to cancellation requests using
			// the context.CancellationToken
			// mechanism. For more detailed
			// information and examples,
			// please, refer to our documentation.
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "UsrYacht");
			var passengersCountColumn = esq.AddColumn("UsrPassengersCount");  // SELECT UsrPassengerCount as UsrPassengerCount, UsrPrice as UsrPrice FROM UsrYacht WHERE ...
			var priceColumn = esq.AddColumn("UsrPrice");
			
			Guid driveTypeId = Get<Guid>("DriveTypeIdParameter");
			
			var typeFilter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "UsrDriveType", driveTypeId);
			esq.Filters.Add(typeFilter); // ... WHERE UsrDriveTypeId = :driveTypeId
			
			string sqlText = esq.GetSelectQuery(UserConnection).GetSqlText();
			Set("SqlTextParameter", sqlText);
			
			var entityCollection = esq.GetEntityCollection(UserConnection);
			decimal sumTicketPrices = 0;
			int count = entityCollection.Count;
			foreach(var entity in entityCollection) {
				int passengersCount = entity.GetTypedColumnValue<int>(passengersCountColumn.Name); // reading using column alias
				decimal price = entity.GetTypedColumnValue<decimal>(priceColumn.Name); // reading using column alias
				decimal ticketPrice = price / passengersCount;
				sumTicketPrices = sumTicketPrices + ticketPrice;
			}
			
			decimal result = 0;
			if (count > 0) {
				result = sumTicketPrices / count;
			}
			Set("AvgTicketPriceParameter", result);
			return true;
		}

		#endregion

	}

	#endregion

}

