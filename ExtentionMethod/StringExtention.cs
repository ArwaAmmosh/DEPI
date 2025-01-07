namespace ExtentionMethod
{
    public static class StringExtention
    {
        public static string AddHelloWorld(this string text) 
        { 
            return $"Hello {text} !";
        }

    }
}
