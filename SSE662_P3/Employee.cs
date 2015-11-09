using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSE662_P3
{
    public class Employee
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private string _position;

        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public Employee(string fName, string lName)
        {
            _firstName = fName;
            _lastName = lName;
        }
        
    }
}
