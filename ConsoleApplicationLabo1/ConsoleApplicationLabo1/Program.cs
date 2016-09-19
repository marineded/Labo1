using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil p1 = new Pupil("Marine", 10);
            Pupil pupilGrade1 = new Pupil("Noa", 3);
            Activity a1 = new Activity("Math", true);
            Activity a2 = new Activity("Sciences", false);
            Activity coloriage = new Activity("Coloriage", true);


            p1.AddActivity(a1);
            p1.AddActivity(a2);
            pupilGrade1.AddActivity(coloriage);
            pupilGrade1.AddEvalutation("Coloriage");


            p1.AddEvalutation(evaluation: 'T', title: "Sciences");


            System.Console.Write(p1);
            System.Console.Write(pupilGrade1);
   


            List<Pupil> listPupils = new List<Pupil>()
            {
                new Pupil("alex", 10, 1),
                new Pupil("jéjé", 6, 2),
                new Pupil("a1", 7, 3),
                new Pupil("b2", 6,1),
                new Pupil("c3", 9, 1),
                new Pupil("d4", 10, 5),
                new Pupil("e5", 11, 2),
                new Pupil("f6", 6, 6)
            };
            List<Pupil> listPupilsDuplicated = new List<Pupil>()
            {
                new Pupil("alex", 10, 1),
                new Pupil("jéjé", 6, 2),
                new Pupil("a1", 7, 3),
                new Pupil("b2", 6,1),
                new Pupil("c3", 9, 1),
                new Pupil("d4", 10, 5),
                new Pupil("e5", 11, 2),
                new Pupil("f6", 6, 6)
            };


            List<Person> listPersons = new List<Person>()
            {
                new Person("Lea",3),
                new Person("Vincent",12),
                new Person("Flore",4),
                new Person("Julie",8),
            };

            var listFusion = listPersons.Union(listPupils);

            foreach (var list in listFusion)
            {
                Console.WriteLine(list);
            }

            IEnumerable<Pupil> listPupilsNoDuplicated = listPupilsDuplicated.Distinct<Pupil>(new PersonComparer());
            //var pupilGrade1Plus6 = from pupil in listPupils where pupil.Grade == 1 && pupil.Age > 6 select pupil;
            var pupilGrade1Plus6 = listPupils.Where(pupil => pupil.Grade == 1 && pupil.Age > 6);
            //var pupilGrade1Plus6 = listPupils.FindAll(pupil => pupil.Grade == 1 && pupil.Age > 6);

            //Console.Write(julien);
            foreach (var p in pupilGrade1Plus6)
            {
                Console.WriteLine(p);
            }
         
       Console.Read();



        }
    }
}
