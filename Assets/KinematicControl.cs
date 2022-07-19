using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KinematicControl : MonoBehaviour
{
    private int n;
    private double[,] J;
    private double[,] JCross;
    private double[,] e;
    private double[,] qDot;

    public Transform[] joints;
    public Transform endEffector;
    public Transform goal;

    void Start()
    {
        n = joints.Length;
        J = new double[6, n];
        JCross = new double[n, 6];
        e = new double[6, 1];
        qDot = new double[6, 1];
    }

    void Update()
    {
        Jacobian(J);
        MathUtils.Transpose(JCross, J);
        CalculatePoseError(goal.position - endEffector.position, goal.eulerAngles - endEffector.eulerAngles);
        MathUtils.MatMul(qDot, JCross, e);

        for (int i = 0; i < n; i++)
            joints[i].Rotate(0.0f, 0.0f, (float)qDot[i, 0] * Time.deltaTime, Space.Self);
    }

    private void Jacobian(double[,] j)
    {
        for (int i = 0; i < n; i++)
        {
            Vector3 jpi = Vector3.Cross(joints[i].forward, endEffector.position - joints[i].position);
            Vector3 joi = joints[i].forward;

            j[0, i] = jpi.x;
            j[1, i] = jpi.y;
            j[2, i] = jpi.z;
            j[3, i] = joi.x;
            j[4, i] = joi.y;
            j[5, i] = joi.z;
        }
    }

    private void CalculatePoseError(Vector3 errorTranslation, Vector3 errorRotation)
    {
        e[0, 0] = errorTranslation.x;
        e[1, 0] = errorTranslation.y;
        e[2, 0] = errorTranslation.z;
        e[3, 0] = errorRotation.x;
        e[4, 0] = errorRotation.x;
        e[5, 0] = errorRotation.x;
    }
}
