using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_WallDetection : MonoBehaviour {
    public GameObject Player;
    private DN_PlayerMovement PlayerScript;
    public bool TopDetection;
    public bool BotDetection;
    public bool RightDetection;
    public bool LeftDetection;
    public bool o;
    public bool Square;
    public bool Triangle;
    public bool X;
	// Use this for initialization
	void Start () {
        PlayerScript = Player.GetComponent<DN_PlayerMovement>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerStay(Collider other)
    {
        if (TopDetection)
        {
            if (other.tag == "Wall")
            {
                PlayerScript.StopTop = true;
            }
            if (other.tag == "FakeWall")
            {
                PlayerScript.StopTop = true;
            }
            if (o && other.tag == "Square")
            {
                PlayerScript.StopTop = true;
            }
            if (o && other.tag == "X")
            {
                PlayerScript.StopTop = true;
            }
            if (o && other.tag == "Triangle")
            {
                PlayerScript.StopTop = true;
            }
            if (Square && other.tag == "O")
            {
                PlayerScript.StopTop = true;
            }
            if (Square && other.tag == "X")
            {
                PlayerScript.StopTop = true;
            }
            if (Square && other.tag == "Triangle")
            {
                PlayerScript.StopTop = true;
            }
            if (Triangle && other.tag == "Square")
            {
                PlayerScript.StopTop = true;
            }
            if (Triangle && other.tag == "O")
            {
                PlayerScript.StopTop = true;
            }
            if (Triangle && other.tag == "X")
            {
                PlayerScript.StopTop = true;
            }
            if (X && other.tag == "Square")
            {
                PlayerScript.StopTop = true;
            }
            if (X && other.tag == "O")
            {
                PlayerScript.StopTop = true;
            }
            if (X && other.tag == "Triangle")
            {
                PlayerScript.StopTop = true;
            }

        }
        if(BotDetection)
        {
            if (other.tag == "Wall")
            {
                PlayerScript.StopBot = true;
            }
            if (other.tag == "FakeWall")
            {
                PlayerScript.StopBot = true;
            }
            if (o && other.tag == "Square")
            {
                PlayerScript.StopBot = true;
            }
            if (o && other.tag == "X")
            {
                PlayerScript.StopBot = true;
            }
            if (o && other.tag == "Triangle")
            {
                PlayerScript.StopBot = true;
            }
            if (Square && other.tag == "O")
            {
                PlayerScript.StopBot = true;
            }
            if (Square && other.tag == "X")
            {
                PlayerScript.StopBot = true;
            }
            if (Square && other.tag == "Triangle")
            {
                PlayerScript.StopBot = true;
            }
            if (Triangle && other.tag == "Square")
            {
                PlayerScript.StopBot = true;
            }
            if (Triangle && other.tag == "O")
            {
                PlayerScript.StopBot = true;
            }
            if (Triangle && other.tag == "X")
            {
                PlayerScript.StopBot = true;
            }
            if (X && other.tag == "Square")
            {
                PlayerScript.StopBot = true;
            }
            if (X && other.tag == "O")
            {
                PlayerScript.StopBot = true;
            }
            if (X && other.tag == "Triangle")
            {
                PlayerScript.StopBot = true;
            }
        }
        if(RightDetection)
        {
            if (other.tag == "Wall")
            {
                PlayerScript.StopRight = true;
            }
            if (other.tag == "FakeWall")
            {
                PlayerScript.StopRight = true;
            }
            if (o && other.tag == "Square")
            {
                PlayerScript.StopRight = true;
            }
            if (o && other.tag == "X")
            {
                PlayerScript.StopRight = true;
            }
            if (o && other.tag == "Triangle")
            {
                PlayerScript.StopRight = true;
            }
            if (Square && other.tag == "O")
            {
                PlayerScript.StopRight = true;
            }
            if (Square && other.tag == "X")
            {
                PlayerScript.StopRight = true;
            }
            if (Square && other.tag == "Triangle")
            {
                PlayerScript.StopRight = true;
            }
            if (Triangle && other.tag == "Square")
            {
                PlayerScript.StopRight = true;
            }
            if (Triangle && other.tag == "O")
            {
                PlayerScript.StopRight = true;
            }
            if (Triangle && other.tag == "X")
            {
                PlayerScript.StopRight = true;
            }
            if (X && other.tag == "Square")
            {
                PlayerScript.StopRight = true;
            }
            if (X && other.tag == "O")
            {
                PlayerScript.StopRight = true;
            }
            if (X && other.tag == "Triangle")
            {
                PlayerScript.StopRight = true;
            }
        }
        if(LeftDetection)
        {
            if (other.tag == "Wall")
            {
                PlayerScript.StopLeft = true;
            }
            if (other.tag == "FakeWall")
            {
                PlayerScript.StopLeft = true;
            }
            if (o && other.tag == "Square")
            {
                PlayerScript.StopLeft = true;
            }
            if (o && other.tag == "X")
            {
                PlayerScript.StopLeft = true;
            }
            if (o && other.tag == "Triangle")
            {
                PlayerScript.StopLeft = true;
            }
            if (Square && other.tag == "O")
            {
                PlayerScript.StopLeft = false;
            }
            if (Square && other.tag == "X")
            {
                PlayerScript.StopLeft = true;
            }
            if (Square && other.tag == "Triangle")
            {
                PlayerScript.StopLeft = true;
            }
            if (Triangle && other.tag == "Square")
            {
                PlayerScript.StopLeft = true;
            }
            if (Triangle && other.tag == "O")
            {
                PlayerScript.StopLeft = true;
            }
            if (Triangle && other.tag == "X")
            {
                PlayerScript.StopLeft = true;
            }
            if (X && other.tag == "Square")
            {
                PlayerScript.StopLeft = true;
            }
            if (X && other.tag == "O")
            {
                PlayerScript.StopLeft = true;
            }
            if (X && other.tag == "Triangle")
            {
                PlayerScript.StopLeft = true;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (TopDetection)
        {
            if (other.tag == "Wall")
            {
                PlayerScript.StopTop = false;
            }
            if (other.tag == "FakeWall")
            {
                PlayerScript.StopTop = false;
            }
            if (o && other.tag == "Square")
            {
                PlayerScript.StopTop = false;
            }
            if (o && other.tag == "X")
            {
                PlayerScript.StopTop = false;
            }
            if (o && other.tag == "Triangle")
            {
                PlayerScript.StopTop = false;
            }
            if (Square && other.tag == "O")
            {
                PlayerScript.StopTop = false;
            }
            if (Square && other.tag == "X")
            {
                PlayerScript.StopTop = false;
            }
            if (Square && other.tag == "Triangle")
            {
                PlayerScript.StopTop = false;
            }
            if (Triangle && other.tag == "Square")
            {
                PlayerScript.StopTop = false;
            }
            if (Triangle && other.tag == "O")
            {
                PlayerScript.StopTop = false;
            }
            if (Triangle && other.tag == "X")
            {
                PlayerScript.StopTop = false;
            }
            if (X && other.tag == "Square")
            {
                PlayerScript.StopTop = false;
            }
            if (X && other.tag == "O")
            {
                PlayerScript.StopTop = false;
            }
            if (X && other.tag == "Triangle")
            {
                PlayerScript.StopTop = false;
            }

        }
        if (BotDetection)
        {
            if (other.tag == "Wall")
            {
                PlayerScript.StopBot = false;
            }
            if (other.tag == "FakeWall")
            {
                PlayerScript.StopBot = false;
            }
            if (o && other.tag == "Square")
            {
                PlayerScript.StopBot = false;
            }
            if (o && other.tag == "X")
            {
                PlayerScript.StopBot = false;
            }
            if (o && other.tag == "Triangle")
            {
                PlayerScript.StopBot = false;
            }
            if (Square && other.tag == "O")
            {
                PlayerScript.StopBot = false;
            }
            if (Square && other.tag == "X")
            {
                PlayerScript.StopBot = false;
            }
            if (Square && other.tag == "Triangle")
            {
                PlayerScript.StopBot = false;
            }
            if (Triangle && other.tag == "Square")
            {
                PlayerScript.StopBot = false;
            }
            if (Triangle && other.tag == "O")
            {
                PlayerScript.StopBot = false;
            }
            if (Triangle && other.tag == "X")
            {
                PlayerScript.StopBot = false;
            }
            if (X && other.tag == "Square")
            {
                PlayerScript.StopBot = false;
            }
            if (X && other.tag == "O")
            {
                PlayerScript.StopBot = false;
            }
            if (X && other.tag == "Triangle")
            {
                PlayerScript.StopBot = false;
            }
        }
        if (RightDetection)
        {
            if (other.tag == "Wall")
            {
                PlayerScript.StopRight = false;
            }
            if (other.tag == "FakeWall")
            {
                PlayerScript.StopRight = false;
            }
            if (o && other.tag == "Square")
            {
                PlayerScript.StopRight = false;
            }
            if (o && other.tag == "X")
            {
                PlayerScript.StopRight = false;
            }
            if (o && other.tag == "Triangle")
            {
                PlayerScript.StopRight = false;
            }
            if (Square && other.tag == "O")
            {
                PlayerScript.StopRight = false;
            }
            if (Square && other.tag == "X")
            {
                PlayerScript.StopRight = false;
            }
            if (Square && other.tag == "Triangle")
            {
                PlayerScript.StopRight = false;
            }
            if (Triangle && other.tag == "Square")
            {
                PlayerScript.StopRight = false;
            }
            if (Triangle && other.tag == "O")
            {
                PlayerScript.StopRight = false;
            }
            if (Triangle && other.tag == "X")
            {
                PlayerScript.StopRight = false;
            }
            if (X && other.tag == "Square")
            {
                PlayerScript.StopRight = false;
            }
            if (X && other.tag == "O")
            {
                PlayerScript.StopRight = false;
            }
            if (X && other.tag == "Triangle")
            {
                PlayerScript.StopRight = false;
            }
        }
        if (LeftDetection)
        {
            if (other.tag == "Wall")
            {
                PlayerScript.StopLeft = false;
            }
            if (other.tag == "FakeWall")
            {
                PlayerScript.StopLeft = false;
            }
            if (o && other.tag == "Square")
            {
                PlayerScript.StopLeft = false;
            }
            if (o && other.tag == "X")
            {
                PlayerScript.StopLeft = false;
            }
            if (o && other.tag == "Triangle")
            {
                PlayerScript.StopLeft = false;
            }
            if (Square && other.tag == "O")
            {
                PlayerScript.StopLeft = false;
            }
            if (Square && other.tag == "X")
            {
                PlayerScript.StopLeft = false;
            }
            if (Square && other.tag == "Triangle")
            {
                PlayerScript.StopLeft = false;
            }
            if (Triangle && other.tag == "Square")
            {
                PlayerScript.StopLeft = false;
            }
            if (Triangle && other.tag == "O")
            {
                PlayerScript.StopLeft = false;
            }
            if (Triangle && other.tag == "X")
            {
                PlayerScript.StopLeft = false;
            }
            if (X && other.tag == "Square")
            {
                PlayerScript.StopLeft = false;
            }
            if (X && other.tag == "O")
            {
                PlayerScript.StopLeft = false;
            }
            if (X && other.tag == "Triangle")
            {
                PlayerScript.StopLeft = false;
            }
        }
    }
}
