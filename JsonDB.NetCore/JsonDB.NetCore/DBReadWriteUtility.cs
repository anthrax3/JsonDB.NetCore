using System;
using System.Collections.Generic;
using System.Text;
/*
 *Jay Bhagat 8-31-17 
 */
namespace JsonDB.NetCore
{
    /// <summary>
    /// -Utility class
    /// Seeks the required number of bytes in the file
    /// required to read and write from the database
    /// </summary>
    public class DBReadWriteUtility
    {
        private byte[] SerializeToBytes<T>(JEntity<T> entity)
        {
            byte[] _serialized = new byte[0];
            
            return _serialized;
        }

        
    }
}
