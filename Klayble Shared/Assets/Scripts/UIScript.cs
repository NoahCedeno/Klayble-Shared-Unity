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

    public AudioSource menu1;

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

    public void AdvanceMenu(int toMenuNum)
    {
        menu1.Play();
        this.menuText = (MenuText)toMenuNum;
        DrawMenu(toMenuNum);
    }

    public void DrawMenu(int menuNum)
    {
        float panelX, panelY;

        if (textTypeCRT != null)
        {
            StopCoroutine(textTypeCRT);
        }
        RedButton.onClick.RemoveAllListeners();
        GreenButton.onClick.RemoveAllListeners();

        switch (menuNum)
        {
            case 0: // TODO: I want to refactor this, but I'm not sure how! I want to namespace it.
                panelX = Screen.width / 2;
                panelY = Screen.height / 6;
                ChangePanelTransform(Panel, panelX, panelY, 0.925f, 0.25f);
                ChangeButtonTransform(GreenButton, 1.625f * panelX, panelY - 30, 1f, 1f);
                ChangeButtonTransform(RedButton, 1.625f * panelX, panelY + 30, 1f, 1f);
                MainMsgText.gameObject.SetActive(true);
                ChangeTextTransform(MainMsgText, panelX - 100, panelY);
                ChangeMenuAdvance(RedBtnGO, "Advance to Menu 1", 1);
                ChangeMenuAdvance(GreenBtnGO, "Advance to Menu 2", 2);
                textTypeCRT = TypeMsgText("This is Menu 0.");
                break;

            case 1:
                panelX = 7 * Screen.width / 8;
                panelY = Screen.height / 2;
                ChangePanelTransform(Panel, panelX, panelY, 0.2f, 0.9f);
                ChangeButtonTransform(GreenButton, panelX, 1.75f * panelY, 0.7f, 1f);
                ChangeButtonTransform(RedButton, panelX, 1.5f * panelY, 0.7f, 1f);
                MainMsgText.gameObject.SetActive(false);
                ChangeMenuAdvance(RedBtnGO, "Return to Menu 0", 0);
                ChangeMenuAdvance(GreenBtnGO, "Advance to Menu 2", 2);
                textTypeCRT = TypeMsgText("Welcome to Menu 1! Ahh, lemons.");
                break;

            case 2:
                panelX = Screen.width / 2;
                panelY = 5 * Screen.height / 6;
                ChangePanelTransform(Panel, panelX, panelY, 0.925f, 0.25f);
                ChangeButtonTransform(GreenButton, 1.625f * panelX, panelY - 30, 1f, 1f);
                ChangeButtonTransform(RedButton, 1.625f * panelX, panelY + 30, 1f, 1f);
                MainMsgText.gameObject.SetActive(true);
                ChangeTextTransform(MainMsgText, panelX - 100, panelY);
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


    // Menu Transform Functions
    private void ChangePanelTransform(GameObject ChangePnl, float newX, float newY, float xScale, float yScale)
    {
        ChangePnl.GetComponent<RectTransform>().localScale = new Vector3(xScale, yScale);
        ChangePnl.GetComponent<RectTransform>().position = new Vector2(newX, newY);
    }

    private void ChangeButtonTransform(Button ChangeBtn, float newX, float newY, float xScale, float yScale)
    {
        ChangeBtn.GetComponent<RectTransform>().localScale = new Vector3(xScale, yScale);
        ChangeBtn.GetComponent<RectTransform>().position = new Vector2(newX, newY);
    }

    private void ChangeTextTransform(Text ChangeText, float newX, float newY) // TODO: Implement font size change, other things to change possibly
    {
        ChangeText.rectTransform.position = new Vector2(newX, newY);
        // TODO: Possibly implement a limit for which text can be displayed, scroll sort of thing?
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