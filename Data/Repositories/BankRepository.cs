using Domain.Interfaces.Repository;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class BankRepository : RepositoryBase<Bank>, IBankRepository
    {
    }
}
