﻿using CRUD.Actions.Implementation;
using Microsoft.AspNetCore.Mvc;
using MobileParts.Common.Models;

namespace MobilePartsStore.Api.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class CategoriesController : BaseCrudController<Category, int>
    {
        public CategoriesController(BaseCrudRepository<Category, int> repository) : base(repository)
        {
        }
    }
}