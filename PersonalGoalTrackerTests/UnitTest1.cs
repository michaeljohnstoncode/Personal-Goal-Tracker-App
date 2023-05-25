using TrainingProgressionApp;
using TrainingProgressionApp.Data;

namespace PersonalGoalTrackerTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            DiskEmbedder Disk = new($"C:\\Users\\Michael\\AppData\\Local\\Packages\\FC52255D-5B4E-4F92-99E4-32A5EA883375_9zz4h110yvjzm\\LocalState\\goals.json");

            List<Goal> goalTest = Disk.ReadMemories();
            Assert.NotNull(goalTest);
        }
    }
}