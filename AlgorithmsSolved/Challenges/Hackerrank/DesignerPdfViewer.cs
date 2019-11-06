using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsSolved.Challenges.Hackerrank
{
    public class DesignerPdfViewer
    {
        //int[] vs = new int[] { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
        //string word = "abc";
        //int[] vs = new int[] { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7 };
        //string word = "zaba";
        //var result = designerPdfViewer(vs, word);
        //Console.WriteLine(result);

        // https://www.hackerrank.com/challenges/designer-pdf-viewer/problem
        static int designerPdfViewer(int[] h, string word)
        {
            //char[] vs = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y' };
            Dictionary<char, int> alphabet = new Dictionary<char, int>()
            {
                { 'a', 1 },{'b', 2 },{ 'c', 3 },
                { 'd', 4 },{ 'e', 5 },{ 'f',6 },
                { 'g', 7 },{ 'h', 8 },{ 'i', 9 },
                { 'j', 10 },{ 'k', 11 },{ 'l', 12 },
                { 'm', 13 },{ 'n', 14 },{ 'o', 15},
                { 'p', 16 },{ 'q', 17 },{ 'r', 18 },
                { 's', 19 },{ 't', 20 },{ 'u', 21 },
                { 'v', 22 },{ 'w', 23 },{ 'x', 24 },
                { 'y', 25 },{ 'z', 26 }
            };
            int positionInAlphabet = 0;
            int maxHeight = 0;

            for (int i = 0; i < word.Length; i++)
            {
                positionInAlphabet = alphabet[word[i]];
                if (maxHeight < h[positionInAlphabet - 1])
                    maxHeight = h[positionInAlphabet - 1];
            }

            return maxHeight * word.Length;
        }
    }
}
