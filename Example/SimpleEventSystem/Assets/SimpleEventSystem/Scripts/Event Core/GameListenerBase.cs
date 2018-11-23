using UnityEngine;

/// <summary>
/// Game listener base: This class lets the developer follow the Single Responsibility Principle. Check example project for more details. 
/// 
///     1. This is a base class which all listeners should inherit. 
///     2. Adds itself as a listner for the event added
///     3. All logic should be provided in ReceiveEvent function.
/// </summary>
public abstract class GameListenerBase : MonoBehaviour
{
    [SerializeField]
    GameEvent gameEvent;

    protected void OnEnable() => gameEvent.AddListner(this);
    protected void OnDestory() => gameEvent.RemoveListner(this);
    public abstract void ReceiveEvent();
}
