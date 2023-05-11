namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Реализуйте метод, который запрашивает у пользователя ввод дробного числа (типа float),
            //и возвращает введенное значение. Ввод текста вместо числа не должно приводить к падению приложения,
            //вместо этого, необходимо повторно запросить у пользователя ввод данных.

            void Number()
            {
                try
                {
                    Console.Write("Введите число: ");
                    float num = float.Parse(Console.ReadLine());
                    Console.WriteLine(num);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверно введенные данные, повторите попытку!!!");
                    Number();
                }
            }

            //Разработайте программу, которая выбросит Exception,
            //когда пользователь вводит пустую строку. Пользователю должно показаться сообщение,
            //что пустые строки вводить нельзя.



            void EnterStrings()
            {
                Console.Write("Введите строку: ");
                string input = Console.ReadLine();
                try
                {
                    if (String.IsNullOrEmpty(input))
                    {
                        throw new Exception("Строка пуста!!!");
                    }
                    Console.WriteLine($"Вы ввели: {input}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}