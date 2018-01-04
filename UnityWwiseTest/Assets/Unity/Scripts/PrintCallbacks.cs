
//#include <AK/SoundEngine/Common/AkCommonDefs.h>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PrintCallbacks : MonoBehaviour {

    int BarCounter = 0;
    int BeatCounter = 0;

    float realBPM = 0;
    float fBeat = 0;

    uint[] playingIDs;


    // Use this for initialization
    void Start() {
        AkSoundEngine.PostEvent("StartMusic", gameObject);
    }

    // Update is called once per frame
    void Update() {


    }

    //Receives callbacks from Wwise on every Entry of a new song
    void CallbackEntry(AkEventCallbackMsg in_info)
    {
        // set the maximum amount of soungs playing at the same time
        uint maxSongsPlaying = 4;
        playingIDs = new uint[maxSongsPlaying];
        AKRESULT res = AkSoundEngine.GetPlayingIDsFromGameObject(gameObject, ref maxSongsPlaying, playingIDs);

        /* Get the specific callback info that we want. AkEventCallbackMsg holds all possible callback information, 
         * we ask it  to focus on AkMusicSyncCallbackInfo and grabs the segmentInfo_fBeatDuration from there */

        AkMusicSyncCallbackInfo info = (AkMusicSyncCallbackInfo)in_info.info;
        float BeatL = info.segmentInfo_fBeatDuration;
        realBPM = 60 / BeatL;
        Debug.Log("The real BPM is: " + realBPM);

        // send messages (the "realBPM") to other objects with SendMessage() 
        ManagerTest.Instance.BPM = realBPM;
    }

    // Receives callbacks from Wwise every bar. Restarts the clock and BeatCounter. Attempts to calculate the BPM.
    void CallbackBar(AkEventCallbackMsg in_info)
    {
        BarCounter++;
        BeatCounter = 0;

        Debug.Log("The current BPM is: " + realBPM);
        Debug.Log("The current bar is: " + BarCounter);
    }

    // Receives callbacks from Wwise every beat. Restarts the clock and adds to the BeatCounter. Attempts to calculate the BPM.
    void CallbackBeat(AkEventCallbackMsg in_info)
    {
        BeatCounter++;
        Debug.Log(BeatCounter);
    }

}
