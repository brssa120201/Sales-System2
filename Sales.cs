using System;
using System.Collections.Generic;
using System.Text;

namespace System_Sales
{
    class Sales
    {
        public Seller Seller;
        public Product Product;
                    
        public int Comments; //0: Home services; 1: No home services

        public void SetComments(int newComments)
        {
            if (newComments == 0 || newComments == 1)
            {
                Comments = newComments;
            }
            else
            {
                Console.WriteLine("La venta del producto " + Product.Name + " no puede ser realizada");
            }
        }

        public int GetComments()
        {
            return Comments;
        }


    }
}
