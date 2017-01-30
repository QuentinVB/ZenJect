using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Zenject;

public class NPCInstaller : MonoInstaller
{
    public GameObject NPCPrefab;

    public override void InstallBindings()
    {
        Container.BindAllInterfaces<NPCSpawner>().To<NPCSpawner>().AsSingle();

        Container.Bind<IPositionDirector>().To<PositionDirector>();
        //Container.Bind<IAnimCtrl>().To<NPCAnimCtrl>();
        Container.Bind<float>().FromInstance(0.1f);
        Container.BindFactory<IPositionDirector, float, NPC, NPC.Factory>().FromPrefab(NPCPrefab);
    }
}