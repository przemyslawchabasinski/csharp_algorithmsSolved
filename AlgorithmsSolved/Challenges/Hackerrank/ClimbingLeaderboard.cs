using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public class ClimbingLeaderboard
    {
        //https://www.hackerrank.com/challenges/climbing-the-leaderboard/problem
        //Fail case 6,7,8 and 9. Code did not execute within the time limits
        static int[] climbingLeaderboard(int[] scores, int[] alice)
        {
            int[] aliceRank = new int[alice.Length];
            int[] rank = new int[scores.Length];

            //Make dense rank
            rank[0] = 1;
            for (int i = 1; i < scores.Length; i++)
            {
                rank[i] = scores[i] == scores[i - 1] ? rank[i - 1] : rank[i - 1] + 1;
            }

            // I assume that first Allice score is out of the rank.
            aliceRank[0] = rank[scores.Length - 1] + 1;

            //Compate scores values with Alice            
            for (int i = 0; i < alice.Length; i++)
            {
                for (int j = 0; j < scores.Length; j++)
                {
                    if (alice[i] >= scores[j])
                    {
                        aliceRank[i] = rank[j];
                        break;
                    }
                }
            }
            return aliceRank;
        }

        static int[] climbingLeaderboard2(int[] scores, int[] alice)
        {
            int[] aliceRank = new int[alice.Length];
            int[] rank = new int[scores.Length];
            int end = 0;
            bool flag = true;

            //Make dense rank
            rank[0] = 1;
            for (int i = 1; i < scores.Length; i++)
            {
                rank[i] = scores[i] == scores[i - 1] ? rank[i - 1] : rank[i - 1] + 1;
            }

            //Remove duplicates
            scores = scores.Distinct().ToArray();
            rank = rank.Distinct().ToArray();

            // I assume that first Allice score is out of the rank.
            aliceRank[0] = rank[scores.Length - 1] + 1;

            end = scores.Length - 1;
            //Compate scores values with Alice            
            for (int i = 0; i < alice.Length; i++)
            {
                for (int j = end; j >= 0; j--)
                {
                    if (alice[i] >= scores[j])
                    {
                        flag = false;
                        aliceRank[i] = rank[j];
                        end = j - 1;
                    }
                    else
                    {
                        if (flag)
                            aliceRank[i] = rank[j] + 1;
                        break;
                    }
                }
            }
            aliceRank[aliceRank.Length - 1] = aliceRank[aliceRank.Length - 1] == 0 ? 1 : aliceRank[aliceRank.Length - 1];
            return aliceRank;
        }


        static int[] climbingLeaderboard3(int[] scores, int[] alice)
        {
            int[] aliceRank = new int[alice.Length];
            int[] rank = new int[scores.Length];
            bool find = false;

            //Make dense rank
            rank[0] = 1;
            for (int i = 1; i < scores.Length; i++)
            {
                rank[i] = scores[i] == scores[i - 1] ? rank[i - 1] : rank[i - 1] + 1;
            }

            //Remove duplicates
            scores = scores.Distinct().ToArray();
            rank = rank.Distinct().ToArray();
            int start = 0;
            for (int i = 0; i < alice.Length; i++)
            {
                if (alice[i] < scores[scores.Length - 1])
                {
                    aliceRank[i] = rank[scores.Length - 1] + 1;
                    start = i;
                }
                else { break; }
            }

            int index = 0;
            //Compate scores values with Alice            
            for (int i = start + 1; i < alice.Length; i++)
            {
                index = BinarySearch(scores, alice[i], out find);
                if (alice[i] < scores[index])
                    index -= 1;

                aliceRank[i] = rank[index < 0 ? 1 : index];
                index = 0;
            }
            return aliceRank;
        }


        public static int BinarySearch(int[] a, int item, out bool find)
        {
            int first = 0;
            int last = a.Length - 1;
            int mid = 0;
            find = false;
            do
            {
                mid = (first + last) / 2;
                if (item > a[mid])
                    last = mid - 1;
                else if (item < a[mid])
                    first = mid + 1;
                else
                {
                    find = true;
                    return mid;
                }
            } while (first <= last);
            return mid;
        }
    }
}
