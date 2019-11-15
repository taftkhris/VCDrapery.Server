using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace VCDrapery.Server.Data
{
    public interface IDatabaseContext
    {
        DbSet<Models.Customers> Customers { get; set; }
        int SaveChanges();

    }
}
