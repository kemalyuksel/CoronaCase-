namespace CoronaApi
{
    public static class ConvertEnglish
    {
        public static string ToEnglish(string word)
        {
            var fChar = word.Substring(0, 1);
            if (word.Contains("ıslands"))
            {
                word = word.Replace("ıslands", "Islands");
            }
            if (fChar == "i" || fChar == "ı" || fChar == "İ")
            {
                word = "I" + word.Substring(1, word.Length - 1);
            }
            word = word.Replace('ö', 'o');
            word = word.Replace('ü', 'u');
            word = word.Replace('ğ', 'g');
            word = word.Replace('ş', 's');
            word = word.Replace('ı', 'i');
            word = word.Replace('ç', 'c');
            word = word.Replace('Ö', 'O');
            word = word.Replace('Ü', 'U');
            word = word.Replace('Ğ', 'G');
            word = word.Replace('Ş', 'S');
            word = word.Replace('İ', 'i');
            word = word.Replace('Ç', 'C');

            return word;
        }
    }
}