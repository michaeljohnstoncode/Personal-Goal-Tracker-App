using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgressionApp.Data
{
    public class GoalModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        public string GoalDescription { get; set; }
        public bool AddTimeSpent { get; set; }
        public double TotalTimeSpent { get; set; }
        public double TotalActionsCompleted { get; set; }
        public int TotalEntriesCompleted { get; set; }
        [OneToMany]
        public List<GoalEntriesDataModel> GoalEntriesData { get; set; }
    }

    public class GoalEntriesDataModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [ForeignKey(typeof(GoalModel))]
        public int GoalModelId { get; set; }
        [OneToOne]
        public AllTimeSpentMinutesModel AllTimeSpentMinutes { get; set; }
        [OneToOne]
        public GoalActionModel GoalAction { get; set; }
        [OneToMany]
        public GoalEntryQuestionModel GoalEntryQuestions { get; set; }
    }


    public class AllTimeSpentMinutesModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [ForeignKey(typeof(GoalEntriesDataModel))]
        public int GoalEntryId { get; set; }
        public double TimeSpentMinutes { get; set; }
    }


    public class GoalActionModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [ForeignKey(typeof(GoalEntriesDataModel))]
        public int GoalEntryId { get; set; }
        public string Action { get; set; }
        [OneToOne]
        public GoalActionsCompletedModel GoalActionsCompleted { get; set; }
    }

    public class GoalActionsCompletedModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [ForeignKey(typeof(GoalActionModel))]
        public int GoalActionId { get; set; }
        public double ActionsCompleted { get; set; }
    }


    public class GoalEntryQuestionModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [ForeignKey(typeof(GoalEntriesDataModel))]
        public int GoalEntryId { get; set; }
        public string Question { get; set; }
        [OneToOne]
        public int QuestionRatingId { get; set; }
    }


    public class QuestionRatingModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [ForeignKey(typeof(GoalEntryQuestionModel))]
        public int GoalEntryQuestionId { get; set; }
        public int Rating { get; set; }
        public string RatingDescription { get; set; }
    }
}
