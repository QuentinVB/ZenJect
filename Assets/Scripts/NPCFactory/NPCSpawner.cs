using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Zenject;

public class NPCSpawner : ITickable
{
    readonly NPC.Factory _NPCFactory;
    const float MIN_ENEMY_SPEED = 0.1f;
    const float MAX_ENEMY_SPEED = 0.5f;

    IPositionDirector _position;
    //IAnimCtrl _animationControl;


    public NPCSpawner(NPC.Factory NPCFactory, IPositionDirector position/*, IAnimCtrl animationControl*/)
    {
        _NPCFactory = NPCFactory;
        _position = position;
        //_animationControl = animationControl;

        Debug.Log("Installed NPCSpawner");
    }


    public void Tick()
    {
        if (ShouldSpawnNewNPC())
        {
            var newSpeed = UnityEngine.Random.Range(MIN_ENEMY_SPEED, MAX_ENEMY_SPEED);
            var npc = _NPCFactory.Create(/*_animationControl,*/_position, newSpeed);
        }
        //Debug.Log("Tick");
    }

    private bool ShouldSpawnNewNPC()
    {
        return (Input.GetKeyDown(KeyCode.A)) ? true : false;
    }
}

