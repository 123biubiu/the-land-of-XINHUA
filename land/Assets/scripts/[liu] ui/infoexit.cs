using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class infoexit : MonoBehaviour
{
    public Button exit;
    // Start is called before the first frame update
    void Start()
    {
        exit.onClick.AddListener(exitmenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void exitmenu()
    {
        GameManager.Instance.LoadScene("menu");
    }
}
