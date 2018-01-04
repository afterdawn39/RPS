using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerTest : MonoBehaviour {

    public static ManagerTest Instance { get; private set; }

    // Values
    public float BPM;  // Beats Per Minute
    public float TIME; // Time in sec
    public float TIMEDelay; // Time delay  
    public float GracePeriod; /// grace period for and after 

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else {
            Destroy(gameObject);
        }

    }

    void Update()
    {
        TIME = TIME + 1 * Time.deltaTime;
    } 

}
