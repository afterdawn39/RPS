using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DancingSpritetest : MonoBehaviour {
  
    SpriteRenderer m_Sprite;
    // Use this for initialization
    void Start () {

      m_Sprite = GetComponent<SpriteRenderer>();
    
	}
	
	// Update is called once per frame
	void Update () {

        if (m_Sprite.flipX== true && ManagerTest.Instance.TIME > 60/ManagerTest.Instance.BPM)   
        {
            m_Sprite.flipX = false;
            ManagerTest.Instance.TIME = 0;
        }
        if (m_Sprite.flipX == false && ManagerTest.Instance.TIME > 60/ManagerTest.Instance.BPM)
            {
            m_Sprite.flipX = true;
            ManagerTest.Instance.TIME = 0;
        }
        
    }

}
