using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Collide : MonoBehaviour
{

    public GameObject player;
    public GameObject playerPrefab;
    public Transform spawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerMovement>().enabled = false;
            player = Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);
            Destroy(other.gameObject);

        }
    }
}
