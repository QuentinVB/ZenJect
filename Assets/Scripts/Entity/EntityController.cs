using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class EntityController : IEntityController
{
    Entity _entity;
    IPathfinding _pathfinding;
    IAnimCtrl _animationControl;
    ITailor _tailor;
    IPositionDirector _initialPosition;

    public EntityController(
        Entity entity,
        IPathfinding pathfinding,
        IAnimCtrl animationControl,
        ITailor tailor,
        IPositionDirector initialPosition)
    {
        _entity = entity;
        _pathfinding = pathfinding;
        _animationControl = animationControl;
        _tailor = tailor;
        _initialPosition = initialPosition;
     
    }
    public void Setup()
    {
        _entity.transform.rotation = _initialPosition.Rotation;
        _entity.transform.position = _initialPosition.Position;
        Debug.Log("EndBindingEntityController");
    }
    public void DataInput()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _entity.Rotation = Quaternion.Euler(0f, 0f, 180f);
            _entity.Position += Vector3.forward;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _entity.Rotation = Quaternion.Euler(0f, 0f, 0f);
            _entity.Position += Vector3.back;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _entity.Rotation = Quaternion.Euler(0f, 0f, 90f);
            _entity.Position += Vector3.left;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _entity.Rotation = Quaternion.Euler(0f, 0f, -90f);
            _entity.Position += Vector3.right;
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            _animationControl.updateAnimation(0);
        }
    }

 
}
