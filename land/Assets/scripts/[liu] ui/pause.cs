using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pause : MonoBehaviour
{
    public Button backmenu;
    // Start is called before the first frame update
    void Start()
    {
        backmenu.onClick.AddListener(backtomenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void backtomenu()
    {
        GameManager.Instance.LoadScene("menu");
    }

}
