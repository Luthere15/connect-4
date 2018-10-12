using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grid : MonoBehaviour
{
    [Header("set in Inspector")]
    public GameObject prefabGamePiece;

    [Header("ser Dynamcally")]
    public Vector3 launchPos;
    public GameObject gamepiece;

    void Awake()
    {
       // launchPos = launchPosTrans.position;
    }
    void OnMouseEnter()
    {
        print("game piece enter()");
    }
    void OnMouseExit()
    {
        print("game piece exit()");
    }

    void OnMouseDown()
    {
        gamepiece = Instantiate(prefabGamePiece) as GameObject;
        gamepiece.transform.position = launchPos;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
