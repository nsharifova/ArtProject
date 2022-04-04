using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PageService
    {
        private readonly ArtDbContext _context;

        public PageService(ArtDbContext context)
        {
            _context = context;
        }
        public void Add(Page2 newItem)
        {
            _context.Add(newItem);
            _context.SaveChanges();
        }

        public void Update(Page2 newPage2)
        {
            _context.Update(newPage2);
            _context.SaveChanges();
        }
        public List<Page2> GetAll()
        {
            return _context.Pages2.Where(c=>!c.IsDeleted).ToList();
        }
        public Page2? GetById(int id)
        {
            return _context.Pages2.FirstOrDefault(c=>c.Id==id);
        }
        public void Delete(int id)
        {
            var selectedPage = _context.Pages2.Find(id);
         selectedPage.IsDeleted=true;
            _context.SaveChanges();
        }

     

    }
}
