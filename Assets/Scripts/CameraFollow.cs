using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    public float x = 30f;
    public float y = 2f;
    public float z = -3f;

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(x, y, player.transform.position.z + z);
    }
}
