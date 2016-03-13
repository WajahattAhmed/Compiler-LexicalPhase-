using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CompilerConstruction
{
    class LexicalPhase
    {
        public string[] keywords = new string[] {"bold","div","alpha","bit","twine","stop","current","obj","def","empty","begin","Continue","Either","Or","Or Either","At","Proc","Allign","Template"};
        public string[] Punctuators = new string[] {"(", ")", "{", "}",".."};
        public string WordBreaker = ",.:(){}='..' ";
      //  public string[] classPart;
    //    public string[] valuePart;
    //    int lineNo = 0;


        public void ReadFile()
        {
            string text;
                using (StreamReader sr = new StreamReader(@"C:\Users\Wajahat Ahmed\Desktop\Code.txt"))
                {
                    char[] Delimeters = WordBreaker.ToCharArray();
                    do
                    {
                        text = sr.ReadLine();
                        char[] temp = text.ToCharArray();

                        int i = 0, j = 1, k = 2;
                        Console.WriteLine("Here : {0},{1},{2}", temp[i], temp[j], temp[k]);

                    } while (text != ";");
                }
            }
        }
    }
