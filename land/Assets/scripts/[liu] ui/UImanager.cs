using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    public List<string> rulercontents;
    public List<string> rebelcontents;
    public List<string> storycontents;
    public List<string> currentMode;
    public int teachhmode;
    public UIpannel pannel;
    private int currentLine;
    public Button exit;
    // Start is called before the first frame update
    void Start()
    {
        init();
        exit.onClick.AddListener(backmenu);
    }

    // Update is called once per frame
    void Update()
    {
        if (pannel.contentText.enabled==true) {
            if (Input.GetMouseButtonDown(0))
            {
                loadText(currentMode[currentLine]);
                nextLine();
                if (currentLine >= currentMode.Count)
                {
                    currentLine = currentMode.Count;
                    init();
                }

                
            }
        }
    }

    private void modeControl()
    {
        switch (teachhmode)
        {
            case 1:
                currentMode = rebelcontents;
                break;
            case 2:
                currentMode = rulercontents;
                break;
            case 3:
                currentMode = storycontents;
                break;
        }
    }
    public void init()
	{
        hideUI();
        currentLine = 0;
        pannel.setContext("");
        showInit();
        initcontents();
	}

    public void showUI()
	{
        pannel.showDialog(true);
        pannel.showText(true);
	}

    public void showInit() {
        pannel.showButton(true);

    }
    public void hideInit() {
        pannel.showButton(false);
    }
    public void hideUI()
	{
        pannel.showText(false);
        pannel.showDialog(false);
	}

    public void nextLine()
    {
        currentLine++;
    }

    public void loadText(string value)
	{
        pannel.setContext(value);
	}

    public void setMode(int mode) {
        teachhmode = mode;
        modeControl();
    }

    public void initcontents()
	{
        //init the three list
        storycontents.Clear();
        storycontents.Add("The story took place in a village named Xinhua in southern China.");
        storycontents.Add("One of the landlords, Liu Yang, had a lot of land because his ancestors had been officials in the government.");
        storycontents.Add(" He is usually arrogant, often bullying other people, and employing many bodyguards, so most of the farmers dare not resist.");
        storycontents.Add("There are many tenants of Liu Yang, including a pair of siblings named Hu Zi and Ying Zi.");
        storycontents.Add("Brother Huzi has been hardworking and capable since childhood, and has helped a lot in the family. He treats people very kindly.");
        storycontents.Add("Although her sister Yingzi is not as strong as her brother, she is a very smart girl. They also have a common friend named Hua Zi, a neighbor's child.");
        storycontents.Add("The three of them have been very good friends since childhood and have very close relationships.");
        storycontents.Add("Faced with the unreasonable demands of the landlord, Hu Zi, Ying Zi, and Hua Zi joined forces with other oppressed farmers to resist, overthrow the landlord's rule through labor, and finally obtained their own land.");
        rebelcontents.Clear();
        rebelcontents.Add("as a rebel, There are three players in the rebel camp. The winning condition is that the ruler loses all the money.");
        rebelcontents.Add("Money includes gold and property, the game shows the total amount of gold and property held by the player");
        rebelcontents.Add("When you don't have enough gold to pay the existing bills, you sell your other assets at a low price. When you can't pay the existing bills, you will go bankrupt, which means failure");
        rebelcontents.Add("The game is a turn system, each player in turn for their own turn.");
        rebelcontents.Add("The operation of each round includes the selection of walking direction and dice time before walking");
        rebelcontents.Add("After the dice are rolled, the system will automatically walk the steps of the dice. When the dice stay in the target box, the prompt box will display the triggered event, and the player can choose");
        rebelcontents.Add("When players go to the undeveloped land, they can choose to spend gold for development. After development, players will own the land and charge when the enemy camp stays on the land.");
        rebelcontents.Add("In addition to the land, there are random events and opportunity grids that trigger a variety of characteristic events.");
        rebelcontents.Add("As a rebel and an ordinary farmer, every time you pass the starting point clockwise, you will get a sum of gold, which is the wealth from your hard work.");
        rebelcontents.Add("No character can cross the starting point anticlockwise. When you attempt to cross the starting point anticlockwise, the system will force you to change your direction");
        rebelcontents.Add("At the beginning of the game, the rebel camp has only gold and no other assets.");
        rebelcontents.Add("There are some characters for the rebel camp to choose from. Each character has its own unique skills. Using these skills properly will help you to win.");
        rebelcontents.Add("Work with your teammates to overthrow the ruler！");
        rulercontents.Clear();
        rulercontents.Add("As a ruler, you will face three rebels on your own. Victory is conditional on the loss of all money to all rebels.");
        rulercontents.Add("Money includes gold and property, the game shows the total amount of gold and property held by the player");
        rulercontents.Add("When you don't have enough gold to pay the existing bills, you sell your other assets at a low price. When you can't pay the existing bills, you will go bankrupt, which means failure");
        rulercontents.Add("The game is a turn system, each player in turn for their own turn.");
        rulercontents.Add("The operation of each round includes the selection of walking direction and dice time before walking");
        rulercontents.Add("After the dice are rolled, the system will automatically walk the steps of the dice. When the dice stay in the target box, the prompt box will display the triggered event, and the player can choose");
        rulercontents.Add("When players go to the undeveloped land, they can choose to spend gold for development. After development, players will own the land and charge when the enemy camp stays on the land.");
        rulercontents.Add("In addition to the land, there are random events and opportunity grids that trigger a variety of characteristic events.");
        rulercontents.Add("Every time you walk clockwise through the starting point, you will get a certain amount of gold from each rebel. You are a noble ruler, and it is natural to get wealth from other civilians.");
        rulercontents.Add("No character can cross the starting point anticlockwise. When you attempt to cross the starting point anticlockwise, the system will force you to change your direction");
        rulercontents.Add("In order to help you maintain your rule, you will gain random land at the beginning of the game, and you will have no less gold than the rebels.");
        rulercontents.Add("At the same time, you can also choose different landlord roles. The characters will have their own unique skills. Using these skills properly will help you suppress the rebels.");
        rulercontents.Add("Keep your rule and defeat the disrespectful rebels");
    }

    private void backmenu() {

        GameManager.Instance.LoadScene("menu");
    }
}
