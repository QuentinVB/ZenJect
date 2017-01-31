using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class QuestManager 
{
    public QuestManager()
    {
        Debug.Log("Created QuestManager");
        //DO THINGs HERE
    }

    public NPCData createNewNpc()
    {
        string uuid = Guid.NewGuid().ToString();
        Vector3 pos = new Vector3(UnityEngine.Random.Range(-2, 2), 1, UnityEngine.Random.Range(-2, 2));
        Debug.Log(string.Format("uuid : {0}, pos {1}", uuid, pos.ToString()));
        return new NPCData(uuid, "forgeron", pos, Quaternion.Euler(0,0,0));
    }
}

