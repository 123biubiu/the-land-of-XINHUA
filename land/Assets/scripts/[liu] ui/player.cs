using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public int money;
    public int housevalue;
    public int totalProperty;
    public string nickname;

    public Player(int money,string nickname) {
        this.money = money;
        this.nickname = nickname;
        housevalue = 0;
        setTotal();
    }

    public void setTotal() {
        totalProperty = housevalue + money;
    }
    
}
