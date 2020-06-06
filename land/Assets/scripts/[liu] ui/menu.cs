using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class menu : MonoBehaviour
{

    private Button localgameB;
    private Button teachingModeB;

    // Start is called before the first frame update
    void Start()
    {
        localgameB = transform.Find("localgame").GetComponent<Button>();
        localgameB.onClick.AddListener(localStart);
        teachingModeB = transform.Find("teaching mode").GetComponent<Button>();
        teachingModeB.onClick.AddListener(teachStart);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void localStart()
	{
        GameManager.Instance.LoadScene("localGame");
	}
    private void teachStart()
    {
        GameManager.Instance.LoadScene("teachingMode");
    }
    
}
