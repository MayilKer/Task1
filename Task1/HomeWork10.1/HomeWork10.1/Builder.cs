using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork10._1
{
    class Builder
    {
        public string Word;

        public Builder(string word)
        {
            this.Word = word;
            string result = string.Empty;
            StringBuilder sb = new StringBuilder();
            StringBuilder rb = new StringBuilder();
            StringBuilder fb = new StringBuilder();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                sb.Append(word[i]);
              
            }

             

          for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == ' ')
                {
                    break;
                }

                rb.Append(sb[i]);
                
            }
            


            for (int i = 0; i < word.Length ; i++)
            {
                if (word[i] == ' ')
                {
                    break;
                }
                result += word[i];
            }
            for (int i = result.Length-1; i >= 0; i--)
            {
                fb.Append(result[i]);
            }
            
            Console.WriteLine(fb + " " + rb);



        }
        


    }
}
