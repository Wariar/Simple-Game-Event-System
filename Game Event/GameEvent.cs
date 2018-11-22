
using UnityEngine;

/// <summary>
/// Game Event:
///     1. Handle adding / removing listeners to the event.
///     2. Invoke the event
///     3. Option to pass n params / pass null if empty.
/// </summary>
[CreateAssetMenu(menuName = "GameEvent/Event")]
public class GameEvent : ScriptableObject {

    delegate void AddEvent(params object[] args);
    AddEvent OnEvent;

    public void AddListner(GameListenerBase receiver) => OnEvent += receiver.ReceiveEvent;


    public void RemoveListner(GameListenerBase receiver) => OnEvent -= receiver.ReceiveEvent;


    public void Invoke(params object[] args) => OnEvent?.Invoke(args);
    
}