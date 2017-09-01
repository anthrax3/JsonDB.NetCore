using JsonDB.NetCore;
using System;
using System.IO;
/*
 *Jay Bhagat 8-31-17 
 */
namespace JsonDB.Testing
{
    public class TestProgram
    {
        public static void Main(string[] args)
        {
            //byte[] orig = File.ReadAllBytes(@"C:\Users\Public\do.bat");
            byte[] origObj = new TestClass() { ID = 1, Age = 20, Name = "James" }.SerializeJSONBytes();
            Console.WriteLine(string.Join("", origObj));
            byte[] result = origObj.PadBytes();
            Console.WriteLine(string.Join("", result));
            Console.WriteLine();

            byte[] unpadded = result.UnPadBytes();
            Console.WriteLine(string.Join("", unpadded));

            TestClass deser = unpadded.DeserializeJSONBytes<TestClass>();
            Console.ReadKey();
        }
    }

    class TestClass
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
