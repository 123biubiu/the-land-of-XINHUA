using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class initmode : MonoBehaviour
{
    public UImanager uImanager;
    private Button rebel;
    private Button ruler;
    // Start is called before the first frame update
    void Start()
    {
        rebel = transform.Find("rebel mode").GetComponent<Button>();
        rebel.onClick.AddListener(rebelMode);
        ruler = transform.Find("ruler mode").GetComponent<Button>();
        ruler.onClick.AddListener(rulerMode);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void rebelMode() {
        uImanager.setMode(1);
    }

    void rulerMode()
    {
        uImanager.setMode(2);
    }
}
