using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgressionApp.Data
{
	public class Goal
	{
		public Goal(GoalModel model)
		{
            Title = model.Title;
            GoalDescription = model.GoalDescription;
            AddTimeSpent = model.AddTimeSpent;
            TotalTimeSpent = model.TotalTimeSpent;
            TotalActionsCompleted = model.TotalActionsCompleted;
            TotalEntriesCompleted = model.TotalEntriesCompleted;
            GoalEntriesData = model.GoalEntriesData;
        }
		public string Title { get; set; }
		public string GoalDescription { get; set; }
		public bool AddTimeSpent { get; set; }
		public double TotalTimeSpent { get; set; }
		public double TotalActionsCompleted { get; set; }
		public int TotalEntriesCompleted { get; set; }
		public GoalEntriesData EntryData { get; set; }
	}

    //GoalEntriesData class represents all entries of data
    // contains time spent per entry, actions taken on goal, and questions user wants to ask about their goal
    public class GoalEntriesData
	{
		public double TimeSpentMinutes { get; set; }
		public Dictionary<int, double> AllTimeSpentMinutes { get; set; }
		public List<GoalAction> GoalActions { get; set; }
		public List<GoalEntryQuestion> GoalEntryQuestions { get; set; }
    }

    //GoalAction class represents each action, and number of times action was completed. ActionsCompleted gets added to AllActionsCompleted dictionary per entry
    public class GoalAction
	{
		public string Action { get; set; }
		public double ActionsCompleted { get; set; }
		public Dictionary<int, double> AllActionsCompleted { get; set; }
	}

	//GoalEntryQuestion class represents each question, and the rating they give to that question per entry (rating = on scale 1-10). QuestionRating gets added to AllQuestionRatings dictionary per entry
	public class GoalEntryQuestion
    {
        public string Question { get; set; }
		public QuestionRating QuestionRating { get; set; }
        public Dictionary<int, QuestionRating> AllQuestionRatings { get; set; }
    }

	//QuestionRating class contains the rating they give to a question per entry, and optionally a description of why they gave this rating
	public class QuestionRating
	{
		public int Rating { get; set; }
		public string RatingDescription { get; set; }
	}

}
