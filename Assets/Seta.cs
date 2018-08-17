using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seta : MonoBehaviour {

    public GameObject GotIt;
    public string Orientation;
    public Animator SetaBehaviour;

	// Use this for initialization
	void Start () {
		
	}

    void NextArrow()
    { Debug.Log("I Love You");
        SetaBehaviour.SetBool("Done", true);
    }

	// Update is called once per frame
	void Update () {
        if (Orientation == "U")
        {
            if (Input.GetKeyDown("up"))
            { GotIt.SetActive(true);
                NextArrow();
            }
        }
        if (Orientation == "D")
        {
            if (Input.GetKeyDown("down"))
            { GotIt.SetActive(true);
                NextArrow();
            }
        }
        if (Orientation == "L")
        {
            if (Input.GetKeyDown("left"))
            { GotIt.SetActive(true);
                NextArrow();
            }
        }
        if (Orientation == "R")
        {
            if (Input.GetKeyDown("right"))
            { GotIt.SetActive(true);
                NextArrow();
            }
        }


    }
}
