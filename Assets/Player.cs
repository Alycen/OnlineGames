using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    Transform thisTransform;
    public float speed;
	// Use this for initialization
	void Start () {
        thisTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {
        //if (GetComponent<NetworkView>().isMine)
        //{
            InputMovement();
        //}
	}

    private void InputMovement()
    {
        Vector2 pos = thisTransform.position;
        if (Input.GetKey(KeyCode.W))
        {
            pos.y += speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            pos.y -= speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            pos.x += speed;
        }

        thisTransform.position = pos;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("CAUGHT");
    }
}
