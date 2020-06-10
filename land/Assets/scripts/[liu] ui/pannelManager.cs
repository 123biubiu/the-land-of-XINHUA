using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pannelManager : MonoBehaviour
{
    public List<Sprite> diceImageList;
    public List<string> chanceContents;
    public List<string> eventContents;
    public Text contentText;
    public Image dice1;
    public Image dice2;
    public static int currentNumber;
    public string currentEvent;
    public string currentChance;
    public int currentChanceId;
    public int currenteventId;
    public int turn = 1;
    public int currenteve;
    public Text turntext;
    public Movement_Control currentchars;
    public GameObject mainpannel;

    private void Start()
    {
        chanceContents = new List<string>();
        chanceContents.Add("gain 100 gold");
        chanceContents.Add("lose 100 gold");
        chanceContents.Add("gain 200 gold");
        chanceContents.Add("gain 300 gold");
        chanceContents.Add("gain 100 gold from random player");
        eventContents.Add("random player gain 100 gold");
        eventContents.Add("random player lose 100 gold");
        eventContents.Add("random player gain 200 gold");
        eventContents.Add("random player gain 300 gold");
        eventContents.Add("random player gain 100 gold from random player");


    }
    public void setContext(string value)
    {
        contentText.text = value;
    }

    public void getDiceNumber() {
        currentchars.my = goldUImanager.players[0];
        int dice11 = Random.Range(1, 6);
        int dice22 = Random.Range(1, 6);
        dice1.sprite = diceImageList[dice11 - 1];
        dice2.sprite = diceImageList[dice22 - 1];
        currentNumber = dice11 + dice22;
        setContext("go " + currentNumber + " step");
        currentchars.rollw();
    }

    public void getChance() {
        currentChanceId = Random.Range(0, chanceContents.Count);
        currentChance = chanceContents[currentChanceId];
        setContext(currentChance);
        mainpannel.SetActive(true);
    }

    public void landdeve() {
        setContext("the land have no owner, whether develop this land");
        mainpannel.SetActive(true);

        
    }

    public void getEvent() {
        currenteventId = Random.Range(0, chanceContents.Count);
        currentEvent = eventContents[currenteventId];
        setContext(currentEvent);
        mainpannel.SetActive(true);
    }

    public void setTurn(){
        turntext.text = "turn : " + turn.ToString();
    }

    
}
