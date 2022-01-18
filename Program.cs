using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Drawing;

namespace MainForm
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyMainForm());
        }
    }

    public static class Basket
    {
        public static int FullPrice = 0;
    }

    static class Calculator
    {
        public static double ComputeArea(double length, double width)
        {
            return length * width;
        }

        public static int NumberPacksTiles(double size)
        {
            if (size % 10 == 0)
                return (int)(size / 10);
            else
                return (int)(size / 10 + 1);
        }
    }

    public class Tile
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int PriceOfOnePack { get; set; }
        public int Count { get; set; }

        public Tile()
        {

        }
        public Tile(string name, string descriptions, int price, int count)
        {
            this.Name = name;
            this.PriceOfOnePack = price;
            this.Description = descriptions;
            this.Count = count;
        }

        public override string ToString()
        {
            return $"Название: {Name}  " +
                $"\nОписание: {Description}  " +
                $"\nЦена за одну пачку (10 кв. м.) в руб.: {PriceOfOnePack}  " +
                $"\nПачек в наличии (шт.): {Count}";
        }
    }

    public class Data
    {
        public static List<Tile> ListTile = Data.ReadFromFile().Split('\n')
               .Select(x => x.Split(','))
               .Select(tile => new Tile(tile[0], tile[1], int.Parse(tile[2]), int.Parse(tile[3])))
               .ToList();
        public static string ReadFromFile()
        {
            using (FileStream fstream = File.OpenRead(@"C:\Users\User\Desktop\2 курс\ПИ.Лабы\курсач\MainForm\MainForm\bin\Debug\MyFile.txt"))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                string myText = Encoding.Default.GetString(array);
                Console.WriteLine(myText);
                return myText;
            }
        }
    }
}
