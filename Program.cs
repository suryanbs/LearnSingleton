﻿// See https://aka.ms/new-console-template for more information
using SingletonPattern;

Console.WriteLine("Singleton Design pattern");
var water =new Water();
var air =new Air();

Parallel.Invoke(() => water.PrintWater(),
                ()=> air.PrintAir());


// This is a feature branch.
//Let's learn Squash and merge
//Second commit

