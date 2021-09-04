using System;

namespace HomeWorkNumberTwelve
{
    public struct Product
    {
        private string _storeName;
        private string _productName;

        public string StoreName 
        { 
            get { return _storeName; } 
            set { _storeName = value; }
        }

        public string ProductName 
        {
            get { return _productName; }
            set { _productName = value; }
        }

        public static int CompareByStoreName(Product product, Product product1)
        {
            return string.Compare(product.StoreName, product1.StoreName);
        }
    }
}
