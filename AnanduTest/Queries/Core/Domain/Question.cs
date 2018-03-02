using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries.Core.Domain
{
    public class Question
    {
        public int question_id { get; set; }
        public bool is_answered { get; set; }
        public int view_count { get; set; }
        public int answer_count { get; set; }
        public int score { get; set; }
        public string link { get; set; }
        public string title { get; set; }
        public string[] tags { get; set; }

        public int ownerid { get; set; }

        public Owner owner { get; set; }
    }
}
