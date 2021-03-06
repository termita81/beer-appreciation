﻿namespace BeerAppreciation.Beverage.API.Controllers
{
    using Core.WebApi.Controllers;
    using Domain;
    using global::Core.Shared.Data.Services;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    [Route("api/v1/[controller]")]
    public class ManufacturersController : EntityController<Manufacturer, int>
    {
        public ManufacturersController(IEntityService<Manufacturer, int> entityService, ILogger<EntityController<Manufacturer, int>> logger) : base(entityService, logger)
        {
        }
    }
}