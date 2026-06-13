public static class Greeter
{
    public static string Greet(string name) => $"Hello, {name}!";
    public static int CountVowels(string s)
    {
        int count = 0;
        foreach (var c in s.ToLower())
            if ("aeiou".Contains(c)) count++;
        return count;
    }
}
adsadasdasd