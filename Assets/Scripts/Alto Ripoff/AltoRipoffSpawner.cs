using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltoRipoffSpawner : MonoBehaviour
{
	public List<GameObject> prefabs;
	//private bool done = false;
	public Vector3 spawnLocation;
	public Collider2D boxCollider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Hit");

            int rand = Random.Range(0, prefabs.Count);
            Instantiate(prefabs[rand], spawnLocation, Quaternion.identity, null);
            Destroy(boxCollider); // what and why?
        }
    }
}