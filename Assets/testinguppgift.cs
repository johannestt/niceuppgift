using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testinguppgift : MonoBehaviour
{

    public int userValue;
    public int starterValue;
    // Use this for initialization
    void Start()
    {

    }

    void task2()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            starterValue += Random.Range(1, 7);
            starterValue -= Random.Range(1, 7);
        }



    }
    

    // Update is called once per frame
    void Update()
    {
        task2();

        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                print(starterValue);

                if (starterValue <= 0)
                {
                    print("You lose");
                }

                if (starterValue >= 20)
                {
                    print("You Win");


                }

            }
        }
    }














}

