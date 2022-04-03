using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._04._2022RoomClass
{
    class NotAvailableException:Exception
    {
        public NotAvailableException(string massage):base(massage)
        {
            try
            {
                if (IsAvailable == false)
                {
                 throw new NotAvailableException ("otaq reserve olunmayib");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public bool IsAvailable { get; }
    }
}
