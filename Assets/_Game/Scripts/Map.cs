using UnityEngine;
using System.Collections;

public class Map : MonoBehaviour {


    EventReceiver eventReceiver;
    
	// Use this for initialization
	void Start () {
        eventReceiver = GameObject.FindObjectOfType<EventReceiver>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        eventReceiver.OnMapDown();
    }
    void OnMouseUp()
    {
        eventReceiver.OnMapUp();
    }
}
