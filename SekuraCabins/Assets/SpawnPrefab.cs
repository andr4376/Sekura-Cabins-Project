using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefab : MonoBehaviour {


    [SerializeField]
    private GameObject prefab;
    [SerializeField]
    private Transform position;

    // Use this for initialization


    public void SpawnObject()
    {
        GameObject go = GameObject.Instantiate(prefab, position);

        go.transform.localScale = go.transform.localScale * 100;

        Debug.Log("REEEEEEEEEEEEEEEE");
    }
}
