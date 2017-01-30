using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITailor
{

}
public class Tailor : ITailor
{
    Entity entityLinked;
    Material materialToSetUp;
    string job;

    public Tailor(Entity entityToBeLinked,string job)
    {
        this.job = job;
        entityLinked = entityToBeLinked;
        materialToSetUp = entityLinked.GetComponent<Renderer>().material;
        setTheTexture(job);
        entityLinked.gameObject.name = job;
        Debug.Log(String.Format("EndBindingTailor:{0}, job : {1}", materialToSetUp.ToString(),job));
    }

    private void setTheTexture(string job)
    {
       
    }
}

