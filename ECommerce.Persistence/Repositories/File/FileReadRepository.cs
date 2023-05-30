using ECommerce.Application.Repositories.File;
using ECommerce.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Persistence.Contexts;

namespace ECommerce.Persistence.Repositories.File
{
    public class FileReadRepository : ReadRepository<ECommerce.Domain.Entities.File>, IFileReadRepository
    {
        public FileReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
