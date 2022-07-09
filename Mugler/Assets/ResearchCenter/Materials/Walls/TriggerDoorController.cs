using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorController : MonoBehaviour
{
    [SerializeField] private Animator mydoor = null;
    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("HitHappened");

        //if(other.CompareTag("Player"))
        {
            if(openTrigger)
            {
                mydoor.Play("OpenDoor", 0, 0.0f);
            }
            else if(closeTrigger)
            {
                mydoor.Play("CloseDoor", 0, 0.0f);
            }
        }
    }
    public void looked()
    {
        mydoor.Play("OpenDoor", 0, 0.0f);
    }    
}
