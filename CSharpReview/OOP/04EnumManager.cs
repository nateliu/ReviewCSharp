using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CSharpReview.OOP.Enumution
{
    /// <summary>
    /// 1,enum can’t be derived from any other type except that of type byte, sbyte, short, ushort, int, uint, long, or ulong.
    /// 2,enum is a sealed class and therefore sticks to all the rules that a sealed class follows, so no class can derive from enum.
    /// 3,enum type is implicitly derived from System.Enum and so we cannot explicitly derive it from System.Enum.
    /// 4,enum is also derived from three interfaces IComparable, IFormattable and IConvertible.
    /// </summary>
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine((int)UniqueIdType.CUSIP);
            Console.WriteLine(UniqueIdType.CUSIP);

            Console.WriteLine((int)UniqueIdType.CUSIP.ToNewUniqueIdType());
            Console.WriteLine(UniqueIdType.CUSIP.ToNewUniqueIdType());

            Console.WriteLine((int)UniqueIdType.ABC.ToNewUniqueIdType());
            Console.WriteLine(UniqueIdType.ABC.ToNewUniqueIdType());

            Console.ReadLine();
        }
    }


    public enum UniqueIdType
    {
        Invalid = -1,
        CUSIP = 0,
        ISIN = 1,
        ABC = ISIN,
    }

    public enum NewUniqueIdType
    {
        Invalid = -1,
        CUSIP = 1,
        ISIN = 2,
        SEDOL = 3,
    }

    public static class UniqueIdTypeManager
    {
        private static System.Collections.Generic.Dictionary<string, NewUniqueIdType> NewIdTypeDic = new System.Collections.Generic.Dictionary<string, NewUniqueIdType>();
        
        static UniqueIdTypeManager()
        {
            //foreach (FieldInfo fi in typeof(NewUniqueIdType).GetFields(BindingFlags.Public | BindingFlags.Static))
            //{
            //    NewIdTypeDic.Add(fi.Name, (NewUniqueIdType)fi.GetRawConstantValue());
            //}
            foreach (string name in Enum.GetNames(typeof(NewUniqueIdType)))
            {
                NewIdTypeDic.Add(name, (NewUniqueIdType)Enum.Parse(typeof(NewUniqueIdType), name));
            }
        }

        public static NewUniqueIdType ToNewUniqueIdType(this UniqueIdType uniqueIdType)
        {
            NewUniqueIdType newIdType = NewIdTypeDic.FirstOrDefault(x => x.Key == Enum.GetName(typeof(UniqueIdType), uniqueIdType)).Value;
            if (0 == (int)newIdType)
            {
                return NewUniqueIdType.Invalid;
            }
            else
            {
                return newIdType;
            }
        }
    }
}
