using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgressionApp.Data
{
	//Highest level class model for the Goal
	public class Goal
	{
        [Required(ErrorMessage = "Goal title is required.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Goal description is required.")]
        public string GoalDescription { get; set; }
		public bool AddTimeSpent { get; set; }
		public double TotalTimeSpent { get; set; }
		public string GoalCreationDate { get; set; }
		public double OverallActionsCompleted { get; set; }
		public int TotalEntriesCompleted { get; set; }
		public GoalEntriesData EntryData { get; set; }
	}

    //GoalEntriesData class represents all entries of data
    // contains time spent per entry, actions taken on goal, and questions user wants to ask about their goal
    public class GoalEntriesData
	{
		public List<TimeSpent> AllTimeSpentMinutes { get; set; }
		public List<GoalAction> GoalActions { get; set; }
        public List<GoalAction> ArchivedGoalActions { get; set; }
        public List<GoalQuestion> GoalQuestions { get; set; }
        public List<GoalQuestion> ArchivedGoalQuestions { get; set; }
		public List<string> NewEntryDates { get; set; }
    }

	public class TimeSpent
	{
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Time spent must be a positive number.")]
        public double? TimeSpentMinutes { get; set; }
        public string TimeSpentDate { get; set; }
    }

	//GoalAction class represents each action, and number of times action was completed.
	//ActionsCompleted gets added to ListActionsCompleted dictionary per entry.
	//Includes the date when the action was created
	public class GoalAction
	{
		public string Action { get; set; }
        [ValidateComplexType]
        public ActionCompleted ActionCompleted { get; set; }
	//	public List<ActionsCompletedAndMeasurement> ListActionsCompletedAndMeasurement { get; set; }
		public List<ActionCompleted> ListActionsCompleted { get; set; }
        public double TotalActionsCompleted { get; set; }
        public string ActionCreationDate { get; set; }
	
    }

/* **	I may want to add this in the future. This class would allow there to be multiple kinds of actions completed for each action. It allows an action to be answered more dynamically.
		For example, if I were a weight lifter, I want to document how many times I did weighted squats today. Some days I do more weight, some days I do less.
		Action: Weighted squats completed today - actionsCompleted: 225 pounds 5 repetitions 3 sets ... or 195 pounds 8 repetitions 4 sets. This is like saying I did 4 sets of 195 pounds for 8 repetitions per set
		So this allows the action itself to be more ambiguous, and the actionsCompleted answer to be more descriptive of what specifically occured that day.
 
	public class ActionsCompletedAndMeasurement
	{
		public string actionMeasurement { get; set; }
		public List<ActionCompleted> ListActionsCompleted { get; set; }
	}
*/

    //ActionCompleted class represents each time an action was completed and the date it was inputted.
    public class ActionCompleted
	{
        [Required(ErrorMessage = "Actions completed field is required.")]
        public double? ActionsCompleted { get; set; }
        public string ActionCompletedDate { get; set; }
    }

    //GoalQuestion class represents each question, and the rating given to that question per entry (limited rating to be on a scale 1-10).
    //QuestionRating gets added to ListQuestionRatings dictionary per entry
    //Includes the date when the question was created
    public class GoalQuestion
    {
        public string Question { get; set; }
		public QuestionRating QuestionRating { get; set; }
        public List<QuestionRating> ListQuestionRatings { get; set; }
		public string QuestionCreationDate { get; set; }
    }

	//QuestionRating class contains the rating the user gives to a question per entry, and optionally a description of why they gave this rating
	//Includes the date of when the user gave the rating
	public class QuestionRating
	{
        [Required(ErrorMessage = "Please select a rating.")]
        public int? Rating { get; set; }
		public string RatingDescription { get; set; }
		public string QuestionAnsweredDate { get; set; }
	}

}
