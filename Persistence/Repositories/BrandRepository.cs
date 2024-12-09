using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories;

public class BrandRepository(BaseDbContext baseDbContext):EfRepositoryBase<Brand,Guid,BaseDbContext>(baseDbContext),IBrandRepository
{
    
}