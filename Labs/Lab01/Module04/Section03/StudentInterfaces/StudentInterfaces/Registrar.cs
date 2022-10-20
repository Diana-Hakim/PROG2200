using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentInterfaces
{
    internal class Registrar
    {
        private List<IGraduate> grads;

        public Registrar(List<IGraduate> grads)
        {
            this.grads = grads;
        }

        public void GraduateAll() {
            foreach (var grad in grads)
            {
                //Console.WriteLine(grad.ShowInfo()+"\n");
                grad.Graduate();
                //Console.WriteLine("\n" + grad.ShowInfo());
                //Console.ReadLine();
            }
        }
    }
}
