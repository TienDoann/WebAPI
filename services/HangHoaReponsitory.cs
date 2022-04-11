using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.services
{
    public class HangHoaReponsitory : IHangHoaReponsitory
    {
        private readonly MyDbContext _context;

        public HangHoaReponsitory(MyDbContext context)
        {
            _context = context;
        }

        public HangHoaModel Add(HangHoaModel HH)
        {
            var _hanghoa = new HangHoa
            {
                MaHH = HH.MaHH,
                TenHH = HH.TenHH,
                DonGia = HH.DonGia,
                GiamGia = HH.GiamGia,
                LoaiMonAn = HH.LoaiMonAn
            };
            _context.Add(_hanghoa);
            _context.SaveChanges();
            return new HangHoaModel
            {
                MaHH = HH.MaHH,
                TenHH = HH.TenHH,
                DonGia = HH.DonGia,
                GiamGia = HH.GiamGia,
                LoaiMonAn = HH.LoaiMonAn
            };
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<HangHoaModel> GetAll(string search, double? from, double? to)
        {
            var product = _context.HangHoas.AsQueryable();
            if (!string.IsNullOrEmpty(search))
            {
                product = product.Where(hh => hh.TenHH.Contains(search));
            }
            if (from.HasValue)
            {
                product = product.Where(hh => hh.DonGia >= from);
            }
            if (to.HasValue)
            {
                product = product.Where(hh => hh.DonGia <= to);
            }
            var result = product.Select(h => new HangHoaModel
            {
                MaHH = h.MaHH,
                TenHH= h.TenHH,
                DonGia= h.DonGia,
                GiamGia= h.GiamGia,
                //Name= h.Loai.Name
               
            });
            return result.ToList();
        }

        public HangHoaModel Search(Guid search)
        {
            throw new NotImplementedException();
        }

        public void Update(HangHoaModel HH)
        {
            throw new NotImplementedException();
        }
    }
}
