using System.Collections.Generic;

namespace Duzce.Models.Entitys
{
    public class DuyuruTuru
	{
		public DuyuruTuru()
		{
			Duyurular = new List<Duyuru>();
		}

		public int Id { get; set; }
		public string Adi { get; set; }
		public virtual List<Duyuru> Duyurular { get; set; }

	}
}
