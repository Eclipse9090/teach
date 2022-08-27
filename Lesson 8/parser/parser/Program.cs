
namespace myProgram
{
    class TestClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название файла в виде [имя_файла].[формат]");
             string a = Console.ReadLine().ToLower();
            
             FileParser b = FileParser.GetParser(a);
            while (b == null)
            {
                Console.WriteLine("Название некорректное. Введите корректное название файла в виде[имя_файла].[формат]");
                a = Console.ReadLine().ToLower();
                b = FileParser.GetParser(a);
            }
            b.Parse();
        }
    }
}
