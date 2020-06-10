using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lookperson : MonoBehaviour
{
    public List<GameObject> character;
    public int currentchar;
    public float distance = 6;
    public float rot = 0;
    private float roll = 30f * Mathf.PI * 2 / 360;
    private GameObject target;
    public Button choose;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("hite Knight 03 Blue3 Blue");
        choose.onClick.AddListener(newscene);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 targetPos = target.transform.position;
        Vector3 cameraPos;
        float d = distance * Mathf.Cos(roll);
        float height = distance * Mathf.Sin(roll);
        cameraPos.x = targetPos.x + d * Mathf.Cos(rot);
        cameraPos.z = targetPos.z + d * Mathf.Sin(rot);
        cameraPos.y = targetPos.y + height;
        Camera.main.transform.position = cameraPos;
        //对准目标
        Camera.main.transform.LookAt(target.transform);
    }

    public void changeTarget() {
        currentchar++;
        if (currentchar >= 4) {
            currentchar = 0;
        }
        target = character[currentchar];
    }
    public void newscene() {
        GameManager.Instance.LoadScene("test");
    }
}
