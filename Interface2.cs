using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5lab
{
    interface Inventory
    {
        string Cost(int cost); // стоимость

        string Lifetime(int life_time); // срок службы

    }
}