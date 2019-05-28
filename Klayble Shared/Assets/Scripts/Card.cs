using UnityEngine;
using Newtonsoft.Json;

public class Card : MonoBehaviour
{
    [SerializeField] public int hp { get; private set; }
    [SerializeField] public int atk { get; private set; }
    [SerializeField] public int def { get; private set; }
    [SerializeField] public string name { get; private set; }
    [SerializeField] public int cardID { get; set; }
    [SerializeField] public Player player { get; set; }

    private void OnEnable()
    {
        Debug.Log("Card " + this.name + " made under owner " + this.player.name);
    }
}