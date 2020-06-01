using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pannelManager : MonoBehaviour
{
    public List<string> contents;
    public Text contentText;
    public int currentNumber;
    public string currentEvent;

    public void setContext(string value)
    {
        contentText.text = value;
    }

    public void getDiceNumber() {
        currentNumber = Random.Range(1, 6);
        setContext("go " + currentNumber + " step");
    }

    public void getChance() {
        currentEvent = contents[Random.Range(0, contents.Count)];
        setContext(currentEvent);
    }
}
