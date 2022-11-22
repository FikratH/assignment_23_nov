namespace assignment_23_nov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string again = "yes";
            while (again == "yes")
            {
                Console.WriteLine("Please enter an uncapitalized sentence:");
                string sentence = Console.ReadLine();
                Console.WriteLine(Capitalize(sentence));
                Console.Write("\nStart the app over? (yes/no): ");
                again = Console.ReadLine();
                Console.WriteLine(" ");
            }
        }
        static string Capitalize(string s) 
        {
            try
            {
                string lowerWords = s.ToLower();
                string[] words = lowerWords.Split(' ');
                #region For Each Solution (couldn't solve **return**)
                //foreach (string word in words)
                //{
                //    string wordToChange = (string) word.Clone(); 
                //    string firstLetter = wordToChange[0].ToString().ToUpper();
                //    //string newWord = word.Replace(word[0], Convert.ToChar(firstLetter));
                //    string newWord = word.Remove(0, 1).Insert(0,firstLetter);
                //    Console.Write(newWord + " ");
                //} 
                #endregion
                #region For Solution (everything works properly
                for (int i = 0; i < words.Length; i++)
                {
                    string wordToChange = (string)words[i].Clone();
                    string firstLetter = wordToChange[0].ToString().ToUpper();
                    words[i] = words[i].Remove(0, 1).Insert(0, firstLetter);
                }
                string sentence = string.Join(" ", words);
                #endregion
                return sentence;
            }
            catch (Exception ex)
            {
                return "An error occured! Error info: " + ex.Message;
            }
        }
    }
}