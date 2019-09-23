﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLayer.DataTransferObjects;
using DataLayer.Entities;
using _19._08._2019.ViewModel.Authors;

namespace BusinessLayer.Profiles
{
    public class BLProfile: Profile
    {
        public BLProfile()
        {
            this.CreateMap<Authors, LibraryDTO>().ReverseMap();
            this.CreateMap<AuthorsDTO, AuthorsViewModel>().ReverseMap();
        }
    }
}
