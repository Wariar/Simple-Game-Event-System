# Simple Game Event System

A simple event system which can broadcast and listen to events and do actions. Events and delegates are the two  most important concepts that can reduce code dependency in an application. 

There are two main primary class. [GameEvent](https://github.com/Wariar/SimpleGameEventSystem/blob/master/GameEvent/GameEvent.cs) is a scriptable object, which holds a delegate to which listeners subscribe to.  [GameListenerBase](https://github.com/Wariar/SimpleGameEventSystem/blob/master/GameEvent/GameListenerBase.cs) is an abstract class which all listeners should inherit from. 

This system lets users follow [Single Responsibility Principle](https://en.wikipedia.org/wiki/Single_responsibility_principle).
Developers can create each listener as a separate script with a single responsibility. This makes the game architecture more readable and maintainable.

>This idea originated from a UNITE session video. This system is a modified version of the original idea. 
# Usage

Events can be created as below. 

![enter image description here](https://lh3.googleusercontent.com/VZ_LFyM8H36_3pFVcm8qyFqpAuDNhq4ZC1GXw0te5dBzyJERGq_YW0KYlLux4BkSHoA6jHLl7si7CQ)

In the example, the lights are turned on/off using an event. So we have created couple of events for switching on and off. 

![enter image description here](https://lh3.googleusercontent.com/QVXRwghjy5vNr4ZOs8xPjWqJuOSWYBPhPidxXruVJHEyfEEdNvqlxVcnFTdGTWi1XV3X-gi72jBBWA)

**Unit testing** is much easier with this system. Each event object created has a **Broadcast** button, which will raise the event on pressed. In this way without playing through the game, functionalities can be tested. 

![enter image description here](https://lh3.googleusercontent.com/wdVOTEuNfuI4cWUWLeh0goyN-UGwC5ZfW9114rrfnVkV2D1wMvICMJDG3zfHzhJIEPdPwX6pfHT15w)

Listeners inherited from GameListenerBase will subscribe to the event specified. In the example, _TurnLightOff script listen to TurnLightsOff event and SwitchOnRedLight script listen to TurnOnRed event._ 

![enter image description here](https://lh3.googleusercontent.com/Ew15Xqds_ibzj7yFZ1b3x205_lGgBbJSEikgYyepab7x-i8SLJJHx3mYDphtR-X2kZ6pHIcXxtDtbw)

