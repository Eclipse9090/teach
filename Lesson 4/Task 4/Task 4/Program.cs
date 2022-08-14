Dictionary <string, string> MyDictionary = new Dictionary <string, string>()
{
    {"book", "книга"},
    {"car", "автомобиль"},
    {"table", "стол"},
    {"chair", "стул"},
    {"school", "школа"},
    {"apple", "яблоко"},
    {"knife", "нож"},
    {"potato", "картошка"},
    {"bread", "хлеб"},
    {"garlic", "чеснок"},
};

Console.WriteLine("Введите слово на английском языке для перевода: ");
String a = Console.ReadLine();
String b = a.ToLower();
if (MyDictionary.ContainsKey(b))
    {
    Console.Write(MyDictionary[b]);
    }
    else
    {
        Console.WriteLine("Слово не было найдено");
    }