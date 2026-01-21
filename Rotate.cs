using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Transform modelToRotate; // Assign your 3D model in inspector
    public float rotationAngle = 60f;

    public void RotateModelBy60Degrees()
    {
        if (modelToRotate != null)
        {
            modelToRotate.Rotate(0, rotationAngle, 0); // Rotate around Y-axis
        }
    }
}
