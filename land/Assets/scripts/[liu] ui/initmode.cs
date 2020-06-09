using UnityEngine;
using UnityEngine.UI;

public class initmode : MonoBehaviour
{
    public UImanager uImanager;
    private Button rebel;
    private Button ruler;
    private Button story;
    // Start is called before the first frame update
    void Start()
    {
        rebel = transform.Find("rebel mode").GetComponent<Button>();
        rebel.onClick.AddListener(rebelMode);
        ruler = transform.Find("ruler mode").GetComponent<Button>();
        ruler.onClick.AddListener(rulerMode);
        story = transform.Find("background").GetComponent<Button>();
        story.onClick.AddListener(storyMode);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void rebelMode() {
        uImanager.setMode(1);
        uImanager.showUI();
        uImanager.hideInit();
        uImanager.showimage();
    }

    void rulerMode()
    {
        uImanager.setMode(2);
        uImanager.showUI();
        uImanager.hideInit();
        uImanager.showimage();
    }

    void storyMode()
    {
        uImanager.setMode(3);
        uImanager.showUI();
        uImanager.hideInit();
        uImanager.showimage();
    }
}
