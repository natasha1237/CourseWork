namespace Figures.UI
{
    using System;
    using System.Data;
    using Figures.Entity_Data;
    using System.Collections.Generic;

    public class PrinterConsole : IPrinter
    {
        public void Close()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("The End! Press any key");
            Console.ResetColor();
            Console.ReadKey();
            Console.WriteLine();
        }

        public void Open() { }
        public void Print(IEnumerable<object> value, string end = "; ")
        {
            foreach (var v in value) Print(v, end);
        }

        public void Print(object value, string end = "\n")
        {
            Console.Write(value);
            Console.Write(end);
        }

        public void Print(int value, string end = "\n")
        {
            Console.Write(value);
            Console.Write(end);
        }

        public void Print(string value, string end = "\n")
        {
            Console.Write(value);
            Console.Write(end);
        }

        public void Print(long value, string end = "\n")
        {
            Console.Write(value);
            Console.Write(end);
        }

        public void Print(float value, string end = "\n")
        {
            Console.Write(value);
            Console.Write(end);
        }

        public void Print(double value, string end = "\n")
        {
            Console.Write(value);
            Console.Write(end);
        }

        public void Print(decimal value, string end = "\n")
        {
            Console.Write(value);
            Console.Write(end);
        }

        public void Print(char value, string end = "\n")
        {
            Console.Write(value);
            Console.Write(end);
        }

        public void Print(bool value, string end = "\n")
        {
            Console.Write(value);
            Console.Write(end);
        }

        public void Print(int[] value, string separator = "; ", string end = "\n")
        {
            foreach (var v in value)
            {
                Print(v, separator);
            }
            Console.Write(end);
        }

        public void Print(string[] value, string separator = "; ", string end = "; ")
        {
            foreach (var v in value)
            {
                Print(v, separator);
            }
            Console.Write(end);
        }

        public void Print(long[] value, string separator = "; ", string end = "; ")
        {
            foreach (var v in value)
            {
                Print(v, separator);
            }
            Console.Write(end);
        }

        public void Print(float[] value, string separator = "; ", string end = "; ")
        {
            foreach (var v in value)
            {
                Print(v, separator);
            }
            Console.Write(end);
        }

        public void Print(double[] value, string separator = "; ", string end = "; ")
        {
            foreach (var v in value)
            {
                Print(v, separator);
            }
            Console.Write(end);
        }

        public void Print(decimal[] value, string separator = "; ", string end = "; ")
        {
            foreach (var v in value)
            {
                Print(v, separator);
            }
            Console.Write(end);
        }

        public void Print(char[] value, string separator = "; ", string end = ";")
        {
            foreach (var v in value)
            {
                Print(v, separator);
            }
            Console.Write(end);
        }

        public void Print(bool[] value, string separator = "; ", string end = "; ")
        {
            foreach (var v in value)
            {
                Print(v, separator);
            }
            Console.Write(end);
        }

        public void Print(byte value, string end = "\n")
        {
            Console.Write(value);
            Console.Write(end);
        }

        public void Print(sbyte value, string end = "\n")
        {
            Console.Write(value);
            Console.Write(end);
        }

        public void Print(short value, string end = "\n")
        {
            Console.Write(value);
            Console.Write(end);
        }

        public void Print(uint value, string end = "\n")
        {
            Console.Write(value);
            Console.Write(end);
        }

        public void Print(ulong value, string end = "\n")
        {
            Console.Write(value);
            Console.Write(end);
        }

        public void Print(ushort value, string end = "\n")
        {
            Console.Write(value);
            Console.Write(end);
        }

        public void Print(HashSet<object> value, string separator = "; ", string end = "; ")
        {
            foreach (var v in value)
            {
                Console.Write(v + separator);
            }
            Console.Write(end);
        }

        public void Print(List<object> value, string separator = "; ", string end = "; ")
        {
            foreach (var v in value)
            {
                Console.Write(v + separator);
            }
            Console.WriteLine(end);
        }
        public void Print(DataRow value, string separator, string end = "\n")
        {
            foreach (var obj in value.ItemArray)
            {
                Console.Write(obj + separator);
            }
            Console.Write(end);
        }
        public void Print(DataTable value, string separator, string end = "\n")
        {
            Console.WriteLine(value.TableName + ":");
            foreach (var col in value.Columns)
            {
                Console.Write(col + separator);
            }
            Console.WriteLine();
            foreach (DataRow row in value.Rows)
            {
                Print(row, separator, "\n");
            }
            Console.WriteLine("\n");
        }
        public void Print(DataSet value, string separator, string end = "\n")
        {
            foreach (DataTable dt in value.Tables)
            {
                Print(dt, separator, "\n");
            }
            Console.Write(end);
        }


        public void Print(DateTime value, string end = "\n")
        {
            Console.Write(value.ToString() + end);

        }

        public void Print(Dictionary<object, object> value, string end = "\n")
        {
            foreach (var key in value.Keys)
            {
                Console.Write(key + ":\t");
                Print(value[key]);
            }
        }
    }
}
