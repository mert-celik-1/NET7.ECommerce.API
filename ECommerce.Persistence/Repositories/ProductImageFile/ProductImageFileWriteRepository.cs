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
    public class ProductImageFileWriteRepository : WriteRepository<ECommerce.Domain.Entities.ProductImageFile>, IProductImageFileWriteRepository
    {
        public ProductImageFileWriteRepository(AppDbContext context) : base(context)
        {
        }
    }
}
