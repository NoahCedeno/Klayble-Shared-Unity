using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    
    public GameObject RedButton;
    public Text RedButtonText;
    public GameObject GreenButton;
    public Text GreenButtonText;
    public Text MainMsgText;
    public GameObject Panel;

    public float TextSpeed = 0.05f;


    // Start is called before the first frame update
    void Start()
    {
        // Events
        EventManager.ToggleUI += ToggleUIActive;


        RedButtonText.text = "Hide UI";
        GreenButtonText.text = "Do nothing :)";
        StartCoroutine(TypeMsgText("This is a test message. I don't exactly expect this to go too well, or too slowly, at a readable pace, but I can dream. I love this so much!"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator TypeMsgText(string Message)
    {
        for(int i = 0; i < Message.Length + 1; i++)
        {
            MainMsgText.text = Message.Substring(0, i);
            yield return new WaitForSecondsRealtime (TextSpeed);
            // Maybe Play a Sound here
            
        }
        Debug.Log("DONE printing!");
    }
    
    public void ToggleUIActive()
    {
        this.GreenButton.gameObject.SetActive(!GreenButton.gameObject.activeSelf);
        this.RedButton.gameObject.SetActive(!RedButton.gameObject.activeSelf);
        this.Panel.gameObject.SetActive(!Panel.gameObject.activeSelf);
        this.MainMsgText.gameObject.SetActive(!MainMsgText.IsActive());
    }

}
