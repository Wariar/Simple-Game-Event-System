using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchOnGreenLight : GameListenerBase
{
    public override void ReceiveEvent() => TurnOn();

    private void TurnOn()
    {
        var light = GetComponent<Light>();
        if (!light.isActiveAndEnabled)
            light.enabled = true;
    }
}
