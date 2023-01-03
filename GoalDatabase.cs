using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingProgressionApp.Data;

namespace TrainingProgressionApp
{
    public class GoalDatabase
    {
        public SQLiteAsyncConnection Database;

        public GoalDatabase()
        {
        }

        async Task Init()
        {
            if (Database is not null)
                return;

            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            var result = await Database.CreateTableAsync<Goal>(); // <----- This is where I get the NotSupportedException error
            Console.WriteLine("Test for result below");
            Console.Write(result.ToString());
        }
        public async Task<List<Goal>> GetItemsAsync()
        {
            await Init();
            return await Database.Table<Goal>().ToListAsync();
         
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
