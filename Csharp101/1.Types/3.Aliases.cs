using System;

namespace Csharp101_1._1.Types
{
    /// <summary>
    /// C# has aliases for a few types
    /// </summary>
    class Aliases
    {
        void Alias()
        {
            int isAnAliasForInt32 = new Int32();
            long isAnAliasForInt64 = new Int64();
            char isAnAliasForChar = new Char();
            object isAnAliasForObject = new Object();
            string isAnAliasForString = String.Empty;
            
            /*
                And there are a bunch more:
                    object:  System.Object
                    string:  System.String
                    bool:    System.Boolean
                    byte:    System.Byte
                    sbyte:   System.SByte
                    short:   System.Int16
                    ushort:  System.UInt16
                    int:     System.Int32
                    uint:    System.UInt32
                    long:    System.Int64
                    ulong:   System.UInt64
                    float:   System.Single
                    double:  System.Double
                    decimal: System.Decimal
                    char:    System.Char
                    
                See http://stackoverflow.com/questions/7074/in-c-sharp-whats-the-difference-between-string-and-string for more info
            */
        }
    }
}
