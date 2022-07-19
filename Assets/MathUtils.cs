using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathUtils : MonoBehaviour
{
    public static void MatMul(double[,] result, double[,] A, double[,] B)
    {
        int m = A.GetLength(0);
        int n = B.GetLength(1);
         
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[i, j] = 0.0;
                for (int k = 0; k < A.GetLength(1); k++)
                {
                    result[i, j] += A[i, k] * B[k, j];
                }
            }
        }
    }

    public static void Transpose(double[,] MT, double[,] M)
    {
        for (int i = 0; i < M.GetLength(0); i++)
        {
            for (int j = 0; j < M.GetLength(1); j++)
            {
                MT[i, j] = M[j, i];
            }
        }
    }
}
