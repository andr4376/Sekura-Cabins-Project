
using System.Collections;
using UnityEngine;

public class MachineScript : MonoBehaviour
{

    [SerializeField]
    private int steps = 4;
    [SerializeField]
    


    public void DecrementStepCount()
    {
        steps--;

        if (steps <= 0)
        {
            //Calls a method that runs paralel and destroys the gameobject 
            //after an amount of seconds
            StartCoroutine(DestroySelf());
        }
    }

    private IEnumerator DestroySelf()
    {
        
        yield return new WaitForSeconds(4);

        Destroy(this.gameObject);
    }


}
