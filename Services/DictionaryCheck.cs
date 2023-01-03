using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingProgressionApp.Data;

namespace TrainingProgressionApp.Services
{
    public class DictionaryCheck
    {
        
        //general key check, can take both GoalActions and GoalEntryQuestions dictionaries
        public bool DoesKeyExist(Dictionary<int, object> questionDictionary, int key)
        {
            if(questionDictionary.ContainsKey(key))
            {
                return true;
            }
            return false;
        }

        public bool DoesQuestionExist(Dictionary<int, GoalEntryQuestion> questionDictionary, GoalEntryQuestion value)
        {
           foreach(var question in questionDictionary)
           { 
                if (question.Value.Question.Equals(value.Question))
                {
                    return true;
                }
           }
           return false;
        }

        public bool DoesActionExist(Dictionary<int, GoalAction> actionDictionary, GoalAction value)
        {
            foreach(var action in actionDictionary)
            {
                if (action.Value.Action.Equals(value.Action))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
