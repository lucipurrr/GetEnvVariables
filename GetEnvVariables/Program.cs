// See https://aka.ms/new-console-template for more information

foreach (System.Collections.DictionaryEntry env in System.Environment.GetEnvironmentVariables())
    Console.WriteLine($"{env.Key}={env.Value}");