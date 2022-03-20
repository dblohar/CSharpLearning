// See https://aka.ms/new-console-template for more information


//Create the object of class

using IndexerExample;

Languages languages = new Languages();

languages[0] = "Marathi";
languages[1] = "Hindi";
languages[2] = "English";
languages[3] = "French";

Console.WriteLine(languages[2]); 

Console.ReadKey();