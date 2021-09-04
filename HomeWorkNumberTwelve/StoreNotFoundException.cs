using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkNumberTwelve
{
    public class StoreNotFoundException : Exception
    {
        public StoreNotFoundException(string storeName)
            : base($"Магазина с названием {storeName} не существует ")
        {
        }
    }
}
