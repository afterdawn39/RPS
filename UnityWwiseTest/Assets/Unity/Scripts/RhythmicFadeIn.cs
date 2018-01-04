using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RhythmicFadeIn : MonoBehaviour {

    public GameObject gameObject;

    private float Distance;
    private static Vector2 gameObjectLocation;


    // Use this for initialization
    void Start () {
        AkSoundEngine.PostEvent("StartRhythmic", gameObject);
        //gameObjectLocation  = gameObject.GetComponent<Renderer>.transform);
    }

    // Update is called once per frame
    void Update () {

        //Distance = Vector2.Distance(gameObject);

    }
}
