using Asteroids.Bridge;
using UnityEngine;

namespace DefaultNamespace
{
    internal sealed class ExampleComposite : MonoBehaviour
        {
            private void Start()
            {
                IBuildUnit factory = new AnyTypeFactory();
                Detachment factories = new Detachment();
                factories.AddFactory(factory,"mag",100);
                factories.AddFactory(factory,"infantry",150);
                factories.AddFactory(factory,"mag",50);
                factories.BuildUnits();
            }
        }
}