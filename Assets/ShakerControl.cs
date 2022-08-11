using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class ShakerControl : MonoBehaviour
{

    public Player p1 ;
    public Player p2 ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( p1.isBomb )
        {
            gameObject.GetComponent<CameraShaker>().ShakeOnce(5,3,0.1f,2f); 
            p1.isBomb = false ;
        }
        if ( p2.isBomb )
        {
            gameObject.GetComponent<CameraShaker>().ShakeOnce(5,3,0.1f,2f); 
            p2.isBomb = false ;
        }
    }
}
