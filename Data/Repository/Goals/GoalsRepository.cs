using SQLite;
using SQLiteNetExtensions;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgressionApp.Data.Repository.Goals
{
    // SQlite database to store and retrieve the GoalModel
    public class GoalsRepository
    {
        readonly SQLiteConnection database;

        public GoalsRepository()
        {
            database = new SQLiteConnection(Constants.DatabasePath, Constants.Flags);
            database.CreateTable<GoalModel>();
            database.CreateTable<GoalEntriesDataModel>();
            database.CreateTable<AllTimeSpentMinutesModel>();
            database.CreateTable<GoalActionModel>();
            database.CreateTable<GoalActionsCompletedModel>();
            database.CreateTable<GoalEntryQuestionModel>();
        }
        
        public List<Goal> GetGoals()
        {
            var goalModels = database.Table<GoalModel>().ToList();
            var goals = new List<Goal>();
            foreach (var goalModel in goalModels)
            {
                var model = database.GetWithChildren<GoalModel>(goalModel);
                var goal = new Goal(model);
                goals.Add(goal);
            }
            return goals;
        }

        public Task<GoalModel> GetGoalAsync(int id)
        {
            return database.Table<GoalModel>()
                            .Where(i => i.Id == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveGoalAsync(GoalModel goal)
        {
            if (goal.Id != 0)
            {
                return database.UpdateAsync(goal);
            }
            else
            {
                return database.InsertAsync(goal);
            }
        }

        public Task<int> DeleteGoalAsync(GoalModel goal)
        {
            return database.DeleteAsync(goal);
        }
    }
}
