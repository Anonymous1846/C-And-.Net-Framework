using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class Electricity
    {
        private String name_of_consumer;
        private  double net_usage,rate;
        
        public void setConsumer(String name)
        {
            name_of_consumer = name;
        }
        public void set_Usage(double usage)
        {
           
            net_usage = usage;
            if (net_usage <= 100)
            {
                rate = (60.00*net_usage)/100.00;
            }
            else if (net_usage > 100 && net_usage <= 300)
            {
                rate = ((100.00*60.00) + ((net_usage - 100) * 80.00) )/ 100.00;
            }
            else if (net_usage > 300)
            {
                rate = ((60.00*100.00) + (200.00 * 80.00) + ((net_usage - 300)*90.00))/100.00;
            }
        }
       
        public void showBill()
        {
            if (rate > 300.00)
            {
                rate += (0.15 * rate);
                Console.WriteLine("Consumer Name:{0}\nUsage:{1}\nNet Amount(With Surcharge):Rs {2}", name_of_consumer, net_usage, rate);
            }
            else if(rate<50)
            {
                rate = 50.00;
                Console.WriteLine("Consumer Name:{0}\nUsage:{1}\nNet Amount(No Surcharge):Rs {2}", name_of_consumer, net_usage, rate);
            }
            else
            {
                Console.WriteLine("Consumer Name:{0}\nUsage:{1}\nNet Amount(No Surcharge):Rs {2}", name_of_consumer, net_usage, rate);
            }
        }
    }
}
