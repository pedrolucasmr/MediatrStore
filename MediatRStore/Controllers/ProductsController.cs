using MediatRStore.DTOs;
using MediatRStore.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MediatRStore.Controllers;

[Route("/products")]
public class ProductsController: ControllerBase
{
    private readonly IProductService _productService;
    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }
    
    [HttpGet]
    public async Task<ObjectResult> GetAllProducts()
    {
        
    }
    
    [Route("/product")]
    [HttpGet]
    public async Task<ObjectResult> GetProduct()
    {
        
    }
    
    [Route("/product")]
    [HttpPost]
    public async Task<ObjectResult> CreateProduct([FromBody] CreateProductRequestDTO request)
    {
        var result = await _productService.CreateProduct(request);
        return new ObjectResult(result)
        {
            StatusCode = result.StatusCode
        };
    } 
}