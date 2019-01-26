using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_class_second_console
{
    class Human

    {
        //Default Constructor
        public Human() { }

        public Human (string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public string HariColor { get; set; }
        public double Weight { get; set; }

        public string FullName { 


            get { return FirstName + " " + LastName; }
            
            }

        }

    }

