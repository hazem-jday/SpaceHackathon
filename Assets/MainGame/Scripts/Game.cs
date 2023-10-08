using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{

    public float t = 0;
    public static bool [] missions;
    public GameObject a1,a2,a3,a4,a6,oxygen;
    void Start()
    {
        missions = new bool[5];
        missions[0] = true;
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (missions[0])
        {
            if (t > 1)
            {
                Instantiate(a1);
                missions[0] = false;
                missions[1] = true;
                t = 0;
            }
        }
        if (missions[1])
        {
            if (t > 15)
            {
                Instantiate(a2);
                missions[1] = false;
                t = 0;
            }
        }
        if (missions[2])
        {

            Instantiate(a3);
            missions[2] = false;
            missions[3] = true;
            t = 0;
        }

        if (missions[3])
        {
            if(t > 7)
            {
                Instantiate(a4);
                missions[3] = false;
                t = 0;
            }
            
        }

        if (missions[4])
        {
            if (t > 15)
            {
                Instantiate(a6);
                missions[4] = false;
                t = 0;
            }

        }


    }
}
