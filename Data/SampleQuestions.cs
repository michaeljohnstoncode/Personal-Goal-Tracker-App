using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgressionApp.Data
{
    public class SampleQuestions
    {
        public List<ExampleGoalQuestions> exGoalQuestions = new()
        {
             new ExampleGoalQuestions()  {Question = "Do you think you are improving?", Key = "question1" },
             new ExampleGoalQuestions()  {Question = "Are you enjoying yourself?", Key = "question2" },
             new ExampleGoalQuestions()  {Question = "Do you think you could do better?", Key = "question3" },
             new ExampleGoalQuestions()  {Question = "Do you think you are spending your time how you want to?", Key = "question4" },
        };
    }

    public class ExampleGoalQuestions
    {
        public string Question { get; set; }
        public string Key { get; set; }
    }
}
