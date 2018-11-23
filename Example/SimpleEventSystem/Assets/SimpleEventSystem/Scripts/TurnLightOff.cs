using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLightOff : GameListenerBase
{
    public override void ReceiveEvent() => TurnOff();

    private void TurnOff()
    {
        var light = GetComponent<Light>();
        if (light.isActiveAndEnabled)
            light.enabled = false;
    }
}
