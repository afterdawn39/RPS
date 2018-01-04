using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    public GameObject level1;
    public GameObject level2;
    public GameObject level3;

    public GameObject player;
    public GameObject spawner;

    bool level1Bool = true;
    bool level2Bool = false;
    bool level3Bool = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        print("Trigger");

        if (level1Bool)
        {
            level1.SetActive(false);
            level1Bool = false;

            level2.SetActive(true);
            level2Bool = true;

            player.transform.position = spawner.transform.position; 

        }
        else if (level2Bool)
        {
            level2.SetActive(false);
            level2Bool = false;

            level3.SetActive(true);
            level3Bool = true;

            player.transform.position = spawner.transform.position;
        }
        else if (level3Bool)
        {
            level3.SetActive(false);
            level3Bool = false;

            level1.SetActive(true);
            level1Bool = true;

            player.transform.position = spawner.transform.position;
            //Application.Quit();
        }
    }
}
