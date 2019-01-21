using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DN_BlockGate : MonoBehaviour {
    public GameObject Tile1;
    public GameObject Tile2;
    public GameObject Tile3;
    public GameObject Tile4;
    private DN_YellowTiles Tiles1Scripts;
    private DN_YellowTiles Tiles2Scripts;
    private DN_YellowTiles Tiles3Scripts;
    private DN_YellowTiles Tiles4Scripts;
    public bool part1;
    public bool part2;
    public GameObject FireMannagerObj;
    private DN_FireWallMannager FireMannagerScripts;
	// Use this for initialization
	void Start () {
        FireMannagerScripts = FireMannagerObj.GetComponent<DN_FireWallMannager>();
        if (part1)
        {
            Tiles1Scripts = Tile1.GetComponent<DN_YellowTiles>();
            Tiles2Scripts = Tile2.GetComponent<DN_YellowTiles>();
        }
        if(part2)
        {
            Tiles1Scripts = Tile1.GetComponent<DN_YellowTiles>();
            Tiles2Scripts = Tile2.GetComponent<DN_YellowTiles>();
            Tiles3Scripts = Tile3.GetComponent<DN_YellowTiles>();
            Tiles4Scripts = Tile4.GetComponent<DN_YellowTiles>();

        }

	}
	
	// Update is called once per frame
	void Update () {
        if (part1)
        {
            if (Tiles1Scripts.TileDone && Tiles2Scripts.TileDone)
            {
               // FireMannagerScripts.PartOne = false;
                gameObject.GetComponent<Rigidbody>().isKinematic = false;
                gameObject.GetComponent<Rigidbody>().useGravity = true;
            }
        }
        if (part2)
        {
            if (Tiles1Scripts.TileDone && Tiles2Scripts.TileDone && Tiles3Scripts.TileDone && Tiles4Scripts.TileDone)
            {
                // FireMannagerScripts.PartTwo = false;
                FireMannagerScripts.PartTwo = false;
                gameObject.GetComponent<Rigidbody>().isKinematic = false;
                gameObject.GetComponent<Rigidbody>().useGravity = true;
            }
        }
       
	}
    
}
