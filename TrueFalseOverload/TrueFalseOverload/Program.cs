using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueFalseOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlBoolean a = SqlBoolean.Null;
            if (a)
            {
                Console.WriteLine("True");
            }
            else if (!a)
            {
                Console.WriteLine("False");
            }
            else
                Console.WriteLine("Null");
            Console.ReadKey();

        }

        public struct SqlBoolean
        {
            public static bool operator true(SqlBoolean x)
            {
                return (x.m_value == True.m_value);
            }

            public static bool operator false(SqlBoolean x)
            {
                return (x.m_value == False.m_value);
            }

            public static SqlBoolean operator !(SqlBoolean x)
            {
                if (x.m_value == Null.m_value) return Null;
                if (x.m_value == False.m_value) return True;
                return False;
            }

            public static readonly SqlBoolean Null = new SqlBoolean(0);
            public static readonly SqlBoolean False = new SqlBoolean(1);
            public static readonly SqlBoolean True = new SqlBoolean(2);

            private SqlBoolean(byte value) { m_value = value; }
            private byte m_value;
        }
    }
}
