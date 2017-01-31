using UnityEngine;

public class NPCData
{
    public string name;
    public string job;
    Vector3 position;
    Quaternion rotation;

    public NPCData(string name,string job,Vector3 initialPos,Quaternion initialRot)
    {
        this.name = name;
        this.job= job;
        this.position = initialPos;
        this.rotation = initialRot;
        Debug.Log("craft NPCData");
    }
    public Vector3 Position
    {
        get
        {
            return position;
        }
    }

    public Quaternion Rotation
    {
        get
        {
            return rotation;
        }
    }
}