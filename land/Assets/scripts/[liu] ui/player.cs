using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public int money;
    public int housevalue;
    public int totalProperty;
    public string camp;
    public string nickname;
    public int alive;

    public Player(int money,string nickname,string camp) {
        this.money = money;
        this.nickname = nickname;
        housevalue = 0;
        setTotal();
        this.camp = camp;
        alive = 1;
    }

    public void setTotal() {
        totalProperty = housevalue + money;
    }

    public void isalive() {
        if (totalProperty < 0) {
            alive = 0;
        }
    }
}
