using UnityEngine;
using System.Collections;

public class EventReceiver : MonoBehaviour {

    GameState state;

    
	// Use this for initialization
	void Start () {
        state = this.gameObject.GetComponent<GameState>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
    public void OnVillagerDown(Villager villager)
    {
        state.selectedVillager = villager;
    }

    public void OnMapDown()
    {

    }



    public void OnMapUp()
    {
        Villager v = state.selectedVillager;
        if (v)
        {
            NavMeshAgent nav = v.GetComponent<NavMeshAgent>();

            RaycastHit hit;

            Ray ray = this.camera.ScreenPointToRay(Input.mousePosition);

            Physics.Raycast(ray, out hit);

            Vector3 p = hit.point;


            nav.SetDestination(p);
        }
    }
}
