using UnityEngine;
using Zenject;

public class EntityInstaller : MonoInstaller<EntityInstaller>
{
    public GameObject EntityPrefab;
    public override void InstallBindings()
    {
        Container.Bind<Entity>().FromPrefab(EntityPrefab).AsSingle();
        //Container.BindGameObjectFactory<GameObjectFactory<Missile>>(MissilePrefab);

        Container.BindAllInterfaces<EntityView>().To<EntityView>().AsSingle();

        Container.Bind<IPathfinding>().To<Pathfinding>();
        Container.Bind<IAnimCtrl>().To<AnimCtrl>();
        Container.Bind<ITailor>().To<Tailor>();
        Container.Bind<string>().FromInstance("Caisse");
        Container.Bind<IPositionDirector>().To<PositionDirector>();

        Container.Bind<IEntityController>().To<EntityController>();

        Debug.Log("EndBinding");

    }
}
