using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{

    bool movable = true;
    private float timer;

    public GameObject rig;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (movable)
        {

            //dropdown
            if ((Time.time - timer > GameLogick.dropTime) || (Input.GetKeyDown(KeyCode.DownArrow) && Time.time - timer > GameLogick.quickdropTime))
            {
                gameObject.transform.position -= new Vector3(0, 1, 0);
                timer = Time.time;
            }


            //sidemove
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                gameObject.transform.position -= new Vector3(1, 0, 0);
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                gameObject.transform.position += new Vector3(1, 0, 0);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                rig.transform.eulerAngles -= new Vector3(0, 0, 90 );
            }
        }
    }
}
