using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerMusic : MonoBehaviour
{

    public static ManagerMusic Instance { get; private set; }

    // Values
    public float ValueTest;  // TEST
    

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }

    }

    void Start() {
        // start music (test)

    

    }

    void Update()
    {
       
    }

}
