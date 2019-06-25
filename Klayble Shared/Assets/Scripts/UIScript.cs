using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public GameObject RedBtnGO;
    private Button RedButton;
    public Text RedButtonText;

    public GameObject GreenBtnGO;
    private Button GreenButton;
    public Text GreenButtonText;

    public Text MainMsgText;
    public GameObject Panel;

    public float TextSpeed = 0.05f;

    public enum MenuText { Menu0, Menu1, Menu2, Menu3 }
    private MenuText menuText;

    private IEnumerator textTypeCRT;

    // Start is called before the first frame update
    private void Start()
    {
        RedButton = RedBtnGO.GetComponent<Button>();
        GreenButton = GreenBtnGO.GetComponent<Button>();
        menuText = MenuText.Menu0;

        // Events
        EventManager.ToggleUI += ToggleUIActive;

        DrawMenu((int)this.menuText);
    }

    public void DrawMenu(int menuNum)
    {
        StopCoroutine(textTypeCRT);
        // TODO: Play Menu Sound!
        RedButton.onClick.RemoveAllListeners();
        GreenButton.onClick.RemoveAllListeners();

        switch (menuNum)
        {
            case 0:
                ChangeMenuAdvance(RedBtnGO, "Advance to Menu 1", 1);
                ChangeMenuAdvance(GreenBtnGO, "Advance to Menu 2", 2);
                textTypeCRT = TypeMsgText("This is Menu 0");
                break;

            case 1:
                ChangeMenuAdvance(RedBtnGO, "Return to Menu 0", 0);
                ChangeMenuAdvance(GreenBtnGO, "Advance to Menu 2", 2);
                textTypeCRT = TypeMsgText("Welcome to Menu 1! Ahh, lemons.");
                break;

            case 2:
                ChangeMenuAdvance(RedBtnGO, "Return to Menu 0", 0);
                ChangeMenuAdvance(GreenBtnGO, "Return to Menu 1", 1);
                textTypeCRT = TypeMsgText("Menu 2!");
                break;
        }
        StartCoroutine(textTypeCRT);
    }

    // Changes the Menu's buttons' destinations, and text.
    private void ChangeMenuAdvance(GameObject btn, string newText, int toMenuNum)
    {
        btn.GetComponent<Button>().GetComponentInChildren<Text>().text = newText;
        btn.GetComponent<Button>().onClick.AddListener(() => AdvanceMenu(toMenuNum));
    }

    public void AdvanceMenu(int toMenuNum)
    {
        this.menuText = (MenuText)toMenuNum;
        DrawMenu(toMenuNum);
    }

    private IEnumerator TypeMsgText(string Message)
    {
        for (int i = 0; i < Message.Length + 1; i++)
        {
            MainMsgText.text = Message.Substring(0, i);
            yield return new WaitForSecondsRealtime(TextSpeed);
            // TODO: Maybe Play a Sound here
        }
        Debug.Log("DONE printing!");
    }

    public void ToggleUIActive()
    {
        this.GreenBtnGO.gameObject.SetActive(!GreenBtnGO.gameObject.activeSelf);
        this.RedBtnGO.gameObject.SetActive(!RedBtnGO.gameObject.activeSelf);
        this.Panel.gameObject.SetActive(!Panel.gameObject.activeSelf);
        this.MainMsgText.gameObject.SetActive(!MainMsgText.IsActive());
    }
}