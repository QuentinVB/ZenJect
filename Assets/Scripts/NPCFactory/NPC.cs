using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Zenject;

public class NPC : MonoBehaviour
{
    //IPositionDirector _initialPosition;
    //IAnimCtrl _animationControl;

    float _speed;

    // Note that we can't use a constructor anymore since we are a MonoBehaviour now
    [Inject]
    public void Construct(
        IPositionDirector position,
        /*IAnimCtrl animationControl,*/
        float speed
        )
    {
        //_initialPosition = position;
        //_animationControl = animationControl;
        _speed = speed;
    }

    public class Factory : Factory<IPositionDirector, float, NPC>
    {

    }
    void Start()
    {
       
        //transform.rotation = _initialPosition.Rotation;
        //transform.position = _initialPosition.Position;
        Debug.Log("EndStartingNewNPC");
   
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //_animationControl.updateAnimation(0);
        }
        transform.Translate(Vector3.left*_speed);
    }
}