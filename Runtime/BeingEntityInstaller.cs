using UnityEngine;
using Zenject;

namespace BobboNet.Engine
{
    [CreateAssetMenu(fileName = "BeingEntityInstaller", menuName = "Installers/BeingEntityInstaller")]
    public class BeingEntityInstaller : ScriptableObjectInstaller<BeingEntityInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<BeingEntity>().FromNewComponentOnNewGameObject().WithGameObjectName("Being Entity").AsSingle().NonLazy();
        }
    }
}