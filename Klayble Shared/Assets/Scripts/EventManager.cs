using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{

    public delegate void MoveAction(BattlePiece User, TileScript Location);
    public static event MoveAction OnMove;

    public delegate void ToggleUIHandler();
    public static event ToggleUIHandler ToggleUI;

    private void Start()
    {

    }

    public void CallToggleUI()
    {
        ToggleUI();
    }
}
