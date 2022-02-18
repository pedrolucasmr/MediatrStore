using MediatRStore.Entities;
using MediatRStore.Repositories.Interfaces;

namespace MediatRStore.Repositories;

public class ProductRepository: IProductRepository
{
    public Task<bool> UpsertAsync(Product product)
    {
        return Task.FromResult(true);
    }
}