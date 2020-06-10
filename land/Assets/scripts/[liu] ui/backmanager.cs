using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class backmanager : MonoBehaviour
{
    public lookperson lk;
    public Text tt;
    public List<string> backgroundlist;
    // Start is called before the first frame update
    void Start()
    {
        backgroundlist = new List<string>();
        backgroundlist.Add("He had a lot of land because his ancestors had been officials in the government. He is usually arrogant, often bullying other people, and employing many bodyguards, so most of the villagers dare not resist.Skill: Initially have more 1000 gold than others");
        backgroundlist.Add("Huzi has been hardworking and capable since childhood.He helped a lot in the family and treat people very kindly.Skill:  One day less time in prison");
        backgroundlist.Add("The sister of Hu Zi, which is a very smart girl. She is very talented in math and calculation.Skill: 10% less rent");
        backgroundlist.Add("A common friend of Hu Zi and Ying Zi. He is very naughty, not as strong and reliable as Tiger. But he is a very lucky .Skill: Roll one more dice every 5 rounds");
           }

    // Update is called once per frame
    void Update()
    {
        tt.text = backgroundlist[lk.currentchar];
    }
}
