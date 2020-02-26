using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vytah_move : MonoBehaviour
{

    public float speed = 0.1f;
    bool isUpDirection = true;

    public GameObject spodnyDoraz;
    public GameObject hornyDoraz;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveY = 0;
        if (isUpDirection) {
            moveY += Time.deltaTime * speed;
        }

        if (!isUpDirection) {
            moveY -= Time.deltaTime * speed;
        }

        transform.SetPositionAndRotation(new Vector3(transform.position.x, transform.position.y +moveY, transform.position.z), Quaternion.identity);
    }

    public void OnTriggerEnter(Collider other) {
        if (other.name == hornyDoraz.name) {
            isUpDirection = false;
        }

        if (other.name == spodnyDoraz.name) {
            isUpDirection = true;
        }
        
    }

}
