using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pannelManager : MonoBehaviour
{
    public List<string> chanceContents;
    public List<string> eventContents;
    public Text contentText;
    public int currentNumber;
    public string currentEvent;
    public string currentChance;

    public void setContext(string value)
    {
        contentText.text = value;
    }

    public void getDiceNumber() {
        currentNumber = Random.Range(1, 6);
        setContext("go " + currentNumber + " step");
    }

    public void getChance() {
        currentChance = chanceContents[Random.Range(0, chanceContents.Count)];
        setContext(currentChance);
    }

    public void getEvent() {
        currentEvent = eventContents[Random.Range(0,eventContents.Count)];
    }
}
