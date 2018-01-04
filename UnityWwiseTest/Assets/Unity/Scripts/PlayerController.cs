using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;

    //uint[] playingIDs;

    //private readonly AkMusicSyncCallbackInfo in_info;

    // Use this for initialization
    void Start()
    {
        AkSoundEngine.SetState("PlayerLife", "Alive");
        AkSoundEngine.SetState("Battle", "NoBattle");
        AkSoundEngine.PostEvent("StartMusic", gameObject);

        //uint test = 4;
        //playingIDs = new uint[test];
        //AKRESULT res = AkSoundEngine.GetPlayingIDsFromGameObject(gameObject, ref test, playingIDs);
       

        //AkMusicSyncCallbackInfo info = (AkMusicSyncCallbackInfo)in_info;
        //float BeatL = info.segmentInfo_fBeatDuration;
        //float BPM = 60 / BeatL;
        //Debug.Log("The real BPM is: " + BPM);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
        }

        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
        }

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


    void Beat(AkEventCallbackMsg in_info)
    {
        AkSoundEngine.PostEvent("StartMusic", gameObject, 1);
        //AkSoundEngine.GetPlayingSegmentInfo("StartMusic", );
    }


    // ..........Unity CRASHED from this was a desperate attempt at reaching the SegmentInfo...........

    //void MusicCallback(AkCallbackType AK_MusicSyncBeat, AkCallbackInfo AkMusicSyncCallbackInfo)
    //{
    //    fBeat = AkSoundEnginePINVOKE.CSharp_AkMusicSyncCallbackInfo_segmentInfo_fBeatDuration_get(swigCPtr);

    //    float realBPM = 60 / fBeat;
    //    Debug.Log("The current realBPM is: " + realBPM);

    //}
}