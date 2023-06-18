using Duzce.Models.Entitys;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Duzce.Models.DataBase
{
	public class EfGirisRepository : IGirisRepository 
	{
		MyDb _myDb;

		public EfGirisRepository(MyDb myDb)
		{
			_myDb = myDb;
		}

		public IQueryable<Giris> Girisler => _myDb.Girisler;


		public void CreateGiris(Giris giris)
		{
			_myDb.Set<Giris>().Add(giris);
			_myDb.SaveChanges();
			
		}

		public void DeleteGiris(int id)
		{
			var result= _myDb.Girisler.Find(id);
			_myDb.Girisler.Remove(result);
			_myDb.SaveChanges();


		}

		public Giris GetById(Giris giris)
		{
			var result = _myDb.Girisler.Where(c => c.Adi == giris.Adi && c.Sifre == giris.Sifre).SingleOrDefault();

			if (result!=null)
			{
				return result;

			}

			return null;
		}

		public IEnumerable<Giris> GetGiris()
		{
			throw new System.NotImplementedException();
		}

		public void UpdateGiris(Giris giris)
		{
			_myDb.Girisler.Update(giris);
			_myDb.SaveChanges();
		}
	}

	public class EfDuyuruRepository : IDuyuruRepository
	{
		MyDb _myDb;

		public EfDuyuruRepository(MyDb myDb)
		{
			_myDb = myDb;
		}

		public IQueryable<Duyuru> Duyurular => _myDb.Duyurular;

		public void Add(Duyuru duyuru)
		{
			_myDb.Set<Duyuru>().Add(duyuru);
			_myDb.SaveChanges();
		}

		public void Delete(Duyuru duyuru)
		{
			_myDb.Duyurular.Remove(duyuru);
			_myDb.SaveChanges();
		}

		public List<Duyuru> GetAll()
		{
			return _myDb.Duyurular.ToList();
		}

		public Duyuru GetById(int id)
		{
			return _myDb.Duyurular.Where(c => c.Id == id).FirstOrDefault();
		}

		public Duyuru GetDuyuruDetailById(int id)
		{
			return _myDb.Duyurular.Where(c => c.Id == id).FirstOrDefault();
		}

		public List<Duyuru> GetDuyuruTuruWithDuyuru()
		{
			throw new System.NotImplementedException();
		}

		public void Update(Duyuru duyuru)
		{
			_myDb.Duyurular.Update(duyuru);
			_myDb.SaveChanges();
		}
	}
		
}
