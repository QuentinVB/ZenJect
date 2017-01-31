using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pathfinding : IPathfinding
{
    Entity entityLinked;
    Rigidbody rigidBody;
    NavMeshAgent agent;
    public Vector3 Direction { get { return Vector3.forward; } }
    public Quaternion Orientation { get { return Quaternion.Euler(0, 0.1f, 0); } }

    public Pathfinding(Entity entityToBeLinked)
    {
        entityLinked = entityToBeLinked;
        rigidBody= entityLinked.gameObject.AddComponent<Rigidbody>();
        agent = entityLinked.gameObject.AddComponent<NavMeshAgent>();
        Debug.Log("EndBindingPathfinding");
    }

    public void setup(NPC NPCToBeLinked)
    {
        throw new NotImplementedException();
    }
}
