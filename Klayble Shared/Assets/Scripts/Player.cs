using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public int hp { get; private set; }
    [SerializeField] public int atk { get; private set; }
    [SerializeField] public int def { get; private set; }
    [SerializeField] public string name { get; private set; }
    [SerializeField] public Card[] deck { get; private set; }

}
