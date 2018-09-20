using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrewScript : MonoBehaviour {


    private Animator animator;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}

    private void OnMouseDown()
    {
        animator.SetTrigger("Screw");
    }
}
