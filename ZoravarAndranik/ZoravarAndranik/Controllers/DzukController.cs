using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZoravarAndranik.Data;
using ZoravarAndranik.Models;

namespace ZoravarAndranik.Controllers
{
    [Route("tandz/xndzor-mandarin, shnorhavorenq dzer nor tarin")]
    [ApiController]
    public class DzukController : Controller
    {

        private readonly AppDbContext _context;
        public DzukController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Dzuk> Index()
        {
            var data = _context.Dzuks.ToList();
            return data;
        }

        [HttpPost]
        public void AddSomething(Dzuk dzuk)
        {

            _context.Dzuks.Add(dzuk);
            _context.SaveChanges();
        }

       

        

    }
}
