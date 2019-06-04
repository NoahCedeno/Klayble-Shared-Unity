using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{

    public delegate void MoveAction(BattlePiece User, TileScript Location);
    public static event MoveAction OnMove;

    private void Start()
    {

    }

    private void TestMoth()
    {

    }
}
