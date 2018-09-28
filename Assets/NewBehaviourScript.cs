using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{


    public int dragonhealth;
    public int playerhealth;



    // Use this for initialization
    void Start()
    {
       // dragonhealth += Random.Range(100 - 151);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) ;
        {
            print(dragonhealth);


        }


    }
}
