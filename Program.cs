
/**************************************************************
* Name        : First Come First Served Tickets
* Author      : Corey Connor
* Created     : 02/14/2022
* Course      : CIS152 21508 - Data Structures
* Version     : 1.0
* OS          : Windows 11
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : Generates a random number of customers and places them in a queue.
*               Customers then purchase a random number of tickets and are dequeued. 
*               Input:  None.
*               Output: # of customers served, # of customers remaining in queue.
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access to
* my program.      
***************************************************************/

using System;
using System.Collections.Generic;

namespace FirstComeFirstServedTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SimulateTicketQueue(10));
            Console.WriteLine(SimulateTicketQueue(100));
            Console.WriteLine(SimulateTicketQueue(1000));
        }
        static string SimulateTicketQueue(int tickets)
        {
            // Create customers, a queue, and a counter.
            int minCustomers = 1;
            int maxCustomers = 1001;
            int customers = new Random().Next(minCustomers, maxCustomers);
            Queue<int> customerQueue = new Queue<int>();
            int customerCounter = 0;

            // Add the customers to the queue.
            for (int i = 0; i < customers; i++)
            {
                customerQueue.Enqueue(i);
            }

            // While customers and tickets exist, sell tickets and count and dequeue the customer.
            while (customerQueue.Count > 0 && tickets > 0)
            {
                int minTickets = 1;
                int maxTickets = (tickets >= 4) ? maxTickets = 5 : maxTickets = 2;
                
                tickets -= new Random().Next(minTickets, maxTickets);
                customerCounter++;
                customerQueue.Dequeue();
            }

            // Return 
            return ($"Customers Served:\t{customerCounter}\n" + $"Customers Remaining:\t{customerQueue.Count}\n");
        }
    }
}