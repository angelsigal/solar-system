using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loolat : MonoBehaviour
{
    // target that camera should look at
    static public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        if(target == null)
        {
            target = this.gameObject;
            Debug.Log("change look target is not specified. defaulting to parent Gameobject.");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(target){
            transform.LookAt(target.transform);
        }   
    }
}
