using Newtonsoft.Json;
using TrainingProgressionApp.Data;

namespace TrainingProgressionApp
{
    // Stores EmbeddedMemories to disk and retrieves them.
    public class DiskEmbedder
    {
        public string Path { get; set; }
        public DiskEmbedder(string template)
        {
            Path = template;
        }
    
        // Check if file already exists at path.
        // If it does, overwrite it with the list of goal.
        // If it doesn't, create it and write list of goal to it.
        public void WriteMemories(List<Goal> goal)
        {

            if (File.Exists(Path))
            {
                string path = Path;
                try
                {
                    File.WriteAllText(path, JsonConvert.SerializeObject(goal));
                }
                catch (Exception ex) { throw ex; }
            }
            else
            {
                File.WriteAllText(Path, JsonConvert.SerializeObject(goal));
            }
        }
        // Check if file already exists at path and that it is not empty.
        // If it does, read all goal from it and return them.
        // If it does not, return an empty set of goal.
        public List<Goal> ReadMemories()
        {
            if (File.Exists(Path) && new FileInfo(Path).Length > 0)
            {
                return JsonConvert.DeserializeObject<List<Goal>>(File.ReadAllText(Path));
            }
            else
            {
                return new List<Goal>();
            }
        }
    }
    public class GoalDatabase
    {
        public DiskEmbedder Disk = new(FileSystem.Current.AppDataDirectory + "goals.json");
        private List<Goal> _goalsInMemory = new();
        private Goal _tempGoal = new();
        private void StoreGoals(List<Goal> goals) => _goalsInMemory = goals;

        public Goal GetItem(string id) => _goalsInMemory.Where(i => i.Title == id).FirstOrDefault();

        public List<Goal> GetItemsAsync()
        {
            var goals = Disk.ReadMemories();
            // Stash the goals for us to grab later by id
            StoreGoals(goals);
            return goals;
        }

        public void SaveItem(Goal item)
        {
            // Check if item exists in memory first
            var goalTitleList = _goalsInMemory.Select(i => i.Title).ToList();
            var goalTitle = goalTitleList.FirstOrDefault(i => i == item.Title);
            Console.WriteLine(goalTitle);
            if (goalTitle == item.Title)
            {
                // Remove and update the goal in memory
                var goal = _goalsInMemory.FirstOrDefault(i => i.Title == goalTitle);
                DeleteGoal(goal);
                _goalsInMemory.Add(item);
            }
            else
            {
                // no matching goal, so this goal does not exist yet
                _goalsInMemory.Add(item);
            }
            Disk.WriteMemories(_goalsInMemory);
        }

        // Delete item from goals in memory
        public void DeleteGoal(Goal item)
        {
            _goalsInMemory.Remove(item);
            Disk.WriteMemories(_goalsInMemory);
        }

        // Delete all goals in memory
        public void DeleteAllGoals()
        {
            _goalsInMemory.Clear();
            Disk.WriteMemories(_goalsInMemory);
        }
    }

}