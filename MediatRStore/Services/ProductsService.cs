using MediatRStore.DTOs;
using MediatRStore.Entities;
using MediatRStore.Repositories.Interfaces;
using MediatRStore.Services.Interfaces;

namespace MediatRStore.Services;

public class ProductsService: IProductService
{
    private readonly IProductRepository _productRepository;
    public ProductsService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    
    public async Task<CreateProductResponseDTO> CreateProduct(CreateProductRequestDTO request)
    {
        var result = new Product(request.Name, request.Quantity);

        var success = await _productRepository.UpsertAsync(result);

        if (!success)
        {
            return new CreateProductResponseDTO()
            {
                StatusCode = 400,
                Successful = false,
                Message = "Request has invalid fields"
            };
        }

        return new CreateProductResponseDTO()
        {
            StatusCode = 200,
            Successful = true,
            Message = "Product Successfully Created"
        };
    }   
}