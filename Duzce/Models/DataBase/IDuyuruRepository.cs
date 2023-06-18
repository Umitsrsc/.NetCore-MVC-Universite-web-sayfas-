using Duzce.Models.Entitys;
using System.Collections.Generic;
using System.Linq;

namespace Duzce.Models.DataBase
{
    public interface IDuyuruRepository 
	{
		IQueryable<Duyuru> Duyurular { get; }

		void Add(Duyuru duyuru);
		void Update(Duyuru duyuru);
		void Delete(Duyuru duyuru);

		Duyuru GetById(int id);
		List<Duyuru> GetAll();

		List<Duyuru> GetDuyuruTuruWithDuyuru();

		Duyuru GetDuyuruDetailById(int id);

	}
}
