using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task13
{
    public class Stierlitz
    {
        public string Message;

        public Stierlitz(string message)
        {
            Message = message;
        }

        public Stierlitz Encrypt()
        {
            var alphabet = new List<char>()
            { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            
            var cypherArray = Message.ToLower().ToCharArray();
            var cypherList = new List<char>();
            var cypher = "";

            foreach (var i in cypherArray)
                if (Char.IsLetter(i))
                    cypherList.Add(i);

            for (var i = 0; i < cypherList.Count; i++)
            {
                if (i > cypherList.Count - 2)
                    break;

                if (cypherList[i] == cypherList[i + 1])
                    cypherList.RemoveAt(i + 1);
            }

            var rnd = new Random();
            var randomAmount = rnd.Next(Message.Length, 3 * Message.Length);

            for (var i = 0; i < randomAmount; i++)
            {
                var randomPosition = rnd.Next(0, cypherList.Count + 1);
                var randomLetter = rnd.Next(0, alphabet.Count);

                if (randomPosition <= cypherList.Count)
                {
                    cypherList.Insert(randomPosition, alphabet[randomLetter]);
                    cypherList.Insert(randomPosition, alphabet[randomLetter]);
                }

                else
                {
                    cypherList.Add(alphabet[randomLetter]);
                    cypherList.Add(alphabet[randomLetter]);
                }
            }

            foreach (var i in cypherList)
                cypher += i;

            return new Stierlitz(cypher);
        }

        public Stierlitz Decrypt()
        {
            var outputList = new List<char>();
            var output = "";
            var n = 0;

            foreach (var i in Message)
                outputList.Add(i);

            while (n != outputList.Count)
            {
                n = outputList.Count;

                for (var i = 0; i < outputList.Count; i++)
                {
                    if (i > outputList.Count - 2)
                        break;

                    if (outputList[i] == outputList[i + 1])
                    {
                        outputList.RemoveAt(i);
                        outputList.RemoveAt(i);
                    }  
                }
            }

            foreach (var i in outputList)
                output += i;
            
            return new Stierlitz(output);
        }
    }
}
