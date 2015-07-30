    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;

class Program
    {
        static void Main()
        {
            List<string> sequence = Console.ReadLine().Split(new char[0], StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> executer=new List<string>();
            bool end = false;
            

            while (end==false)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                
                try
                {
                    int start,count;
                    switch (command[0])
                {
                        
                    case "reverse":
                        start = int.Parse(command[2]);
                        count = int.Parse(command[4]);
                executer.AddRange(sequence.GetRange(start,count));
                sequence.RemoveRange(start,count);
                        executer.Reverse();
                sequence.InsertRange(start,executer);
                executer.Clear();
                break;
                    case"sort":
                        start = int.Parse(command[2]);
                        count = int.Parse(command[4]);
                        executer.AddRange(sequence.GetRange(start,count));
                sequence.RemoveRange(start,count);
                        executer.Sort();
                sequence.InsertRange(start,executer);
                executer.Clear();
                        break;
                    case "rollLeft":
                        if (int.Parse(command[1]) < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            continue;
                        }
                        count = int.Parse(command[1])%sequence.Count;
                        
                        for (int i = 0; i < count; i++)
                        {
                            string first = sequence.First();
                            sequence.Remove(sequence.First());
                            sequence.Add(first);
                            

                        }
                            //executer.AddRange(sequence.GetRange(0,count));
                            //sequence.RemoveRange(0,count);
                            //sequence.AddRange(executer);
                            //executer.Clear();
                        break;
                    case "rollRight":
                        if (int.Parse(command[1])<0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            continue;
                        }
                        count = int.Parse(command[1])%sequence.Count;
                       

                        for (int i = 0; i < count; i++)
                        {
                            string last = sequence.Last();
                            sequence.Remove(sequence.Last());
                            sequence.Insert(0,last);
                            

                        }
                            //executer.AddRange(sequence.GetRange(sequence.Count-count,count));
                            //sequence.RemoveRange(sequence.Count- count, count);
                            //sequence.InsertRange(0,executer);
                            //executer.Clear();

                        break;
                    case "end":
                        end = true;
                        break;
                        default :
                        Console.WriteLine("Invalid input parameters.");
                            break;


                }

                }
                catch (ArgumentException)
                {

                    Console.WriteLine("Invalid input parameters.");
                    
                }
                
            }
            int loopCount = 0;

            Console.Write("[");
            foreach (var s in sequence)
            {
                if (loopCount == sequence.Count - 1)
                {
                    Console.Write(s);
                }
                else
                {
                    Console.Write("{0}, ", s);
                }
                loopCount++;

            }
            Console.WriteLine("]");

        }
    }
