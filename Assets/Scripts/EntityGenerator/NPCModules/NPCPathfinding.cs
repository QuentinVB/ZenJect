using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCPathfinding : IPathfinding, INPCComponent
{
    NPC NPCLinked;
    Rigidbody rigidBody;
    NavMeshAgent agent;
    NPCData data;

    public Vector3 Direction { get { return Vector3.forward; } }
    public Quaternion Orientation { get { return Quaternion.Euler(0, 0.1f, 0); } }

    public NPCPathfinding(NPCData data)
    {
        this.data = data;
        Debug.Log("New NPCPathfinding Created");
    }
    public void setup(NPC NPCToBeLinked)
    {
        NPCLinked = NPCToBeLinked;
        rigidBody = NPCLinked.gameObject.AddComponent<Rigidbody>();
        agent = NPCLinked.gameObject.AddComponent<NavMeshAgent>();
        Debug.Log("EndBinding NPCPathfinding");
    }

}
