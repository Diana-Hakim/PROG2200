using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentInterfaces
{
    interface IGraduate
    {
        void Graduate();
        string ShowInfo();
    }

    class Graduate
    {
        private List<IGraduate> grads = new List<IGraduate>();

        public List<IGraduate> Grads
        {
            get { return grads; }
            set { grads = value; }
        }

        public Graduate()
        {
            grads.Add(new Student("Matt",78,"Nov 27", "123 Hailfax", 123456778));
            grads.Add(new Student("Andrea", 99, "Apr 7", "321 Hailfax", 123345678));
            grads.Add(new Student("Jean", 67, "Dec 31", "213 Hailfax", 253456778));
            grads.Add(new Student("Mark", 90, "Jan 2", "312 Hailfax", 413456778));
        }

    }


}
