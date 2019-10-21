using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{

    // Original Functionality was overwritten by TurnSystem!

    public delegate void ToggleUIHandler();
    public static event ToggleUIHandler ToggleUI;

}
