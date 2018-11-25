using UnityEngine;
using UnityEditor;
/// <summary>
/// Custom editor for Game Event script
/// </summary>
[CustomEditor(typeof(GameEvent))]
public class GameEventEditor : Editor {

    GameEvent _ge;

    private void OnEnable()
    {
        _ge = target as GameEvent;
    }

    public override void OnInspectorGUI()
    {
        
        GUI.enabled = Application.isPlaying;

        // Helps in broadcasting event when application is playing. This is useful in Unit testing.
        if(GUILayout.Button("Broadcast"))
        {
            _ge?.Invoke();
        }
    }
}
