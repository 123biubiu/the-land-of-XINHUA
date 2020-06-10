using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class land : MonoBehaviour
{
    public Player owner;
    public GameObject landcube;
    public int value;
    public int pay;
    public int housepay;
    public int housebuild;
    public int sellvalue;

    public land(GameObject landcube,int value,Player owner) {

        this.landcube = landcube;
        this.value = value;
        this.owner = owner;
        this.pay = value * 1 / 5;
        this.housepay = value;
        this.housebuild = value;
        this.sellvalue = value / 2;
    }



}
