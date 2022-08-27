/*4. Написать валютный калькулятор:
4.1 Программа должна обладать следующим функционалом:
   -Программа должна создавать CurrencyConverter с разными курсами валют(СurrencyConverter.AddExchangeRate()). Можно добавить до 10 разных курсов, придумать самим
   - Отображать пользователю имеющиеся курсы - CurrencyConverter.ToString()
   -Конвертировать валюты и отображать полученный результат - пользователь вводит название валюты, название валюты в которую необходимо выполнить конвертацию и значение,
указывающие объем первой валюты

 4.2 Программа должна содержать следующие сущности(каждая сущность в отдельном классе):
  -Перечисление Currencies – можно добавить до 10 разных валют.
  - Класс ExchangeRate. Поля класса: Currencies FirstCurrency, Currencies SecondCurrency, float Value,
    int CurrencyCount = 1. Методы: public override string ToString() (данный метод должен возвращать строку в следующем виде “{CurrencyCount} { FirstCurrency} = { Value}
{ SecondCurrency}”, например “1,00 USD = 36,76 RUB “, значения CurrencyCount и Value должно отображаться с точностью до двух знаков после запятой);
Конструктор, который принимает  либо два параметра типа Currencies, либо три параметра  - Currencies, Currencies, float, в конструкторе установить значения полей;
SetValue(float value), который будет изменять значение поля Value; SetCount(int count), который будет изменять значение поля CurrencyCount. 

 - Класс CurrencyConverter. Поля:  List<ExchangeRate> ExchangeRates, которое должно инициализироваться в конструкторе. Методы: AddExchangeRate(ExchangeRate) и 
    AddExchangeRates(ExchangeRate[])  – добавление экземпляров ExchangeRate в список List<ExchangeRate>; TryDeleteExchangeRate(Currencies firstCurrency,
        Currencies secondCurrency) – попытка найти и удалить ExchangeRate из ExchangeRates; FindExchangeRate(Currencies firstCurrency, Currencies secondCurrency)
поиск в ExchangeRates;
public override string ToString() – метод должен выводить список всех курсов, которые хранятся в ExchangeRates (необходимо использовать StringBuilder и цикл foreach);
Convert(Currcencies CurrcencyFirst, Currencies CurrencySecond, int count) – метод выполняет поиск поиск нужного ExchangeRate в List<ExchangeRate>,*/





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public enum currencies
    {
        usd, 
        eur,
        rub,
        byn,
        uah,
        pln,
        gbp,
        cny,
        kzt,
        chf
    }
    public class ExchangeRate
    {
        public currencies FirstCurrency;
        public currencies SecondCurrency;
        public float Value { get; set; }
        public int CurrencyCount { get; set; } = 1;
        public ExchangeRate(currencies a, currencies b )
        {
            FirstCurrency = a;
            SecondCurrency = b;
        }
        public ExchangeRate(currencies a, currencies b, float c):this(a, b)
        {
           Value = c;
        }
        public float SetValue(float Value)
        {
            return this.Value = Value;
        }
        //задаем курс в эземпляр класса
        public int SetCount(int count)
        {
            return CurrencyCount = count;
        }

        //данный метод должен возвращать строку в следующем виде “{CurrencyCount} {FirstCurrency} = {Value} {SecondCurrency}”, например “1,00 USD = 36,76 RUB “,
        public override string ToString()
        {
            FirstCurrency.ToString();
            CurrencyCount.ToString();
            SecondCurrency.ToString();
            Value.ToString();
            String StringOut = $"{CurrencyCount:f2} {FirstCurrency} = {Value:f2} {SecondCurrency}";
            return StringOut;
        }
    }


    public class CurrencyConverter
    {
        public List<ExchangeRate> ExchangeRates;

       public CurrencyConverter()
        {
            ExchangeRates = new List<ExchangeRate>();
        }

        public void AddExchangeRate(ExchangeRate exchangeRate)
        {
            ExchangeRates.Add(exchangeRate);
        }


        public void AddExchangeRates(ExchangeRate[] exchangeRate)
        {
            foreach (ExchangeRate a in exchangeRate)
            {
                ExchangeRates.Add(a);
            }
        }

        public bool TryDeleteExchangeRate(currencies firstCurrency, currencies secondCurrency)
         {
            if (FindExchangeRate(firstCurrency, secondCurrency) != null)
            {
                ExchangeRates.Remove(FindExchangeRate(firstCurrency, secondCurrency));
                return true;
            }
            else return false;
        }

        public ExchangeRate FindExchangeRate(currencies firstCurrency, currencies secondCurrency)
          {
            foreach(ExchangeRate exchangeRate in ExchangeRates)
            {
                if ((exchangeRate.FirstCurrency == firstCurrency) && (exchangeRate.SecondCurrency == secondCurrency)||
                    (exchangeRate.FirstCurrency==secondCurrency) && (exchangeRate.SecondCurrency==firstCurrency))
                {
                    return exchangeRate;
                }
            }
            return null;
          }
        
        public override string ToString()
        {
            StringBuilder my = new StringBuilder();
            foreach (var exchangeRate in ExchangeRates)
            {
                my.Append(exchangeRate + "\n");
            }
            return my.ToString();
        }
        public ExchangeRate Convert(currencies CurrencyFirst, currencies CurrencySecond, int count)
        {
            ExchangeRate Find = FindExchangeRate(CurrencyFirst, CurrencySecond);
            ExchangeRate myExchange;
            if(Find !=null)
            {
                myExchange = new ExchangeRate(CurrencyFirst, CurrencySecond, count);
                if (Find.FirstCurrency == CurrencyFirst && Find.SecondCurrency == CurrencySecond)
                {
                    myExchange.CurrencyCount = count;
                    myExchange.Value = Find.Value * count;
                }
                else
                {
                    myExchange.CurrencyCount = count;
                    myExchange.Value = 1 / Find.Value * count;
                }
                return myExchange;
            }
            else
            {
                return null;
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            CurrencyConverter currencyConverter = new CurrencyConverter();
            Random random = new Random();
            int[,] numbers = new int[10, 3];
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                numbers[i, 2] = random.Next(50, 200);
                do
                {
                    numbers[i, 0] = random.Next(0, numbers.GetLength(0));
                    numbers[i, 1] = random.Next(0, numbers.GetLength(0));
                }
                
                while ((numbers[i, 0] == numbers[i, 1]) || (!(currencyConverter.FindExchangeRate((currencies)numbers[i, 0], (currencies)numbers[i, 1]) == null)));

                ExchangeRate exchangeRate = new((currencies)numbers[i, 0], (currencies)numbers[i, 1], (float)numbers[i, 2] / 100);
                currencyConverter.AddExchangeRate(exchangeRate);
            }

            Console.WriteLine("Валютные пары с которыми мы работаем:");
            Console.WriteLine(currencyConverter);

            while (true)
            {
                Console.WriteLine("Введите валюту");
                string bablo1 = Console.ReadLine();
                Console.WriteLine("Введите валюту, на которую хотите поменять");
                string bablo2 = Console.ReadLine();
                Console.WriteLine("Введите сумму");
                int howMoney = Convert.ToInt32(Console.ReadLine());

                currencies value1;
                currencies value2;
                if (Enum.TryParse(bablo1, out value1) && Enum.TryParse(bablo2, out value2))
                {
                    if (currencyConverter.Convert(value1, value2, howMoney) == null)
                    {
                        Console.WriteLine("Банк не работает с такими валютными парами");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(currencyConverter.Convert(value1, value2, howMoney));
                        Console.WriteLine("Спасибо");
                        break;
                    }
                }

            }

        }
    }
}