using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lab4
{
    class Voting
    {
        int[] count;
        int one, two, three, four, five, spoilt;
        public Voting()
        {
            count = new int[] {11,2,1,3,12,4,5,6,2,1,6,2,4,4,5,6,5,5121,2,2,2};
            one = 0;
            two = 0;
            three = 0;
            four = 0;
            five = 0;
            spoilt = 0;
        }
        public void count_votes()
        {
            for (int i = 0; i < count.Length; i++)
            {
                switch (count[i])
                {
                    case 1:
                        one++;
                        break;
                    case 2:
                        two++;
                        break;
                    case 3:
                        three++;
                        break;
                    case 4:
                        four++;
                        break;
                    case 5:
                        five++;
                        break;
                    default:
                        spoilt++;
                        break;
                }
               
            }
        }
        public void ShowResults()
        {
            int[] votes = new int[5];
             votes[0] = one;
             votes[1] = two;
             votes[2] = three;
             votes[3] = four;
             votes[4] = five;
             int max = votes[0];
             int pos = 1;
         
                for (int i = 1; i < 5; i++)
                {
                    if (max < votes[i])
                    {
                        max = votes[i];
                        pos = i+1 ;
                    }
                }
            if (Check_duplicates(votes,max))
            {
                Console.WriteLine("No Clear Winner !");
                showVoting();
            }
            else
            {
                Console.WriteLine("Candidate {0} Won The Election,With {1} Votes.", pos, max);
                showVoting();
            }
            
           
        }

        private void showVoting()
        {
            Console.WriteLine("*****Votes Gained By Each Candidate ******");
            Console.WriteLine("Canidate One:{0}\nCanidate Two:{1}\nCanidate Three:{2}\nCanidate Four:{3}\nCanidate Five:{4}\nSpoilt Votes:{5}",one,two,three,four,five,spoilt);
        }

        //Using Arrays and checking the duplicates.
        private static bool Check_duplicates(int[] arr,int max_value)
        {
            bool found = false;
            int count = 0;
            foreach (int i in arr)
            {               
                    if (i == max_value) { count++; }
            }
            if (count > 1)
                found = true;
            return found;  
        }
    }
    
      
    }


