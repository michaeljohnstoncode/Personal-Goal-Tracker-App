using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgressionApp.Data
{
    public class SampleEntryData
    {
        public List<Goal> exampleEntryList;

        public SampleEntryData()
        {
            List<Goal> exEntryList = SampleEntries();
            exampleEntryList = exEntryList;
        }

        // 3 example entries to be put into a List<Entry>
        public List<Goal> SampleEntries()
        {
            Goal exampleEntry1 = new()
            {
                Title = "Exercise",
                GoalDescription = "I want to improve my fitness level and my calisthenics ability/skills",
                AddTimeSpent = true,
                TotalTimeSpent = 9000,
                TotalActionsCompleted = 4571,
                TotalEntriesCompleted = 1,
                EntryData = new GoalEntriesData()
                {
                    TimeSpentMinutes = 60,
                    GoalActions = new List<GoalAction>()
                    {
                        {  new GoalAction() { Action = "Number of pushups", ActionsCompleted = 150 } },
                        {  new GoalAction() { Action = "Number of pullups", ActionsCompleted = 65 } },
                        {  new GoalAction() { Action = "Minutes spent on planche progression", ActionsCompleted = 25 } },
                        {  new GoalAction() { Action = "Action description placeholder", ActionsCompleted = 0 } },
                    },
                    GoalEntryQuestions = new List<GoalEntryQuestion>()
                    {
                        { new GoalEntryQuestion()
                        {
                            Question = "Do you think you are improving?",
                            QuestionRating =  new QuestionRating{Rating = 7, RatingDescription = "test" } 
                        } 
                        },

                        { new GoalEntryQuestion
                        {
                            Question = "Are you enjoying yourself?",
                            QuestionRating = new QuestionRating { Rating = 6, RatingDescription = "test" }
                        }
                        },

                        { new GoalEntryQuestion
                        {
                            Question = "Do you think you could do better?",
                            QuestionRating = new QuestionRating { Rating = 4, RatingDescription = "test" }
                        }
                        },

                        { new GoalEntryQuestion
                        {
                            Question = "Do you think you are spending your time how you want to?",
                            QuestionRating = new QuestionRating { Rating = 8, RatingDescription = "test" }
                        }
                        },

                        { new GoalEntryQuestion
                        {
                            Question = "test question",
                            QuestionRating = new QuestionRating { Rating = 10, RatingDescription = "test" }
                        } 
                        },
                    }
                }
            };

            Goal exampleEntry2 = new()
            {
                Title = "Coding",
                GoalDescription = "I want to improve/expand my knowledge and ability to create programs",
                AddTimeSpent = true,
                TotalTimeSpent = 4500,
                TotalActionsCompleted = 2,
                TotalEntriesCompleted = 1,
                EntryData = new GoalEntriesData()
                {
                    TimeSpentMinutes = 360,
                    GoalActions = new List<GoalAction>()
                    {
                        {  new GoalAction() { Action = "Action description placeholder", ActionsCompleted = 0 } }
                    },
                    GoalEntryQuestions = new List<GoalEntryQuestion>()
                    {
                        { new GoalEntryQuestion
                        {
                            Question = "Do you think you are improving?",
                            QuestionRating = new QuestionRating { Rating = 6, RatingDescription = "test" }
                        }
                        },

                        { new GoalEntryQuestion
                        {
                            Question = "Are you enjoying yourself?",
                            QuestionRating = new QuestionRating { Rating = 5, RatingDescription = "test" }
                        }
                        },

                        { new GoalEntryQuestion
                        {
                            Question = "Do you think you could do better?",
                            QuestionRating = new QuestionRating { Rating = 7, RatingDescription = "test" }
                        }
                        },

                        { new GoalEntryQuestion
                        {
                            Question = "Do you think you are spending your time how you want to?",
                            QuestionRating = new QuestionRating { Rating = 7, RatingDescription = "test" }
                        }
                        },

                        { new GoalEntryQuestion
                        {
                            Question = "test question",
                            QuestionRating = new QuestionRating { Rating = 10, RatingDescription = "test" }
                        }
                        },
                    }
                }
            };

            Goal exampleEntry3 = new()
            {
                Title = "Guitar",
                GoalDescription = "I want to be able to play more songs and become more fluent with the guitar",
                AddTimeSpent = true,
                TotalTimeSpent = 450,
                TotalActionsCompleted = 3,
                TotalEntriesCompleted = 1,
                EntryData = new GoalEntriesData()
                {
                    TimeSpentMinutes = 60,
                    GoalActions = new List<GoalAction>()
                    {
                        { new GoalAction() {Action = "Action description placeholder", ActionsCompleted = 0 } }
                    },
                    GoalEntryQuestions = new List<GoalEntryQuestion>()
                    {
                        { new GoalEntryQuestion 
                        {
                            Question = "Do you think you are improving?", 
                            QuestionRating = new QuestionRating { Rating = 9, RatingDescription = "test" }
                        } 
                        },

                        { new GoalEntryQuestion
                        {
                            Question = "Are you enjoying yourself?",
                            QuestionRating = new QuestionRating { Rating = 9, RatingDescription = "test" }
                        }
                        },

                        { new GoalEntryQuestion
                        {
                            Question = "Do you think you could do better?",
                            QuestionRating = new QuestionRating { Rating = 4, RatingDescription = "test" }
                        } 
                        },

                        { new GoalEntryQuestion
                        {
                            Question = "Do you think you are spending your time how you want to?",
                            QuestionRating = new QuestionRating { Rating = 10, RatingDescription = "test" }
                        }
                        },

                        { new GoalEntryQuestion
                        {
                            Question = "test question",
                            QuestionRating = new QuestionRating { Rating = 10, RatingDescription = "test" }
                        }
                        },
                    }
                }
            };

            List<Goal> entries = new() { exampleEntry1, exampleEntry2, exampleEntry3 };
            return entries;
        }
    }
}
