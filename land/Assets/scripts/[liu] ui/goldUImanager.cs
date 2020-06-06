using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goldUImanager : MonoBehaviour
{
    public List<Player> players;
    public Text playerBlock1;
    public Text playerBlock2;
    public Text playerBlock3;
    public Text playerBlock4;
    public Text totalBlock1;
    public Text totalBlock2;
    public Text totalBlock3;
    public Text totalBlock4;
    public Text nameBlock1;
    public Text nameBlock2;
    public Text nameBlock3;
    public Text nameBlock4;
    private void Start()
    {
        players.Add(new Player(123,"test"));
        players.Add(new Player(222,"shuyu"));
        players.Add(new Player(333,"player55"));
        players.Add(new Player(444,"player4"));
        nameBlock1.text = players[0].nickname;
        nameBlock2.text = players[1].nickname;
        nameBlock3.text = players[2].nickname;
        nameBlock4.text = players[3].nickname;
    }

    private void Update()
    {
        playerBlock1.text = players[0].money.ToString();
        playerBlock2.text = players[1].money.ToString();
        playerBlock3.text = players[2].money.ToString();
        playerBlock4.text = players[3].money.ToString();
        totalBlock1.text = players[0].totalProperty.ToString();
        totalBlock2.text = players[1].totalProperty.ToString();
        totalBlock3.text = players[2].totalProperty.ToString();
        totalBlock4.text = players[3].totalProperty.ToString();
    }
}
