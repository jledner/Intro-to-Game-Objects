using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForkliftLogic : MonoBehaviour
{
    public Animator forkliftAnimator;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("RaiseForklift",3);
    }

    void RaiseForklift(){
        forkliftAnimator.SetTrigger("RaiseFork");
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("sphere")){
            RaiseForklift();
        }
    }
}
