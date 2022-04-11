using System.Collections.Generic;
using System.Linq;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.services
{
    public class LoaiRepository : ILoaiRepository
    {
        private readonly MyDbContext _context;
            
        public LoaiRepository(MyDbContext context)
        {
            _context = context;
        }
        public LoaiVM Add(LoaiModels models)
        {
            var _loai = new Loai
            {
                Name = models.Name,
            };
            _context.Add(_loai);
            _context.SaveChanges();
            return new LoaiVM
            {
                Id = _loai.Id,
                Name = models.Name
            };
        }

        public void Delete(int id)
        {
            var loai = _context.Loais.SingleOrDefault(lo => lo.Id == id);
            if(loai != null)
            {
                _context.Remove(loai);
                _context.SaveChanges();
            }
        }

        public List<LoaiVM> GetAll()
        {
            var loais = _context.Loais.Select(lo => new LoaiVM
            {
                Id = lo.Id,
                Name = lo.Name,
            });
            return loais.ToList();
        }

        public LoaiVM GetById(int id)
        {
            var loai = _context.Loais.SingleOrDefault(lo => lo.Id == id);
            if(loai != null)
            {
                return new LoaiVM
                {
                    Id=loai.Id,
                    Name=loai.Name,
                };
            }
            return null;
        }

        public void Update(LoaiVM loai)
        {
            var _loai = _context.Loais.SingleOrDefault(lo => lo.Id == loai.Id);
            _loai.Name = loai.Name;
            _context.SaveChanges();
        }
    }
}
