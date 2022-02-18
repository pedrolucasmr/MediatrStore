using MediatRStore.DTOs;

namespace MediatRStore.Services.Interfaces;

public interface IProductService
{
    Task<CreateProductResponseDTO> CreateProduct(CreateProductRequestDTO request);
}