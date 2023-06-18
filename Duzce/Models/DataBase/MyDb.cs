using Duzce.Models.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Duzce.Models.DataBase
{
	public class MyDb:DbContext
	{
		public MyDb(DbContextOptions<MyDb> options) : base(options)
		{
		}


		public DbSet<Giris> Girisler { get; set; }
		public DbSet<Duyuru>  Duyurular { get; set; } 
		public DbSet<DuyuruTuru>  DuyuruTurleri { get; set; } 
	}
}
