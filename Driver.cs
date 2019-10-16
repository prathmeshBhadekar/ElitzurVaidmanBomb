using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace ElitzurVaidmanBomb
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                int numberOfTrials = 10000, success = 0 ;
                for(int i = 0 ; i < numberOfTrials ; i ++ ) {
                    bool result = ElitZurVaidmanBomb.Run(qsim).Result ;
                    if(result)
                        success ++ ;
                }
                System.Console.WriteLine("The Success rate is " + ((success * 1.0 ) / (numberOfTrials * 1.0)) * 100 + " %" );
            }
        }
    }
}