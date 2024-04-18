using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peel : MonoBehaviour
{
    private Animator PlayerAnim;
    private bool isopen = false;
    // Start is called before the first frame update
    void Start()
    {
        PlayerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //change the input to controller's trigger
        if(Input.GetKey(KeyCode.O))
        {
            if(isopen)
            {
                PlayerAnim.SetBool("Peel1", false);
                isopen = !isopen;
            }
            else
            {
                PlayerAnim.SetBool("Peel1",true);
                isopen = !isopen;
            }
        }
    }
}
