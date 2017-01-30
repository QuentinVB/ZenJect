using Zenject;
using UnityEngine;
using System.Collections;

public class TestInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<string>().FromInstance("Hello World!");
        Container.Bind<TestRunner>().NonLazy();
    }
}

public class TestRunner
{
    public TestRunner(string message)
    {
        Debug.Log(message);
    }
}
