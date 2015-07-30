//    using System;
//    using System.Collections.Generic;
//    using System.Linq;
//    using System.Text;
//    using System.Text.RegularExpressions;

//class Program
//    {
//        static void Main()
//        {


            
//            List<string> drunkenText=new List<string>();
//            List<string> decifered=new List<string>();
//            bool burp = false;
//            while (burp==false)
//            {
//                    string line = Console.ReadLine();
//                    if (line=="burp")
//                    {
//                        burp = true;
//                    }
//                    else
//                    {
//                        drunkenText.Add(line);
//                    }
                
                
//            }
//            string nakovText= drunkenText.Aggregate(String.Empty, (current, line) => current + line);

//            string cleanedNakovText = System.Text.RegularExpressions.Regex.Replace(nakovText, @"\s+", " ");
//            //Console.WriteLine(cleanedNakovText);
//            Regex regex = new Regex(@"\$(.+?)\$|\%(.+?)\%|\&(.+?)\&|\'(.+?)\'");
//            int count = 0;
//            while(regex.IsMatch(cleanedNakovText))
//            {
                
//                string result = regex.Match(cleanedNakovText).ToString();
//                char ch = result[0];
//               result= result.Remove(0, 1);
//                result=result.Remove(result.Count() - 1);
                
//                if (result.Contains("$")||result.Contains("%")||result.Contains("&")||result.Contains("\'"))
//                {
//                    cleanedNakovText = cleanedNakovText.Remove(0, cleanedNakovText.LastIndexOf(result) + result.Count());
//                    continue;
//                }
//                switch (ch)
//                {
//                    case '$':
//                        byte[] decode1 = Encoding.ASCII.GetBytes(result);
//                        String str1=String.Empty;
//                        for (int i = 0; i < decode1.Length; i++)
//                        {
//                            if (i%2==0)
//                            {
//                                decode1[i] = (byte)(decode1[i] + 1);
//                            }
//                            else
//                            {
//                                decode1[i] = (byte)(decode1[i] - 1);
//                            }
//                            str1 += (char) decode1[i];
//                        }
                        
//                        decifered.Add(str1);
//                        break;
//                    case '%':
//                        byte[] decode2 = Encoding.ASCII.GetBytes(result);
//                        string str2=String.Empty;
//                        for (int i = 0; i < decode2.Length; i++)
//                        {
//                            if (i % 2 == 0)
//                            {
//                                decode2[i] = (byte)(decode2[i] + 2);
//                            }
//                            else
//                            {
//                                decode2[i] = (byte)(decode2[i] - 2);
//                            }
//                            str2 += (char)decode2[i];
//                        }
                        
//                        decifered.Add(str2);
//                        break;

//                    case '&':
//                        byte[] decode3 = Encoding.ASCII.GetBytes(result);
//                        string str3=String.Empty;
//                        for (int i = 0; i < decode3.Length; i++)
//                        {
//                            if (i % 2 == 0)
//                            {
//                                decode3[i] = (byte)(decode3[i] + 3);
//                            }
//                            else
//                            {
//                                decode3[i] = (byte)(decode3[i] - 3);
//                            }
//                            str3 += (char)decode3[i];
//                        }
                        
//                        decifered.Add(str3);
//                        break;
//                    case '\'':
//                        byte[] decode4 = Encoding.ASCII.GetBytes(result);
//                        string str4=String.Empty;
//                        for (int i = 0; i < decode4.Length; i++)
//                        {
//                            if (i % 2 == 0)
//                            {
//                                decode4[i] = (byte)(decode4[i] + 4);
//                            }
//                            else
//                            {
//                                decode4[i] = (byte)(decode4[i] - 4);
//                            }
//                            str4 += (char)decode4[i];
//                        }
                        
//                        decifered.Add(str4);
//                        break;

//                }
//                cleanedNakovText = cleanedNakovText.Remove(0, cleanedNakovText.LastIndexOf(result)+result.Count());
//                count++;
//                //Console.WriteLine(result);
//                //Console.WriteLine(cleanedNakovText);
//                //Console.WriteLine(count);
//            }
//            foreach (var message in decifered)
//            {
//                Console.Write("{0} ",message);

//            }


//        }
//    }
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

public class TextTransformer
{
    public static void Main()
    {
        const string CapturePattern = @"([$%&'])([^$%&']+)\1";

        var specialSymbolWeights = new Dictionary<char, int>
        {
            {'$', 1},
            {'%', 2},
            {'&', 3},
            {'\'', 4}
        };

        StringBuilder sb = new StringBuilder();

        string input = Console.ReadLine();
        while (input != "burp")
        {
            sb.Append(input);
            input = Console.ReadLine();
        }

        string text = Regex.Replace(sb.ToString(), @"\s+", " ");
        Regex stringMatcher = new Regex(CapturePattern);
        var matches = stringMatcher.Matches(text);

        StringBuilder result = new StringBuilder();

        foreach (Match match in matches)
        {
            char specialSymbol = match.Groups[1].Value[0];
            string capturedString = match.Groups[2].Value;
            int stringLength = capturedString.Length;

            for (int i = 0; i < stringLength; i++)
            {
                char currentSymbol = capturedString[i];
                char resultingChar;

                if (i % 2 == 0)
                {
                    resultingChar = (char)(currentSymbol + specialSymbolWeights[specialSymbol]);

                }
                else
                {
                    resultingChar = (char)(currentSymbol - specialSymbolWeights[specialSymbol]);
                }

                result.Append(resultingChar);
            }

            result.Append(" ");
        }

        Console.WriteLine(result);
    }
}
