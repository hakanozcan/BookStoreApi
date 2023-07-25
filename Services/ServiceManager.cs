using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Entities.Data_Transfer_Objects;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly IBookService _bookService;
        private readonly ICategoryService _categoryService;
        private readonly IAuthenticationService _authenticationService;


        public ServiceManager(IBookService bookService, ICategoryService categoryService, IAuthenticationService authenticationService)
        {
            _bookService = bookService;
            _categoryService = categoryService;
            _authenticationService = authenticationService;
        }

        public ICategoryService CategoryService => _categoryService;
        public IBookService BookService => _bookService;
        public IAuthenticationService AuthenticationService => _authenticationService;
    }
}