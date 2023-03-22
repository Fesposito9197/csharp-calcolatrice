using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class CalcoliHelper
{
    public static int Somma(int a, int b) => a + b;

    public static double SommaDouble(double a, double b) => a + b;

    public static int Differenza(int a, int b) => a - b;

    public static double DifferenzaDouble(double a, double b) => a - b;

    public static int Moltiplicazione(int a, int b) => a * b;

    public static double MoltiplicazioneDouble(double a, double b) => a * b;

    public static int ValoreAssoluto(int a) => Math.Abs(a);

    public static double ValoreAssolutoDouble(double a) => Math.Abs(a);    
}

