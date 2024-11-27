using Tyuiu.BozhukovVP.Sprint5.Task6.V25.Lib;
namespace Tyuiu.BozhukovVP.Sprint5.Task6.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Божуков В. П. | ИБКСб-24-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Обработка файлов                                                   *");
            Console.WriteLine("* Задание #6                                                               *");
            Console.WriteLine("* Вариант #25                                                              *");
            Console.WriteLine("* Выполнил: Божуков Владимир Павлович | ИБКСб-24-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Дан файл С:/DataSprint5/InPutDataFileTask6V25.txt (файл взять из архива  *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С:/DataSprint5/ и       *");
            Console.WriteLine("* скопировать в неё файл) в котором есть вещественное значение. Найти      *");
            Console.WriteLine("* количество знаков восклицания в заданной строке.                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            string path = @"C:\Sprint5\InPutDataFileTask6V25.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            int res = ds.LoadFromDataFile(path);

            Console.WriteLine("Количество восклицательных знаков в строке: " + res);
            Console.ReadKey();
        }
    }
}
