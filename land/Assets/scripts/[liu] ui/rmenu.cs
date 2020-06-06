using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rmenu : MonoBehaviour
{
    private Button exit;
    private Button informationB;
    // Start is called before the first frame update
    void Start()
    {
        exit = transform.Find("exit").GetComponent<Button>();
        exit.onClick.AddListener(exitApplication);
        informationB = transform.Find("information").GetComponent<Button>();
        informationB.onClick.AddListener(informationStart);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void informationStart()
    {
        GameManager.Instance.LoadScene("information");
    }
    private void exitApplication()
    {
        Application.Quit();
        print("quit game");
    }
}
