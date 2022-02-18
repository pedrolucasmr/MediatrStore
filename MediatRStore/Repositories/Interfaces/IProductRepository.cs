using MediatRStore.Entities;

namespace MediatRStore.Repositories.Interfaces;

public interface IProductRepository
{
    Task<bool> UpsertAsync(Product product);
}