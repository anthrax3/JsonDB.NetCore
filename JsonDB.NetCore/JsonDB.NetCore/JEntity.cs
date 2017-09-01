using System;
using System.Collections.Generic;
using System.Text;
/*
 *Jay Bhagat 8-31-17 
 */
namespace JsonDB.NetCore
{
    /// <summary>
    /// The wrapper class for A JsonDB 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class JEntity<T>
    {
        public T Entity { get; set; }
        
    }
}
