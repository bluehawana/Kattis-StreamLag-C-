using System;
using System.Linq;
using System.Collections.Generic;


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lineString = Console.ReadLine();
            if (int.TryParse(lineString, out var line))
            {
                var @in = new List<int>();
                var segment = new List<int>();
                var lineCount = 1;
                do
                {

                    var payload = Console.ReadLine();
                    if (!string.IsNullOrEmpty(payload))
                    {
                        var segments = payload.Split(' ');
                        if (segments.Length == 2)
                        {
                            @in.Add(int.Parse(segments[0]));
                            segment.Add(int.Parse(segments[1]));
                        }
                    }
                }
                while (lineCount++ < line);

                var buffer = new List<int>() { 0 };
                for (var index = 0; index < segment.Count; index++)
                {
                    buffer.Add(@in[index] - segment[index]);
                }

                Console.WriteLine($"Delay: {buffer.Max()}");
                Console.ReadLine();
            }
        }
    }
    }