// See https://aka.ms/new-console-template for more information
word islem = new word();
List<string> words = new List<string>();
string s = islem.taker();
islem.wordchanger(s, words);
islem.printer(words);



class word
{
    public string taker()
    {
        Console.WriteLine("Please enter a word: ");
        string s = Console.ReadLine();
        return s;
    }
    public void wordchanger(string s, List<string> li)
    {
        string[] arr = s.Split(' ');
        foreach (string item in arr)
        {
            string s1 = item + item[0];
            string s2 = s1.Remove(0,1);
            li.Add(s2);
        }
    }
    public void printer(List<string> li)
    {
        foreach (string item in li)
        {
            Console.Write(item+" ");
        }
    }
}