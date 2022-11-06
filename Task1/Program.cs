using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>()
            {
               new Computer(){Number=1, Name = "Irbis", Model = "NB77", ProcessorType = "Intel", Core = 4, GHz = 1.33, RAM = 2, DiskMemory = 32, VideoMemory = 0, Price = 15000, Amount = 2 },
               new Computer(){Number=2, Name = "Lenovo", Model = "V15 G2 ALC", ProcessorType = "AMD", Core = 4,  GHz = 2.60, RAM = 4, DiskMemory = 256, VideoMemory = 0, Price = 36000, Amount = 10 },
               new Computer(){Number=3, Name = "ASUS VivoBook 15", Model = "X512DA-EJ992T", ProcessorType = "AMD", Core = 4,  GHz = 2.10, RAM = 6, DiskMemory = 1024, VideoMemory = 0, Price = 45000, Amount = 30 },
               new Computer(){Number=4, Name = "MSI GF76 Katana", Model = "11SC-483XRU", ProcessorType = "Intel", Core = 6,  GHz = 2.70, RAM = 8, DiskMemory = 256, VideoMemory = 4, Price = 65000, Amount = 40 },
               new Computer(){Number=5, Name = "HUAWEI", Model = "MateBook D 15 BoM-WDQ9", ProcessorType = "AMD", Core = 6,  GHz = 2.10, RAM = 8, DiskMemory = 256, VideoMemory = 0, Price = 53000, Amount = 35 },
               new Computer(){Number=6, Name = "GIGABYTE", Model = "G5 KD", ProcessorType = "Intel", Core = 6,  GHz = 2.70, RAM = 16, DiskMemory = 512, VideoMemory = 6, Price = 83000, Amount = 25 },
            };
            Console.WriteLine("Введите название процессора");                                               //определяем компьютеры с указанным процессором
            string processor = Console.ReadLine();
            List<Computer> computers1 = computers.Where(x => x.ProcessorType == processor).ToList();
            Print(computers1);
            

            Console.WriteLine("Введите объем ОЗУ");                                                          // определяем компьютеры с объемом ОЗУ не ниже, чем указано
            int ram = Convert.ToInt32(Console.ReadLine());
            List<Computer> computers2 = computers.Where(x => x.RAM >= ram).ToList();
            Print(computers2);
            Console.WriteLine("Нажмите что бы продолжить");
            Console.ReadLine();
             
            Console.WriteLine("Сортировка по цене");                                                           // сортировка по цене
            List<Computer> computers3 = computers.OrderBy(x => x.Price).ToList();
            Print(computers3);
            Console.WriteLine("Нажмите что бы продолжить");
            Console.ReadLine();

            Console.WriteLine("Сортировка по типу процессора");                                               // сортировка по типу процессора
            IEnumerable<IGrouping<string, Computer>> computers4 = computers.GroupBy(x => x.ProcessorType);
            foreach (IGrouping<string, Computer> gr in computers4)
            {
                Console.WriteLine(gr.Key);
                foreach (Computer e in gr)
                {
                    Console.WriteLine($"{e.Number} Название: {e.Name} Модель: {e.Model} Процессор: {e.ProcessorType} Кол-во ядер: {e.Core} " +
                        $"Частота ГГц:{e.GHz} ОЗУ: {e.RAM} Память: {e.DiskMemory} Видеопамять:{e.VideoMemory} Цена:{e.Price} шт. на складе: {e.Amount}");
                }
            }
            Console.WriteLine("Нажмите что бы продолжить");                                                          
            Console.ReadLine();

            Console.WriteLine("Самая высокая цена");                                                           //самая высокая цена
            Computer computers5 = computers.OrderByDescending(x => x.Price).FirstOrDefault();
            Console.WriteLine($"{computers5.Number} Название: {computers5.Name} Модель: {computers5.Model} Процессор: {computers5.ProcessorType} Кол-во ядер: {computers5.Core} " +
                $"Частота ГГц:{computers5.GHz} ОЗУ: {computers5.RAM} Память: {computers5.DiskMemory} Видеопамять:{computers5.VideoMemory} Цена:{computers5.Price} шт. на складе: {computers5.Amount}");
            Console.WriteLine("Нажмите что бы продолжить");
            Console.ReadLine();

            Console.WriteLine("Сама низкая цена");                                                              // самая низкая цена
            Computer computers6 = computers.OrderByDescending(x => -x.Price).FirstOrDefault();
            Console.WriteLine($"{computers6.Number} Название: {computers6.Name} Модель: {computers6.Model} Процессор: {computers6.ProcessorType} Кол-во ядер: {computers6.Core}" +
                $" Частота ГГц:{computers6.GHz} ОЗУ: {computers6.RAM} Память: {computers6.DiskMemory} Видеопамять:{computers6.VideoMemory} Цена:{computers6.Price} шт. на складе: {computers6.Amount}");
            Console.WriteLine("Нажмите что бы продолжить");
            Console.ReadLine();

            Console.WriteLine("Есть ли кол-во больше 30 шт.?");                                                // опеределяем есть ли количество более 30 шт.
            Console.WriteLine(computers.Any(x=>x.Amount > 30));

            Console.ReadKey();
        }
        static void Print(List<Computer> computers)
        {
            foreach (Computer e in computers)
            {
                Console.WriteLine($"{ e.Number} Название: {e.Name} Модель: {e.Model} Процессор: {e.ProcessorType} Кол-во ядер: {e.Core} " +
                    $"Частота ГГц:{e.GHz} ОЗУ: {e.RAM} Память: {e.DiskMemory} Видеопамять:{e.VideoMemory} Цена:{e.Price} шт. на складе: {e.Amount}");
            }
            Console.WriteLine();
        }
    }
}
