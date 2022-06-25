using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_track : MonoBehaviour
{

    public GameObject character;
    public Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {
      character = GameObject.FindWithTag("Player");
      //var target = character.transform;   
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = character.transform.position + offset;
    }
}
