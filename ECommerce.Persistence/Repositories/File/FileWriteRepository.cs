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
    public class FileWriteRepository : WriteRepository<ECommerce.Domain.Entities.File>, IFileWriteRepository
    {
        public FileWriteRepository(AppDbContext context) : base(context)
        {
        }
    }
}
