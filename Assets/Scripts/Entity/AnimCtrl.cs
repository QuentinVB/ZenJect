using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AnimCtrl : IAnimCtrl
{
    Entity entityLinked;
    Animator animator;
    public AnimCtrl(Entity entityToBeLinked)
    {
        entityLinked = entityToBeLinked;
        animator = entityLinked.GetComponent<Animator>();
        Debug.Log("EndBindingAnimCtrl");
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
