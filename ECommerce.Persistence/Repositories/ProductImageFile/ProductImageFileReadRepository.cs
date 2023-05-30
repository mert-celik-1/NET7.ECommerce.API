using ECommerce.Application.Repositories.ProductImageFile;
using ECommerce.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Persistence.Contexts;

namespace ECommerce.Persistence.Repositories.ProductImageFile
{
    public class ProductImageFileReadRepository : ReadRepository<ECommerce.Domain.Entities.ProductImageFile>, IProductImageFileReadRepository
    {
        public ProductImageFileReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
