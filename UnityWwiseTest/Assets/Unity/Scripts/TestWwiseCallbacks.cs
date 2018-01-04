using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestWwiseCallbacks : MonoBehaviour {

	// Use this for initialization
	void Start () {
        AkSoundEngine.PostEvent("StartMusic", gameObject);
        AkSoundEngine.SetState("PlayerLife", "Alive");
        AkSoundEngine.SetState("Battle", "NoBattle");
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space was pressed");
            AkSoundEngine.SetState("Battle", "InBattle");
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("B was pressed");
            AkSoundEngine.SetState("Battle", "NoBattle");
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("Z was pressed, you're alive!");
            AkSoundEngine.SetState("PlayerLife", "Alive");
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("X was pressed, you're dead :( ");
            AkSoundEngine.SetState("PlayerLife", "Dead");
        }
    }
}
