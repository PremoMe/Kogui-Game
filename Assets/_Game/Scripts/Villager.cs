using UnityEngine;
using System.Collections;

public class Villager : MonoBehaviour {


    GameState state;
    EventReceiver eventReceiver;

	// Use this for initialization

	void Start () {
        state = GameObject.FindObjectOfType<GameState>();
        eventReceiver = GameObject.FindObjectOfType<EventReceiver>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        eventReceiver.OnVillagerDown(this);

    }

}
