using System; // here we defined 2 extension methods for the System.String class
namespace ExtensionMethods
{
    public static class MyExtensions
    {
        public static string[] WordArray(this String str){
            return str.Split(new char[] { ' ', '.', '?', '!'},
            StringSplitOptions.RemoveEmptyEntries);    
        }
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?', '!'},
            StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}