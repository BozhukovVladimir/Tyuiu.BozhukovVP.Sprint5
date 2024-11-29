using Tyuiu.BozhukovVP.Sprint5.Task7.V17.Lib;
namespace Tyuiu.BozhukovVP.Sprint5.Task7.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт №5 | Выполнил: Божуков В.П | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Божуков Владимир Павлович  | ИБКСб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл в котором есть набор символьных данных. Удалить все удвоенные  *");
            Console.WriteLine("* буквы 'нн' из файла .Полученный результат в OutPutDataFileTask7V17.txt. *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask7V17.txt");
            Console.WriteLine($"Данные находятся в файле: {path}");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Находится в файле:");
            Console.WriteLine(ds.LoadDataAndSave(path));
            Console.ReadKey();
        }
    }
}
