using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

    public GameObject playerPrefab;

	// Use this for initialization
	void Start () {
        GameObject.Instantiate(playerPrefab, new Vector3(-7,0,0), new Quaternion());
        //Network.Instantiate(playerPrefab, new Vector3(0,0,0), new Quaternion(), 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
