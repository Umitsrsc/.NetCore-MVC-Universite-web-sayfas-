using System;

namespace Duzce.Models.Entitys
{
	public class Duyuru
	{
		public int Id { get; set; }
		public int DuyuruTuruId { get; set; }
		public string Baslık { get; set; }
		public string Icerik { get; set; }
		public DateTime Tarih { get; set; }
		public string Resim { get; set; }
		public bool Durum { get; set; }



		public virtual DuyuruTuru DuyuruTuru { get; set; }



	}
}
