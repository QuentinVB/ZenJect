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

    FactoryAnimation _animationFactory;
    FactoryPathfinding _pathfindingFactory;
    FactoryTailor _tailorFactory;

    QuestManager _questManager;

    public NPCSpawner(
        QuestManager questManager,
        FactoryAnimation animationFactory,
        FactoryPathfinding pathfindingFactory,
        FactoryTailor tailorFactory,
        NPC.Factory NPCFactory
        )
    {
        _questManager=questManager;
        _NPCFactory = NPCFactory;
        _animationFactory = animationFactory;
        _tailorFactory = tailorFactory;
        _pathfindingFactory = pathfindingFactory;

        Debug.Log("End NPCSpawner");
    }


    public void Tick()
    {
        if(ShouldSpawnNewNPC())
        {
            Debug.Log("Start Factory NPC");
            var data = _questManager.createNewNpc();            
            //var newSpeed = UnityEngine.Random.Range(MIN_ENEMY_SPEED, MAX_ENEMY_SPEED);
            var newAnimCtrl = _animationFactory.Create(data);
            var newPathfinding = _pathfindingFactory.Create(data);
            var newTailor = _tailorFactory.Create(data);
            var npc = _NPCFactory.Create(newTailor, _questManager, data, newAnimCtrl, newPathfinding);
            Debug.Log("End Factory NPC");
        }
        //Debug.Log("Tick");
    }

    private bool ShouldSpawnNewNPC()
    {
        return (Input.GetKeyDown(KeyCode.A)) ? true : false;
    }
}

