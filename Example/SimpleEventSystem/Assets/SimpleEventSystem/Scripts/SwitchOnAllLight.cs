using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchOnAllLight : GameListenerBase
{
    
    public override void ReceiveEvent() => TurnOn();

    private void TurnOn()
    {
        var lights = GetComponentsInChildren<Light>();
        foreach(var l in lights)
        {
            l.enabled = true;
        }
    }
}
