using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GlobalHRMSApi.Repositories;
using GlobalHRMSApi.Models;
using System.Data.Entity.Core.Objects;

namespace GlobalHRMSApi.BLL
{
	public class LookupLogic
	{
		HRMSManagementEntities hrmsEntities = new HRMSManagementEntities();

		public List<City> GetCities(int? stateId, int? id)
		{
			List<City> retCitiesList = null;
			ObjectResult<GetCities_Result> citiesList = hrmsEntities.GetCities(id, stateId);
			if (citiesList != null)
			{
				retCitiesList = citiesList.ToList().Select(x => new City()
				{
					ID = x.ID,
					Name = x.Name,
					StateId = x.StateId,
					IsActive = x.IsActive
				}).ToList();
			}
			return retCitiesList;
		}
	}
}