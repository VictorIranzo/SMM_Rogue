﻿using UnityEngine;

namespace Completed
{
    public partial class BoardManager : MonoBehaviour
    {
        private string[,] GetLevel1() {
            string[,] level1 = new string[8, 8] {
                {   "",    "",     "",     "",     "",     "",     "",     ""},
                {   "",    "",     "",     "",     "",     "",     "",     ""},
                {   "",    "",     "",  EMPTY,     "",     "",     "",     ""},
                {   "",    "",     "",  EMPTY,     "",     "",     "",     ""},
                { WALL,  WALL,   WALL,  TRAMP,   WALL,   WALL,   WALL,   WALL},
                {   "",    "",     "",  EMPTY,     "",     "",     "",     ""},
                {   "",    "",  EMPTY,  EMPTY,     "",     "",     "",     ""},
                {   "",    "",     "",     "",     "",     "",     "",     ""},
            };
            return Transpose(level1);
        }

        public string[,] Transpose(string[,] matrix)
        {
            int w = matrix.GetLength(0);
            int h = matrix.GetLength(1);

            string[,] result = new string[h, w];

            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    result[j, i] = matrix[i, j];
                }
            }

            return result;
        }

    }
}
