using _19._08._2019.ViewModel.Authors;
using _19._08._2019.ViewModel.Books;
using AutoMapper;
using BusinessLayer.DataTransferObjects;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _19._08._2019.Infrastucture
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            this.CreateMap<Authors, AuthorsDTO>();
            this.CreateMap<AuthorsDTO, AuthorsViewModel>();
            this.CreateMap<AuthorsViewModel, AuthorsDTO>();
            this.CreateMap<AuthorsDTO, Authors>();

            this.CreateMap<Books, BooksDTO>();
            this.CreateMap<BooksDTO, BooksViewModel>();
            this.CreateMap<BooksViewModel, BooksDTO>();
            this.CreateMap<BooksDTO, Books>();

        }
    }
}