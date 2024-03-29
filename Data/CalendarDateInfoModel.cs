﻿namespace TrainingProgressionApp.Data
{
    //Model used to hold the dates and titles of days where an entry is completed for a goal (in the GoalCalendar page)
    public class CalendarDateInfo
    {
        public string GoalTitle { get; set; }
        public List<string> GoalEntryDates { get; set; }
    }

}
