// See https://aka.ms/new-console-template for more information
global using Newtonsoft.Json;
using cs10_global_using;
using System;
using System.Collections.Generic;

Console.WriteLine("Hello, World!");

var l = new List<string>();

var p = new Personne { nom = "Toto", age = 20 };
var json_p = JsonConvert.SerializeObject(p);

Console.WriteLine(json_p);
Console.WriteLine(p.GetJson());