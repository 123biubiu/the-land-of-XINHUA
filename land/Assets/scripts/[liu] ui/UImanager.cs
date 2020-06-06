using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UImanager : MonoBehaviour
{
    public List<string> rulercontents;
    public List<string> rebelcontents;
    public int teachhmode;
    public UIpannel pannel;
    private int currentLine;
    // Start is called before the first frame update
    void Start()
    {
        init();
    }

    // Update is called once per frame
    void Update()
    {
        if (pannel.contentText.enabled==true) {
            if (Input.GetMouseButtonDown(0))
            {
                nextLine();
                if (currentLine >= rulercontents.Count)
                {
                    currentLine = rulercontents.Count;
                    init();
                }
                loadText(rulercontents[currentLine]);
            }
        }
    }

    public void init()
	{
        hideUI();
        currentLine = 0;
        pannel.setContext("");
	}

    public void showUI()
	{
        pannel.showDialog(true);
        pannel.showText(true);
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
    }
}
