using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{

    public GameObject player;
    public float speed;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.left * speed * Time.deltaTime);
    }

    public void OnTriggerEnter(Collider other) {

         if (other.name == player.name)
         {
             Debug.Log("player touched  SCORE");
             KeepScore.Score +=1;
             Destroy(gameObject);
         }

     }
}
