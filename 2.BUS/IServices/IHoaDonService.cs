﻿using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IHoaDonService
    {
        public string Add(EditHoaDonView obj);
        public string Update(EditHoaDonView obj);
        public string Delete(EditHoaDonView obj);
        public List<HoaDonView> GetAll();
        public EditHoaDonView GetEdit(Guid id);

    }
}
