
using UnityEngine;
using UnityEditor;

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

        if(GUILayout.Button("Broadcast"))
        {
            _ge?.Invoke();
        }
    }
}
