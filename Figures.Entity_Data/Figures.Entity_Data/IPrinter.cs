namespace Figures.Entity_Data
{
    using System;
    using System.Data;
    using System.Collections.Generic;

    public interface IPrinter
    {
        void Print(int value, string end = "\n");
        void Print(string value, string end = "\n");
        void Print(long value, string end = "\n");
        void Print(float value, string end = "\n");
        void Print(double value, string end = "\n");
        void Print(decimal value, string end = "\n");
        void Print(char value, string end = "\n");
        void Print(bool value, string end = "\n");
        void Print(int[] value, string separator = "; ", string end = "\n");
        void Print(string[] value, string separator = "; ", string end = "\n");
        void Print(long[] value, string separator = "; ", string end = "\n");
        void Print(float[] value, string separator = "; ", string end = "\n");
        void Print(double[] value, string separator = "; ", string end = "\n");
        void Print(decimal[] value, string separator = "; ", string end = "\n");
        void Print(char[] value, string separator = "; ", string end = "\n");
        void Print(bool[] value, string separator = "; ", string end = "\n");
        void Print(DateTime value, string end = "\n");
        void Print(byte value, string end = "\n");
        void Print(sbyte value, string end = "\n");
        void Print(short value, string end = "\n");
        void Print(uint value, string end = "\n");
        void Print(ulong value, string end = "\n");
        void Print(ushort value, string end = "\n");
        void Print(HashSet<object> value, string separator = "; ", string end = "\n");
        void Print(List<object> value, string separator = "; ", string end = "\n");
        void Print(DataSet value, string separator = "; ", string end = "\n");
        void Print(IEnumerable<object> value, string end = "\n");
        void Print(Dictionary<object, object> value, string end = "\n");
        void Print(DataTable value, string separator = "; ", string end = "\n");
        void Print(DataRow value, string separator = "; ", string end = "\n");
        void Close();
        void Open();
    }
}
