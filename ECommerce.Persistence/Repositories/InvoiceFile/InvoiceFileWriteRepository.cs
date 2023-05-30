using ECommerce.Application.Repositories.InvoiceFile;
using ECommerce.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Persistence.Contexts;

namespace ECommerce.Persistence.Repositories.InvoiceFile
{
    public class InvoiceFileWriteRepository : WriteRepository<ECommerce.Domain.Entities.InvoiceFile>, IInvoiceFileWriteRepository
    {
        public InvoiceFileWriteRepository(AppDbContext context) : base(context)
        {
        }
    }
}
