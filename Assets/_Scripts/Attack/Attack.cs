using PurrNet;
using UnityEngine;

public abstract class Attack : NetworkBehaviour
{
    public void Initialize()
    {

    }
    protected abstract void OnInitialize();
    public abstract void Tick();
}
