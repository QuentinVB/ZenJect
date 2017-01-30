using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class EntityView : ITickable, IInitializable
{
    IEntityController _entityController;

    public EntityView(IEntityController entityController)
    {
        _entityController = entityController;
        Debug.Log("EndBindingEntityView");
    }

    public void Initialize()
    {
       _entityController.Setup();
    }

    public void Tick()
    {
        _entityController.DataInput();
    }
}
