using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgressionApp.Data
{

    //Models used to hold Question and Action data for a specific goal entry day; presented on the page as a summary.
    public class QuestionDaySummary
    {
        public string GoalTitle { get; set; }
        public string GoalQuestion { get; set; }
        public QuestionRating QuestionRating { get; set; }
        public bool IsCollapseOpen { get; set; } = false;
    }

    public class ActionDaySummary
    {
        public string GoalTitle { get; set; }
        public string Action { get; set; }
        public ActionCompleted ActionCompleted { get; set; }
    }
}
