using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLayer.DataTransferObjects;
using DataLayer.Entities;

namespace BusinessLayer.Profiles
{
    public class BLProfile: Profile
    {
        public BLProfile()
        {
            this.CreateMap<Authors, AuthorsDTO>().ReverseMap();
        }
    }
}
