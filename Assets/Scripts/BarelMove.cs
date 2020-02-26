using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BarelMove : MonoBehaviour
{

    public float speed = 0.1f;
    bool isUpDirection = true;

    public GameObject spodnyDoraz;
    public GameObject hornyDoraz;
    public GameObject player;


    void Start()
    {

    }


    void Update()
    {
        float moveZ = 0;
        if (isUpDirection)
        {
            moveZ -= Time.deltaTime * speed;
        }

        if (!isUpDirection)
        {
            moveZ += Time.deltaTime * speed;
        }

        transform.SetPositionAndRotation(new Vector3(transform.position.x, transform.position.y, transform.position.z + moveZ), Quaternion.identity);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.name == hornyDoraz.name)
        {
            isUpDirection = false;
        }

        if (other.name == spodnyDoraz.name)
        {
            isUpDirection = true;
        }

        if (other.name == player.name)
        {
            Debug.Log("player triger");
        }

        Debug.Log("Triger :" + other.name);

    }

}