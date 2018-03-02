using Queries.Presistence;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfUI.Model;

namespace WpfUI.ModelView
{
    public class QuestionViewModel:ObservableCollection<QuestionM>
    {
        public QuestionViewModel()
        {
            using (UnitOfWork unitwrk = new UnitOfWork(new DataContext()))
            {
                bool executestatus;
                string executemsg;
                var list = unitwrk.Questions.GetSatckQuestionsFormApi(out executestatus, out executemsg);

                if (executestatus)
                {
                    foreach (var qitem in list)
                    {
                        Add(new QuestionM { title = qitem.title, answer_count = qitem.answer_count });

                    }
                }
            }

            
        }
    }
}
