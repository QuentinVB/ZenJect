using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class NPCControler : IEntityController,ITickable
{
    readonly Entity _entity;
    readonly float _speed;

    public NPCControler(Entity entity, float speed)
    {
        _entity = entity;
        _speed = speed;
    }

    public void DataInput()
    {
        throw new NotImplementedException();
    }

    public void Setup()
    {
        throw new NotImplementedException();
    }

    public void Tick()
    {
        _entity.Position = _entity.Position + Vector3.right * _speed * Time.deltaTime;
    }

    public class Factory : Factory<float, NPCControler>
    {

    }

}
