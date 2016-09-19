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
        private char[] tabEval;

       

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

        public char[] TabEval
        {
            get
            {
                return tabEval;
            }

            set
            {
                tabEval = value;
            }
        }

        public Pupil(String name, int age, int grade): base(name,age)
        {
            Grade = grade;
            LstActivities = new List<Activity>();
            TabEval = new char[10];
        }
        public Pupil(String name, int age) : this(name,age,1)
        {}
        public void AddActivity(Activity activity)
        {
            LstActivities.Add(activity);
        }

        public override string ToString()
        {
            string ch = base.ToString();
            int cptActivities = LstActivities.Count();
            if (cptActivities == 0)
            {
                ch += " n'a pas encore choisi d'activité)";
            }
            else
            {
                ch += " a choisi les activités suivantes :";
                foreach (Activity activity in LstActivities)
                {
                    ch += activity.ToString() + ", ";

                }
            }
            return ch;
        }
        public void AddEvalutation(String title = null, char evaluation = (char)Parameter.Evaluation.Satisfaisant)
        {
            if (title != null)
            {
                int i = 0;
                foreach (Activity activity in LstActivities)
                {
                    if (activity.Title == title) break;
                    i++;
                }
                TabEval[i] = evaluation;
            }

        }
        
    }
}
