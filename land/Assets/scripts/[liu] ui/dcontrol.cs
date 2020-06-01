using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dcontrol : MonoBehaviour
{

    int currentNumber = 0;
    int min = 1 ;
    int max = 6;
    void dice() {
        if (currentNumber == 0) { 
            currentNumber = Random.Range(min, max);
        }
    }
}
