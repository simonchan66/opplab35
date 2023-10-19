using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2_interfaces
{
    public interface IAnimal
    {
        string Name { get; set; }
        string Colour { get; set; }
        int Height { get; set; }
        int Age { get; set; }

        void Eat();
        string Cry();
    }
}
