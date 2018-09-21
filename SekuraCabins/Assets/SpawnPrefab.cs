using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefab : MonoBehaviour {


    [SerializeField]
    [Tooltip("The Prefab to spawn")]
    private GameObject prefab; 

    [SerializeField]
    [Tooltip("The position you want the prefab to spawn (Use SpawnPoint from Hierarchy")]
    private Transform position; 

    // Use this for initialization


    public void SpawnObject()
    {
        GameObject go = GameObject.Instantiate(prefab, position); 

        go.transform.localScale = go.transform.localScale * 100; //Scales game object, so it fits with canvas size
        
    }
}
