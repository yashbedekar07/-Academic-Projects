using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CustomerApi.Models.Data;
using CustomerApi.Models.Domains;
using CustomerApi.Models.DTO;
using System.Net;
using System.Numerics;

namespace CustomerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController(CrudDbContext dbContext) : ControllerBase
    {
        private readonly CrudDbContext _dbContext = dbContext;

        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            // Get data from database (datamodel)
            var customerDomain = _dbContext.Customers.ToList();

            //Map Domain models to DTOs
            var customerDTO = new List<CustomerDto>();

            foreach (var customer in customerDomain)
            {
                customerDTO.Add(new CustomerDto()
                {
                    CustomerId = customer.CustomerId,
                    CustomerName = customer.CustomerName,
                    CustomerAge = customer.Age,
                    CustomerEmail = customer.Email,
                    CustomerPhone = customer.Phone,
                    CustomerAddress = customer.Address,
                    //DateOfBirth = customer.DateOfBirth,
                    City = customer.City,
                    State = customer.State,
                });
            }

            // Return DTOs
            return Ok(customerDTO);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetSingleCustomers([FromRoute] int id)
        {
            //Get customer Domain Model
            var customerDomain = _dbContext.Customers.FirstOrDefault(x => x.CustomerId == id);

            if (customerDomain is null)
            {
                return NotFound();
            }

            // Map customer Domain model to customer DTO
            var customerDTO = new List<CustomerDto>
            {
                new CustomerDto()
                {
                    CustomerId = customerDomain.CustomerId,
                    CustomerName = customerDomain.CustomerName,
                    CustomerAge = customerDomain.Age,
                    CustomerEmail = customerDomain.Email,
                    CustomerPhone = customerDomain.Phone,
                    CustomerAddress = customerDomain.Address,
                    // DateOfBirth = customerDomain.DateOfBirth,
                    City = customerDomain.City,
                    State = customerDomain.State,
                }
            };


            // Return DTOs
            return Ok(customerDTO);
        }

        [HttpPost]
        public IActionResult CreatecCustomer(AddCustomerRequestDto CDto)
        {
            // Map DTO to Domain Model
            var customerDomainModel = new Customer()
            {
                CustomerName = CDto.CustomerName,
                Age = CDto.CustomerAge,
                Email = CDto.CustomerEmail,
                Phone = CDto.CustomerPhone,
                Address = CDto.CustomerAddress,
               // DateOfBirth = CDto.DateOfBirth,
                City = CDto.City,
                State = CDto.State,
            };

            // Use Domain Model to Customer
            _dbContext.Customers.Add(customerDomainModel);
            _dbContext.SaveChanges();

            // Map domain model to DTO
            var customerDTO = new CustomerDto()
            {
                CustomerId = customerDomainModel.CustomerId,
                CustomerName = customerDomainModel.CustomerName,
                CustomerAge = customerDomainModel.Age,
                CustomerEmail = customerDomainModel.Email,
                CustomerPhone = customerDomainModel.Phone,
                CustomerAddress = customerDomainModel.Address,
               // DateOfBirth = customerDomainModel.DateOfBirth,
                City = customerDomainModel.City,
                State = customerDomainModel.State,
            };

            return Ok(customerDTO);
            //return CreatedAtAction(nameof(GetSingleCustomer), new { id = customerDTO.CustomerId }, customerDTO);
        }


        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> UpdateCustomers([FromRoute] int id, UpdateCustomerRequestDto uDto)
        {
            //Get Customer Domain Model
            var customerDomain = await _dbContext.Customers.FirstOrDefaultAsync(x => x.CustomerId == id);

            if (customerDomain != null)
            {
                customerDomain.CustomerName = uDto.CustomerName;
                customerDomain.Email = uDto.CustomerEmail;
                customerDomain.Age = uDto.CustomerAge;
                customerDomain.Phone = uDto.CustomerPhone;
                customerDomain.Address = uDto.CustomerAddress;
               // customerDomain.DateOfBirth = uDto.DateOfBirth;
                customerDomain.City = uDto.City;
                customerDomain.State = uDto.State;

                await _dbContext.SaveChangesAsync();

                var customerDTO = new CustomerDto()
                {
                    CustomerId = customerDomain.CustomerId,
                    CustomerName = customerDomain.CustomerName,
                    CustomerAge = customerDomain.Age,
                    CustomerEmail = customerDomain.Email,
                    CustomerPhone = customerDomain.Phone,
                    CustomerAddress = customerDomain.Address,
                   // DateOfBirth = customerDomain.DateOfBirth,
                    City = customerDomain.City,
                    State = customerDomain.State,
                };

                return Ok(customerDTO);
                // return CreatedAtAction(nameof(GetById), new { id = customerDTO.Id }, customerDTO);
            }

            return NotFound();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteCustomer([FromRoute] int id)
        {
            //Get Product Domain Model
            var customerDomain = await _dbContext.Customers.FirstOrDefaultAsync(x => x.CustomerId == id);

            if (customerDomain != null)
            {
                _dbContext.Remove(customerDomain);
                await _dbContext.SaveChangesAsync();

                var customerDTO = new CustomerDto()
                {
                    CustomerId = customerDomain.CustomerId,
                    CustomerName = customerDomain.CustomerName,
                    CustomerAge = customerDomain.Age,
                    CustomerEmail = customerDomain.Email,
                    CustomerPhone = customerDomain.Phone,
                    CustomerAddress = customerDomain.Address,
                   // DateOfBirth = customerDomain.DateOfBirth,
                    City = customerDomain.City,
                    State = customerDomain.State,
                };

                return Ok(customerDTO);
                //return CreatedAtAction(nameof(GetById), new { id = CustomerDto.CustomerId }, customerDTO);
            }

            return NotFound();
        }

    }
}
