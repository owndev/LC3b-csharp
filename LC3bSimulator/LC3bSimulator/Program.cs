
using System;
using System.IO;
using System.Collections.Generic;


public class Program
{
    public static void Main(string[] args)
    {
        // Erstellt eine Instanz des LC3b-Simulators
        LC3bSimulator simulator = new LC3bSimulator();

        // Der Pfad zur 'instructions.txt'-Datei
        string filepath = "intstructions.txt";

        // Lädt die Instruktionen aus der Datei
        List<string> instructions = simulator.LoadInstructionsFromFile(filepath);

        // Ausgabe zum Überprüfen der geladenen Instruktionen
        Console.WriteLine("Geladene Instruktionen:");
        foreach (var instruction in instructions)
        {
            Console.WriteLine(instruction);
        }
        Console.WriteLine("----------------------");

        // Führt den Simulator mit den geladenen Instruktionen aus
       simulator.Run(instructions.ToArray());
    }
}

