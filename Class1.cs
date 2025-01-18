using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mission2Assign;

internal class Class1
{
    private Random rnd = new Random();

    public int[] SimulateRolls(int rolls)
    {
        int[] results = new int[13];
        while (rolls > 0)
        {
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);

            int sum = dice1 + dice2;
            results[sum]++;

            rolls--;
        }
        return results;
    }
}
