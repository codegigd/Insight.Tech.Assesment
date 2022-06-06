using AutoMapper;
using Insight.Product.WebApi.DBModel;
using Insight.Product.WebApi.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Insight.Product.WebApi.Controllers
{
    [Route("insight/productmgmt")]
    [ApiVersion("1.0")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        private readonly Insightsql01Context _context;

        private readonly IMapper _mapper;

        public ProductController(ILogger<ProductController> logger, Insightsql01Context context, IMapper mapper)
        {
            _logger = logger;
            _context = context;
            _mapper = mapper;
                
        }

        /// <summary>
        /// To View Product List
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        [Route("productdetails", Name ="ProductDetails")]
        public List<ProductModel> GetProductDetails()
        {
            var products = _context.Products;
            List<ProductModel> productDetails = _mapper.Map<List<ProductModel>>(products);
            return productDetails;
        }
    }
}
