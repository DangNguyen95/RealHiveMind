using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_PressureplateActivator : MonoBehaviour {
    public GameObject SpriteSelf;
    private Animator SpriteSelfAnim;

    // Use this for initialization
    void Start()
    {
        SpriteSelfAnim = SpriteSelf.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Square")
        {
            SpriteSelfAnim.SetBool("Close", true);
        }
        if (other.tag == "O")
        {
            SpriteSelfAnim.SetBool("Close", true);
        }
        if (other.tag == "X")
        {
            SpriteSelfAnim.SetBool("Close", true);
        }
        if (other.tag == "Triangle")
        {
            SpriteSelfAnim.SetBool("Close", true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Square")
        {
            SpriteSelfAnim.SetBool("Close", false);
        }
        if (other.tag == "O")
        {
            SpriteSelfAnim.SetBool("Close", false);
        }
        if (other.tag == "X")
        {
            SpriteSelfAnim.SetBool("Close", false);
        }
        if (other.tag == "Triangle")
        {
            SpriteSelfAnim.SetBool("Close", false);
        }
    }
}
