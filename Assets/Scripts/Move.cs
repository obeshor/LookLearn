using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    Transform player;
    float speed = 0.1f;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {         //This works with the cardboard trigger too.
            //player.transform.Translate(Vector3.up * speed);
            transform.Translate(Time.deltaTime, 0, 0, Camera.main.transform);
        }
    }
}
