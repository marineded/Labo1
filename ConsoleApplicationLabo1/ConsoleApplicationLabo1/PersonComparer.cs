using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    class PersonComparer : IEqualityComparer<Person>
    {
       
public int GetHashCode(Person obj)
        {
            return obj.Name.GetHashCode() ^ obj.Age.GetHashCode();
        }

        bool IEqualityComparer<Person>.Equals(Person x, Person y)
        {
            if (x.Age == y.Age)
            {
                if (x.Name == y.Name)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
