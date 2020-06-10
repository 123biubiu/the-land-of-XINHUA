using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Event : MonoBehaviour
{
    public List<GameObject> cubelist;
    public List<land> landlist;
    public pannelManager pnm;
    public Button ok;
    public Button no;
    public Button begin;
    public int currentevee;
    private Collider currentcoll;
    public Player currentplayer;
    // Start is called before the first frame update
    void Start()
    {

        ok.onClick.AddListener(okliste);
        no.onClick.AddListener(noliste);
        currentevee = -1;
        begin.onClick.AddListener(atbegin);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void eventTrigger(Collider other,Player p) {
        currentcoll = other;
        currentplayer = p;
        if (other.gameObject.tag == "ConnerPoint4")
        {
            startingpoint(p);
        }
        else if (other.gameObject.tag == "land") {
            //landevent(other,p);
            currentevee = 0;
            pnm.landdeve();
            
        }

    }

    public void startingpoint(Player p1) {
        if (p1.camp == "rebel")
        {
            p1.money = p1.money + 200;
        }
        else if (p1.camp == "ruler") {
            int rebelN = goldUImanager.aliveNumber();
            goldUImanager.starting();
            p1.money = p1.money + 100*rebelN;
        }

    }

    public void landevent(bool choose) {
        for (int i = 0; i < 16; i++) {
            if(currentcoll.gameObject.name==cubelist[i].name){
                if(currentplayer.money>=landlist[i].value){
                    if (choose)
                    {
                        currentplayer.money -= landlist[i].value;
                        landlist[i].owner = currentplayer;
                        currentplayer.housevalue += landlist[i].sellvalue;
                        currentplayer.setTotal();
                    }
                }
                

            }
        }
    }

    public void atbegin() {
        for (int i = 0; i < 3; i++)
        {
            landlist.Add(new land(cubelist[i],50,null));
        }
        for (int i = 3; i < 7; i++)
        {
            landlist.Add(new land(cubelist[i], 100, null));
        }
        for (int i = 7; i < 11; i++)
        {
            landlist.Add(new land(cubelist[i], 150, null));
        }
        for (int i = 11; i < 16; i++)
        {
            landlist.Add(new land(cubelist[i], 200, null));
        }
        landlist[0].owner = goldUImanager.players[0];
        landlist[6].owner = goldUImanager.players[0];
        landlist[8].owner = goldUImanager.players[0];
        landlist[13].owner = goldUImanager.players[0];
        goldUImanager.players[0].housevalue += landlist[0].sellvalue;
        goldUImanager.players[0].housevalue += landlist[6].sellvalue;
        goldUImanager.players[0].housevalue += landlist[8].sellvalue;
        goldUImanager.players[0].housevalue += landlist[13].sellvalue;
        goldUImanager.players[0].setTotal();
    }

    public void okliste()
    {
        if (currentevee == 0)
        {
            landevent(true);
            currentevee = -1;
        }
    }
    public void noliste()
    {
        if (currentevee == 0) {
            landevent(false);
            currentevee = -1;
        }
    }
}
