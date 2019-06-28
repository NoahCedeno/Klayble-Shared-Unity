using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{

    public delegate void AttackHandler(BattlePiece User, BattlePiece Target);
    public static event AttackHandler OnAttack;

    public delegate void MoveActionHandler(BattlePiece User, BattlePiece Target);
    public static event MoveActionHandler OnMove;

    public delegate void ToggleUIHandler();
    public static event ToggleUIHandler ToggleUI;

    private void Start()
    {

    }
}
