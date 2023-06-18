using System.Collections.Generic;
using System.Linq;

namespace Duzce.Models.DataBase
{
	public interface IGirisRepository   
	{
		 IQueryable<Giris> Girisler { get; }

		Giris GetById(Giris giris);
		IEnumerable<Giris> GetGiris();
		void DeleteGiris(int id); 
		void CreateGiris(Giris giris); 
		void UpdateGiris(Giris giris); 
		
	}
}
