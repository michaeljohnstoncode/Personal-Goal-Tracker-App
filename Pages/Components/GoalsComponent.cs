using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingProgressionApp.Data;
using TrainingProgressionApp.Data.Repository.Goals;

namespace TrainingProgressionApp.Pages.Components
{
    public class GoalsComponent : ComponentBase
    {
        SampleEntryData newEntry = new();
        public List<Goal> ExampleEntryList = new();
        public GoalsRepository _database = new();
        


        public GoalsComponent()
        {
        }
        
        protected override async Task OnInitializedAsync()
        {
            List<Goal> exEntryList = newEntry.exampleEntryList;
            ExampleEntryList = exEntryList;
        }
    }
}
