using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KoniecHry : MonoBehaviour
{

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.name == player.name)
        {
            Debug.Log("player ended game");
            KeepScore.Score += 1;
            Destroy(gameObject);
        }

    }

}
