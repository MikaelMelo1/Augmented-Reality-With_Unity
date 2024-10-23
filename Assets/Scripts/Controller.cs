using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator_P;
    void Start()
    {
        animator_P = GetComponent<Animator>();
    }

    public void Dance () {
        animator_P.SetBool("Dance", true);
    }

    public void StopDance () {
        animator_P.SetBool("Dance", false);
    }
}
