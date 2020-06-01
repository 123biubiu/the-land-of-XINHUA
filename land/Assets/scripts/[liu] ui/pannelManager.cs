using UnityEngine;
using UnityEngine.UI;

public class pannelManager : MonoBehaviour
{

    public Text contentText;
    public int currentNumber;

    public void setContext(string value)
    {
        contentText.text = value;
    }

    public void getDiceNumber() {
        currentNumber = Random.Range(1, 6);
        setContext("go " + currentNumber + " step");
    } 
}
