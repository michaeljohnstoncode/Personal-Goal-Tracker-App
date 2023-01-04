using CloudKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingProgressionApp.Data;
using TrainingProgressionApp.Data.Repository.Goals;

namespace TrainingProgressionApp.Services
{
    /// <summary>
    /// SQLite database service layer. This class is responsible for all database operations.
    /// It will hold a reference to the database connection and expose methods to access and update
    /// the tables.
    /// </summary>
    public class DatabaseService
    {
        private GoalsRepository _goalsDatabase;
        public DatabaseService(GoalsRepository goalsDb)
        {
            _goalsDatabase = goalsDb;
        }
        
        public async Task<List<Goal>> GetItemsAsync()
        {
            var model = await _goalsDatabase.GetGoalsAsync().;
            var goals = new List<Goal>();
            foreach (var item in model)
            {
                goals.Add(new Goal(item));
            }
            return model;

        }

        public async Task<Goal> GetItemAsync(string id)
        {
            await Init();
            return await Database.Table<Goal>().Where(i => i.Title == id).FirstOrDefaultAsync();
        }

        public async Task<int> SaveItemAsync(Goal item)
        {
            await Init();
            if (item.Title is null)
                return await Database.UpdateAsync(item);
            else
                return await Database.InsertAsync(item);
        }

        public async Task<int> DeleteItemAsync(Goal item)
        {
            await Init();
            return await Database.DeleteAsync(item);
        }
    }
}
