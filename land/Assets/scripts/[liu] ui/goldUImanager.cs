using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goldUImanager : MonoBehaviour
{
    public static List<Player> players = new List<Player>();
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
    public Movement_Control mov;
    public Event eve;

    private void Start()
    {
        players.Add(new Player(2000,"test","ruler"));
        players.Add(new Player(600,"shuyu","rebel"));
        players.Add(new Player(600,"player55","rebel"));
        players.Add(new Player(600,"player4","rebel"));
        nameBlock1.text = players[0].nickname;
        nameBlock2.text = players[1].nickname;
        nameBlock3.text = players[2].nickname;
        nameBlock4.text = players[3].nickname;
        mov.my = players[0];
    }

    private void Update()
    {
        //players[0] = eve.currentplayer;
        playerBlock1.text = players[0].money.ToString();
        playerBlock2.text = players[1].money.ToString();
        playerBlock3.text = players[2].money.ToString();
        playerBlock4.text = players[3].money.ToString();
        totalBlock1.text = players[0].totalProperty.ToString();
        totalBlock2.text = players[1].totalProperty.ToString();
        totalBlock3.text = players[2].totalProperty.ToString();
        totalBlock4.text = players[3].totalProperty.ToString();
    }

    public static int aliveNumber() {
        int aliveN = 0;
        for (int i = 1; i < 4; i++) {
            if (players[i].alive == 1) {
                aliveN = aliveN + 1;
            }
        }
        return aliveN;
    }

    public static void starting() {
        for (int i = 1; i < 4; i++)
        {
            players[i].money = players[i].money - 100;
            players[i].isalive();
        }
    }
}
