using Queries.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IQuestionRepository Questions { get;}
        int Complete();
    }
}
