using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductAPI.Models.Data;
using ProductAPI.Models.Domains;
using ProductAPI.Models.DTO;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly PracticeQaContext _dbContext;

        public ProductsController(PracticeQaContext dbcontext)
        {
            _dbContext = dbcontext;
        }


        [HttpGet]
        public IActionResult GetAllProducts()
        {
            // Get data from database (datamodel)
            var productsDomain = _dbContext.Products.ToList();

            //Map Domain models to DTOs
            var productsDTO = new List<ProductDto>();

            foreach (var product in productsDomain)
            {
                productsDTO.Add(new ProductDto()
                {
                    ProductID = product.Id,
                    ProductName = product.Name,
                    ProductCode = product.Code
                });
            }

            // Return DTOs
            return Ok(productsDTO);
        }


        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetSingleProduct([FromRoute] int id)
        {
            //Get Product Domain Model
            var productsDomain = _dbContext.Products.FirstOrDefault(x => x.Id == id);

            if (productsDomain is null)
            {
                return NotFound();
            }

            // Map Product Domain model to Product DTO
            var productsDTO = new List<ProductDto>();

            productsDTO.Add(new ProductDto()
            {
                ProductID = productsDomain.Id,
                ProductName = productsDomain.Name,
                ProductCode = productsDomain.Code
            });


            // Return DTOs
            return Ok(productsDTO);
        }

        [HttpPost]
        public IActionResult CreateProduct(AddProductRequestDto pDto)
        {
            // Map DTO to Domain Model
            var productDomainModel = new Product()
            {
                Name = pDto.ProductName,
                Code = pDto.ProductCode
            };

            // Use Domain Model to Product
            _dbContext.Products.Add(productDomainModel);
            _dbContext.SaveChanges();

            // Map domain model to DTO
            var productDTO = new ProductDto()
            {
                ProductID = productDomainModel.Id,
                ProductName = productDomainModel.Name,
                ProductCode = productDomainModel.Code
            };

            return Ok(productDTO);
            //return CreatedAtAction(nameof(GetSingleProduct), new { id = productDTO.ProductID }, productDTO);
        }


        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> UpdateProduct([FromRoute] int id, UpdateProductRequestDto uDto)
        {
            //Get Product Domain Model
            var productsDomain =  await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == id);

            if (productsDomain != null)
            {
                productsDomain.Name = uDto.ProductName;
                productsDomain.Code = uDto.ProductCode;

                await _dbContext.SaveChangesAsync();

                var productDTO = new ProductDto()
                {
                    ProductID = productsDomain.Id,
                    ProductName = productsDomain.Name,
                    ProductCode = productsDomain.Code
                };

                return Ok(productDTO);
               // return CreatedAtAction(nameof(GetById), new { id = productDTO.Id }, productDTO);
            }

            return NotFound();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] int id)
        {
            //Get Product Domain Model
            var productsDomain = await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == id);

            if (productsDomain != null)
            {
                _dbContext.Remove(productsDomain);
                await _dbContext.SaveChangesAsync();

                var productDTO = new ProductDto()
                {
                    ProductID = productsDomain.Id,
                    ProductName = productsDomain.Name,
                    ProductCode = productsDomain.Code
                };

                return Ok(productDTO);
                //return CreatedAtAction(nameof(GetById), new { id = productDTO.Id }, productDTO);
            }

            return NotFound();
        }

    }
}
