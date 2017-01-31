using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NPCAnimCtrl : IAnimCtrl, INPCComponent
{
    NPC NPCLinked;
    NPCData data;
    Animator animator;

    public NPCAnimCtrl(NPCData data)
    {
        this.data = data;
        Debug.Log("New NPCAnimCtrl Created");

    }
    public void setup(NPC NPCToBeLinked)
    {
        NPCLinked = NPCToBeLinked;
        animator = NPCLinked.GetComponent<Animator>();
        Debug.Log("EndBinding NPCAnimCtrl");
    }
    public void updateAnimation(int playThis)
    {
        animationSwitch(playThis);
    }
    private void animationSwitch(int playThis)
    {
        switch (playThis)
        {
            case 0:
                animator.Play("Roll", 0, 0f);
                break;
            default:
                break;
        }

    }
}
