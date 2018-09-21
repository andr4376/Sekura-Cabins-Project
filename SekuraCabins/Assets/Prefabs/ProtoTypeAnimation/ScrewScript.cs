using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrewScript : MonoBehaviour {

    [SerializeField]
    [Tooltip("The machine the screws are connected to")]
    private MachineScript machine;

    private Animator animator;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        machine = GetComponentInParent<MachineScript>();
	}

    private void OnMouseDown()
    {
        animator.SetTrigger("Screw");
        machine.DecrementStepCount();
    }
}
