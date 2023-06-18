using Duzce.Models.DataBase;
using Microsoft.AspNetCore.Mvc;

namespace Duzce.ViewComponents.Admin
{
    public class Duyurular : ViewComponent
    {
        IDuyuruRepository _duyuruRepository;

        public Duyurular(IDuyuruRepository duyuruRepository)
        {
            _duyuruRepository = duyuruRepository;
        }

        public IViewComponentResult Invoke()
        {
            var result = _duyuruRepository.GetAll() ;
            return View(result);
        }
    }
}
