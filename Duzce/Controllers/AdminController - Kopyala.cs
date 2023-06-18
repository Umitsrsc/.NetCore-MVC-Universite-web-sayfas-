using Duzce.Models.DataBase;
using Duzce.Models.Entitys;
using Microsoft.AspNetCore.Mvc;

namespace Duzce.Controllers
{
	public class AdminController : Controller
	{
		IGirisRepository _girisRepository;
		IDuyuruRepository _duyuruRepository; 
		public AdminController(IGirisRepository girisRepository, IDuyuruRepository duyuruRepository)
		{
			_girisRepository = girisRepository;
			_duyuruRepository = duyuruRepository;
		}

		public IActionResult Index()
		{
			var result=_duyuruRepository.GetAll();
			return View(result);
		}

		[HttpGet]
		public IActionResult Kayit()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Kayit(Giris giris)  
		{
			_girisRepository.CreateGiris(giris);
			return View("giris");
		}

		public IActionResult Giris()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Giris(Giris giris)
		{
			var result = _girisRepository.GetById(giris);

			if (result == null)
			{
				return View();
			}
			return View("Index", result);

		}

		//*************************************************************

		[HttpGet]
		public IActionResult DuyuruEkle()
		{

			return View();
		}
		[HttpPost]
		public IActionResult DuyuruEkle(Duyuru duyuru)
		{

			_duyuruRepository.Add(duyuru);

			return View(duyuru);
		}

		[HttpGet]
		public IActionResult GetDuyuruDetailById(int id)
		{
			var result = _duyuruRepository.GetDuyuruDetailById(id);
			
			return View(result);
		}

		[HttpGet]
		public IActionResult DuyuruSil(int id)
		{

			_duyuruRepository.Delete(_duyuruRepository.GetDuyuruDetailById(id));



			return View("DuyuruEkle");

		}

	



		[HttpGet]
		public IActionResult DuyuruGuncelle(int id)
		{
			return View(_duyuruRepository.GetDuyuruDetailById(id));

		}

		[HttpPost]
		public IActionResult DuyuruGuncelle(Duyuru duyuru)
		{
			_duyuruRepository.Update(duyuru);

			return View();
		}








	}
}
