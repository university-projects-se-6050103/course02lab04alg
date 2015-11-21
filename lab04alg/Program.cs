using System;
using System.IO;
using System.Text;

namespace lab04alg {
    class Program {
        static void Main() {
            InitUkrainianSupport();
            Console.WriteLine($"Скорочений дріб 124/568: {new FrationSimplifier(124, 568)}");
            Console.WriteLine("\nВведіть шлях MS-DOS: ");
            Console.WriteLine($"Шлях у форматі Unix: {new PathConvertor(Console.ReadLine()).Convert()}");
            var renameвITagText = new HTMLITagRenamer(File.ReadAllText(@"LAB5_1.txt", Encoding.UTF8)).RenameITag();
            Console.WriteLine($"\nЗаміна тегу <i> на <курсив>: {renameвITagText}");
            File.WriteAllText("LAB5_1.out", renameвITagText);
        }

        private static void InitUkrainianSupport() {
            Console.OutputEncoding = Encoding.GetEncoding("Cyrillic");
            Console.InputEncoding = Encoding.GetEncoding("Cyrillic");
        }
    }
}
