using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementTest : MonoBehaviour {
    Vector2 up;
    Vector2 right;
    Vector2 upRight;
    Vector2 downRight;
    
    public Rigidbody2D rb2D;
	
    // Use this for initialization
	void Start () {

        rb2D = GetComponent<Rigidbody2D>();
        up = new Vector2(0.0f,20.0f);
        right = new Vector2(20.0f, 0.0f);
        upRight = new Vector2(15.0f, 15.0f);
        downRight = new Vector2(15.0f, -15.0f);
    
}
	
	// Update is called once per frame
	void Update () {


        // 1 input **************************************************************

        if (Input.GetKey("up") == true && Input.GetKey("down") == false && (Input.GetKey("right") == false && Input.GetKey("left") == false|| (Input.GetKey("right") == true && Input.GetKey("left") == true)) )// && ( ManagerTest.Instance.TIME < 0 + 0.1f  ||  ManagerTest.Instance.TIME > (60 / ManagerTest.Instance.BPM - 0.1f) ))
        {
            rb2D.MovePosition(rb2D.position + up*Time.deltaTime);
        }

        if (Input.GetKey("up") == false && Input.GetKey("down") == true && (Input.GetKey("right") == false && Input.GetKey("left") == false || (Input.GetKey("right") == true && Input.GetKey("left") == true))) //&& ( ManagerTest.Instance.TIME < 0 + 0.1f  ||  ManagerTest.Instance.TIME > (60 / ManagerTest.Instance.BPM - 0.1f) ))
        {
            rb2D.MovePosition(rb2D.position - up * Time.deltaTime);
        }

        if ((Input.GetKey("up") == false && Input.GetKey("down") == false || Input.GetKey("up") == true && Input.GetKey("down") == true) && Input.GetKey("right") == true && Input.GetKey("left") == false)// && (ManagerTest.Instance.TIME < 0 + 0.1f || ManagerTest.Instance.TIME > (60 / ManagerTest.Instance.BPM - 0.1f)))
        {
            rb2D.MovePosition(rb2D.position + right * Time.deltaTime);
        }

        if ((Input.GetKey("up") == false && Input.GetKey("down") == false || (Input.GetKey("up") == true) && Input.GetKey("down") == true) && Input.GetKey("right") == false && Input.GetKey("left") == true)// && (ManagerTest.Instance.TIME < 0 + 0.1f || ManagerTest.Instance.TIME > (60 / ManagerTest.Instance.BPM - 0.1f)))
        {
            rb2D.MovePosition(rb2D.position - right * Time.deltaTime);
        }


        // 2 input ****************************************************************************

        if (Input.GetKey("up") == true && Input.GetKey("down") == false && Input.GetKey("right") == true && Input.GetKey("left") == false )// && ( ManagerTest.Instance.TIME < 0 + 0.1f  ||  ManagerTest.Instance.TIME > (60 / ManagerTest.Instance.BPM - 0.1f) ))
        {
            rb2D.MovePosition(rb2D.position + upRight * Time.deltaTime);
        }

        if (Input.GetKey("up") == true && Input.GetKey("down") == false && Input.GetKey("right") == false && Input.GetKey("left") == true) //&& ( ManagerTest.Instance.TIME < 0 + 0.1f  ||  ManagerTest.Instance.TIME > (60 / ManagerTest.Instance.BPM - 0.1f) ))
        {
            rb2D.MovePosition(rb2D.position - downRight * Time.deltaTime);
        }

        if (Input.GetKey("up") == false && Input.GetKey("down") == true && Input.GetKey("right") == true && Input.GetKey("left") == false)// && (ManagerTest.Instance.TIME < 0 + 0.1f || ManagerTest.Instance.TIME > (60 / ManagerTest.Instance.BPM - 0.1f)))
        {
            rb2D.MovePosition(rb2D.position + downRight * Time.deltaTime);
        }

        if (Input.GetKey("up") == false && Input.GetKey("down") == true && Input.GetKey("right") == false && Input.GetKey("left") == true)// && (ManagerTest.Instance.TIME < 0 + 0.1f || ManagerTest.Instance.TIME > (60 / ManagerTest.Instance.BPM - 0.1f)))
        {
            rb2D.MovePosition(rb2D.position - upRight * Time.deltaTime);
        }


    }
}
