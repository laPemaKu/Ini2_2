﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljeđivanje_ponavaljanje
{
    internal class Program
    {
        class GeometrijskiLik
        {
            int brojStranica;
            double[] stranice= new double[10];
            
            public void UcitajStranice()
            {
                Console.WriteLine("Upiši te stranice:");
                for (int i=0;i<this.brojStranica; i++)
                {
                    Console.WriteLine("Stranica {0}: ",i+1);
                    string upis = Console.ReadLine();
                    stranice[i]= Convert.ToDouble(upis);
                }
            }
            public string Opseg()
            {
                double opseg=0;
                for(int i=0;i<this.brojStranica; i++)
                {
                    opseg += stranice[i];
                }
                return "Opseg je: " + opseg;
            }
            public GeometrijskiLik()
            {

            }
            public GeometrijskiLik(int brojStranica)
            {
                this.brojStranica = brojStranica;
            }
            
        }
        class Trokut : GeometrijskiLik
        {
            public Trokut() : base(3)
            {

            }
        }
        class Cetvertokut : GeometrijskiLik
        {
            public Cetvertokut () : base(4)
            {

            }

        }
        static void Main(string[] args)
        {
            Trokut trokut = new Trokut();
            Cetvertokut cetvertokut = new Cetvertokut();

            trokut.UcitajStranice();
            Console.WriteLine(trokut.Opseg());

            cetvertokut.UcitajStranice();
            Console.WriteLine(cetvertokut.Opseg());

            Console.ReadKey();
        }
    }
}