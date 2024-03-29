﻿using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface INhaCungCapService
    {
        public string Add(NhaCungCap obj);
        public string Update(NhaCungCap obj);
        public string Delete(NhaCungCap obj);
        public List<NhaCungCap> GetAll();
    }
}
