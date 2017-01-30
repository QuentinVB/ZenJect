using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Zenject;

public class NPCSpawner : ITickable
{
    readonly NPCControler.Factory _NPCFactory;
    const float MIN_ENEMY_SPEED = 0.1f;
    const float MAX_ENEMY_SPEED = 2.0f;

    public NPCSpawner(NPCControler.Factory NPCFactory)
    {
        _NPCFactory = NPCFactory;
        Debug.Log("Installed NPCSpawner");
    }

    public void Tick()
    {
        if (ShouldSpawnNewNPC())
        {
            var newSpeed = UnityEngine.Random.Range(MIN_ENEMY_SPEED, MAX_ENEMY_SPEED);
            var npc = _NPCFactory.Create(newSpeed);
        }
        //Debug.Log("Tick");

    }

    private bool ShouldSpawnNewNPC()
    {
        return (Input.GetKeyDown(KeyCode.A)) ? true : false ;
    }
}


