using DAL.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.DbContexts;
using Repository.Repository;

namespace Repository.Repositories
{
	public class ProvinceRepository
	{
		private readonly IRepository<DtoCity> _repositoryCity;
		private readonly IRepository<DtoDistrict> _repositoryDistrict;
		private readonly IRepository<DtoWard> _repositoryWard;
		private readonly VNVCContext _dbContext;

		public ProvinceRepository(
			IRepository<DtoCity> repositoryCity,
			IRepository<DtoDistrict> repositoryDistrict,
			IRepository<DtoWard> repositoryWard,
			VNVCContext dbContext)
		{
			_repositoryCity = repositoryCity;
			_repositoryDistrict = repositoryDistrict;
			_repositoryWard = repositoryWard;
			_dbContext = dbContext;
		}

		//public List<DtoCity> GetAllCities()
		//{
		//	var cities = from c in _dbContext.Cities
		//				 where !c.IsDeleted
		//				 select c;
		//	return cities.ToList();
		//}

		//public DtoCity GetCity(string idCity)
		//{
		//	var city = (from c in _dbContext.Cities
		//				where !c.IsDeleted && c.Id == idCity
		//				select c).Include(_ => _.Districts).FirstOrDefault();
		//	return city;
		//}

		//public List<DtoDistrict> GetAllDictrictsByCity(string idCity)
		//{
		//	var districts = from d in _dbContext.Districts
		//					where !d.IsDeleted && d.IdCity == idCity
		//					select d;
		//	return districts.ToList();
		//}

		//public DtoDistrict GetDistrict(string idDistrict)
		//{
		//	var district = (from d in _dbContext.Districts
		//					where !d.IsDeleted && d.Id == idDistrict
		//					select d).Include(_ => _.Wards).FirstOrDefault();
		//	return district;
		//}

		//public List<DtoWard> GetAllWardsByDistrict(string idDistrict)
		//{
		//	var wards = from w in _dbContext.Wards
		//				where !w.IsDeleted && w.IdDistrict == idDistrict
		//				select w;
		//	return wards.ToList();
		//}

		//public DtoWard GetWard(string idWard)
		//{
		//	var ward = (from w in _dbContext.Wards
		//				where !w.IsDeleted && w.Id == idWard
		//				select w).FirstOrDefault();
		//	return ward;
		//}

		//public string GetFullAddress(string idWard)
		//{
		//	var ward = (from w in _dbContext.Wards
		//				join d in _dbContext.Districts on w.IdDistrict equals d.Id
		//				join c in _dbContext.Cities on d.IdCity equals c.Id
		//				where w.Id == idWard && !w.IsDeleted
		//				select w).Include(x => x.District).ThenInclude(y => y.City).FirstOrDefault();
		//	if (ward == null)
		//	{
		//		throw new Exception("Not exist ward");
		//	}
		//	var fullAddress = "Phường " + ward.NameWard + ", " + ward.District.NameDistrict + ", " + ward.District.City.NameCity;
		//	return fullAddress;
		//}
	}
}