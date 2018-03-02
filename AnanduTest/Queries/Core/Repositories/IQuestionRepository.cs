using Queries.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries.Core.Repositories
{
    public interface IQuestionRepository:IRepository<Question>
    {
        List<Question> GetSatckQuestionsFormApi(out bool executestatus, out string executemessage);
    }
}
