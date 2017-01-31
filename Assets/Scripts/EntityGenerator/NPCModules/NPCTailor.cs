using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NPCTailor : ITailor, INPCComponent
{
    NPC NPCLinked;
    Material materialToSetUp;
    NPCData data;

    public NPCTailor(NPCData data)
    {
        this.data = data;
        Debug.Log("New NPCTailor Created");
    }


    private void setTheTexture(string job)
    {
       
    }

    public void setup(NPC NPCToBeLinked)
    {
        NPCLinked = NPCToBeLinked;
        materialToSetUp = NPCLinked.GetComponent<Renderer>().material;
        setTheTexture(data.job);
        NPCLinked.name = data.name;
        Debug.Log(String.Format("EndBinding Tailor:{0}, job : {1}", materialToSetUp.ToString(), data.job));
    }
}

