using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    class Pupil : Person
    {
        private int grade;
        private List<Activity> lstActivities;
        private char[] pupilEvaluation;

       

        public int Grade
        {
            get
            {
                return grade;
            }

            set
            {
                grade = value;
            }
        }

        internal List<Activity> LstActivities
        {
            get
            {
                return lstActivities;
            }

            set
            {
                lstActivities = value;
            }
        }

        public char[] PupilEvaluation
        {
            get
            {
                return pupilEvaluation;
            }

            set
            {
                pupilEvaluation = value;
            }
        }

        public Pupil(String name, int age, int grade): base(name,age)
        {
            Grade = grade;
            LstActivities = new List<Activity>();
            PupilEvaluation = new char[10];
        }
        public Pupil(String name, int age) : this(name,age,1)
        {}
       /* public void AddActivity(Activity activity)
        {
            LstActivities.Add(activity);
        }
        */
        public override string ToString()
        {
            string ch = HeaderPupil();
            ch = PrintActivitiesPupil(ch);
            return ch;
        }

        private string HeaderPupil()
        {
            return base.ToString();
        }

        private string PrintActivitiesPupil(string ch)
        {
            int cptActivities = LstActivities.Count();
            if (cptActivities == 0)
            {
                ch += " n'a pas encore choisi d'activité)\n";
            }
            else
            {
                ch += " a choisi les activités suivantes :";
                /*foreach (Activity activity in LstActivities)
                {
                    ch += activity.ToString() + ", \n";

                }*/
                for (var i = 0; i < PupilActivities.Count; i++)
                {
                    ch += "\n" + PupilActivities.ElementAt(i).Key.ToString() + " : " + PupilActivities.ElementAt(i).Value;
                }
               }
            
            return ch;
        }

   /*   public void AddEvalutation(String title = null, char evaluation = (char)Parameter.Evaluation.Satisfaisant)
        {
            if (title != null)
            {
                int i = 0;
                foreach (Activity activity in LstActivities)
                {
                    if (activity.Title == title) break;
                    i++;
                }
                PupilEvaluation[i] = evaluation;
            }

        }*/
        private Dictionary<String, char> pupilActivities = new Dictionary<String, char>();
         
        public Dictionary<String, char> PupilActivities {get; set;}

        public void AddActivity(String activityTitle)
        {
            PupilActivities.Add(activityTitle, '0');
        }

        public void AddEvaluation(String title = null, char evaluation = 'S')
        {
            if (title != null) PupilActivities[title] = evaluation;
        }
       

    }
}
