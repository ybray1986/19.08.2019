using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using BusinessLayer.DataTransferObjects;
using _19._08._2019.ViewModel.Authors;

namespace _19._08._2019.Profiles
{
    public class WebProfile: Profile
    {
        public WebProfile()
        {
            this.CreateMap<AuthorsDTO, AuthorsViewModel>().ReverseMap().DisableCtorValidation();
        }
    }
}