using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SneakerSeeker3.Data;
using SneakerSeeker3.Models;

namespace SneakerSeeker3.Api
{
    [Route("api/[controller]/[action]/{id?}")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductApiController(ApplicationDbContext context)
        {
            _context = context;
        }


        #region GET Method
        /**
         * This is get method and method name is GetAllProducts. 
         * Here we get following column value from database. Here we write LINQ join query becasue we get data from Product, Category, Supplier ItemSize and ItemColor tables.
         * https://localhost:44351/api/ProductApi/GetAllProducts
         **/
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var result = (from p in _context.Product
                          join c in _context.Category on p.CategoryId equals c.CategoryId
                          join s in _context.Supplier on p.SupplierId equals s.SupplierId
                          join i in _context.ItemColor on p.ItemColorId equals i.ItemColorId
                          join d in _context.ItemSize on p.size.ItemSizeId equals d.ItemSizeId
                          select new
                          {
                              ProductId = p.ProductId,
                              SKU = p.SKU,
                              ProductName = p.ProductName,
                              ProductDescription = p.ProductDescription,
                              UnitPrice = p.UnitPrice,
                              ProductURL = p.ProductURL,
                              CategoryName = c.CategoryName,
                              Description = c.Description,
                              CompanyName = s.CompanyName,
                              ItemSizeId = d.ItemSizeId,
                              Color = i.Color
                          }).ToList();

            if (result == null || result.Count == 0)
            {
                return NotFound("No Row Found");
            }
            else
            {
                return Ok(result);
            }
        }
        #endregion


        #region GET Method
        /**
         * This is get method and method name is GetAllProductsById. Here we have to pass Product id as a parameter.
         * If we want to get particular 1 product record then just need to GetAllProductsById/id
         * Here we get following column value from database
         * https://localhost:44351/api/ProductApi/GetAllProductsById/1
         **/
        [HttpGet]
        public IActionResult GetAllProductsById(int id)
        {
            var result = (from p in _context.Product
                          join c in _context.Category on p.CategoryId equals c.CategoryId
                          join s in _context.Supplier on p.SupplierId equals s.SupplierId
                          join i in _context.ItemColor on p.ItemColorId equals i.ItemColorId
                          join d in _context.ItemSize on p.size.ItemSizeId equals d.ItemSizeId
                          where p.ProductId == id
                          select new
                          {
                              ProductId = p.ProductId,
                              SKU = p.SKU,
                              ProductName = p.ProductName,
                              ProductDescription = p.ProductDescription,
                              UnitPrice = p.UnitPrice,
                              ProductURL = p.ProductURL,
                              CategoryName = c.CategoryName,
                              Description = c.Description,
                              CompanyName = s.CompanyName,
                              ItemSizeId = d.ItemSizeId,
                              Color = i.Color
                          }).ToList();

            if (result == null || result.Count == 0)
            {
                return NotFound("Product with Id " + id.ToString() + " Not Found");
            }
            else
            {

                return Ok(new
                {
                    value = result
                });
            }
        }
        #endregion


        #region POST Method
        /**
         * This is post method and method name is InsertProduct
         * https://localhost:44351/api/ProductApi/InsertProduct
         * We also need to pass all the required value in json format
         **/
        [HttpPost]
        public IActionResult InsertProduct([FromBody]Product product)
        {
            try
            {
                if (product != null)
                {
                    _context.Product.Add(product);
                    _context.SaveChanges();

                    var message = StatusCode(201, product);
                    return message;
                }
                else
                {
                    return BadRequest("Something wrong!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        #endregion


        #region PUT/UPDATE Method
        /**
         * This is put/update method and method name is UpdateProduct
         * https://localhost:44351/api/ProductApi/UpdateProduct
         **/
        [HttpPut]
        public IActionResult UpdateProduct([FromBody]Product product, int id)
        {
            try
            {
                if (id == product.ProductId)
                {
                    var item = _context.Product.Where(s => s.ProductId == id).FirstOrDefault();
                    item.SKU = product.SKU;
                    item.ProductName = product.ProductName;
                    item.ProductDescription = product.ProductDescription;
                    item.UnitPrice = product.UnitPrice;
                    item.ProductURL = product.ProductURL;
                    item.CategoryId = product.CategoryId;
                    item.SupplierId = product.SupplierId;
                    item.size = product.size;
                    item.ItemColorId = product.ItemColorId;

                    _context.Entry(item).State = EntityState.Modified;
                    _context.SaveChanges();
                    var message = StatusCode(201, product);
                    return message;

                }
                else
                {
                    return NotFound("Product with id " + id.ToString() + " not found for update");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        #endregion


        #region DELETE Method
        /**
         * This is Delete method and method name is DeleteOrder
        * https://localhost:44351/api/ProductApi/DeleteProduct/1
         **/

        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            try
            {
                if (id > 0)
                {
                    var product = _context.Product.Where(s => s.ProductId == id).FirstOrDefault();
                    if (product != null)
                    {
                        _context.Product.Remove(product);
                        _context.SaveChanges();

                        return Ok("Product id " + id.ToString() + " successfully deleted");
                    }
                    else
                    {
                        return NotFound("Product with id " + id.ToString() + " not found for delete");
                    }
                }
                else
                {
                    return BadRequest("Something wrong");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        #endregion
    }
}