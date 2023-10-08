using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCountdown : MonoBehaviour
{
    public GameObject countdownScreen,a5;
    // Start is called before the first frame update
    public void CountDown()
    {
        countdownScreen.SetActive(true);
        Instantiate(a5);
        Game.missions[4] = true;
    }
}
