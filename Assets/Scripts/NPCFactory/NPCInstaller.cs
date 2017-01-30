using UnityEngine;
using Zenject;

public class NPCInstaller : MonoInstaller
{
    public GameObject EntityPrefab;

    public override void InstallBindings()
    {
        Container.Bind<Entity>().FromPrefab(EntityPrefab).AsSingle();

        Container.BindAllInterfaces<NPCSpawner>().To<NPCSpawner>().AsSingle();
        Container.Bind<NPCControler>().AsSingle();

        Container.BindFactory<float, NPCControler, NPCControler.Factory>();
        Debug.Log("EndBinding");

    }

}