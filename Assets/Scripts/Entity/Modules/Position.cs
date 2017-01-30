using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionDirector : IPositionDirector
{

    public Vector3 Position
    {
        get
        {
            return Vector3.up*10f;
        }
    }

    public Quaternion Rotation
    {
        get
        {
            return Quaternion.Euler(0,0,0);
        }
    }
    public PositionDirector()
    {
        Debug.Log("EndBindingPositionDirector");

    }
}
