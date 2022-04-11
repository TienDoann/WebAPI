using System;
using System.Collections.Generic;
using WebAPI.Models;

namespace WebAPI.services
{
    public interface IHangHoaReponsitory
    {
        List<HangHoaModel> GetAll(string search, double? from, double? to);
        HangHoaModel Search(Guid search);
        HangHoaModel Add(HangHoaModel HH);
        void Delete(int id);
        void Update(HangHoaModel HH);
    }
}
