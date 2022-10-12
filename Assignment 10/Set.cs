using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Lydia's code - find the errors!
namespace CST117_IC08_console
{
    class Set
    {
        private List<int> elements;


        public Set()
        {
            elements = new List<int>();
        }

        public bool addElement(int val)
        {
            if (containsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }
        }

        private bool containsElement(int val)
        {
            
            
            for (int i = 0; i < elements.Count; i++)

            {
                if (val == elements[i])
                    return true;
                //else statement is being removed because it exits loop earlier 
               // else
              //   return false;
            }
            return false;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        public void clearSet()
        {
            elements.Clear();
        }

    




        public Set union(Set rhs)
        {
            Set result = new Set();

            for (int i = 0; i < rhs.elements.Count; i++)
            {
                //
                //this.addElement(rhs.elements[i]);
                result.addElement(rhs.elements[i]);
               
            }
            //added a second for loop to process left side 
            for (int i = 0; i < this.elements.Count; i++)
            {
                result.addElement(this.elements[i]);

            }
            //return rhs;
            return result;
        }
    }
}
