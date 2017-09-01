using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
/*
 *Jay Bhagat 8-31-17 
 */
namespace JsonDB.NetCore
{
    public static class Extensions
    {
        /// <summary>
        /// Used to pad the byte array to a fixed amount of bytes
        /// </summary>
        /// <param name="input"></param>
        /// <param name="paddingCount"></param>
        /// <param name="bytepad"></param>
        /// <returns></returns>
        public static byte[] PadBytes(this byte[] input, byte bytepad = Constants.BYTE_PAD)
        {
            int totalPadLen = Constants.BLOCK_WIDTH_BYTES - input.Length % Constants.BLOCK_WIDTH_BYTES;
            int inputLen = input.Length;
            byte[] array = new byte[inputLen + totalPadLen];
            int outputLen = array.Length;
            for (int i = 0; i < inputLen; i++)
            {
                array[i] = input[i];
            }
            for (int i = inputLen; i < outputLen - 1; i++)
            {
                array[i] = bytepad;
            }
            array[outputLen - 1] = (byte)(totalPadLen - 1);
            return array;
        }

        public static byte[] UnPadBytes(this byte[] input)
        {
            int amountOfPad = (int)input[input.Length - 1];
            int outputLen = input.Length - (1 + amountOfPad);
            byte[] array = new byte[outputLen];
            for (int i = 0; i < outputLen; i++)
            {
                array[i] = input[i];
            }
            return array;
        }

        public static T DeserializeJSONBytes<T>(this byte[] input)
        {
            string original = string.Join("", input.Select(a => (char)a));
            return JsonConvert.DeserializeObject<T>(original);
        }

        public static byte[] SerializeJSONBytes<T>(this T obj)
        {
            string objstring = JsonConvert.SerializeObject(obj);
            return objstring.Select(a => (byte) a).ToArray();
        }
    }
}
