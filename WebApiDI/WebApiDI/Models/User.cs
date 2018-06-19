using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiDI.Models
{
    public class User
    {
        public string Name { get; set; }
        public int Age {get; set; }

        public User() { }

        public override bool Equals(object obj)
        {
            // Check for null values and compare run-time types.
            if (obj == null || GetType() != obj.GetType())
                return false;

            User u = (User)obj;
            return (Name.Equals( u.Name )) && (Age == u.Age);
        }

        public override int GetHashCode()
        {
            var hashCode = -1360180430;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Age.GetHashCode();
            return hashCode;
        }
    }

    
}
