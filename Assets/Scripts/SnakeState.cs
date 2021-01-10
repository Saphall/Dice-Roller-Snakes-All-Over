using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeState : MonoBehaviour
{  
    public int a = 0;
    // Update is called once per frame
    void Update()
    {
      transform.Rotate(new Vector3(0,a,0)*Time.deltaTime);      
    }


}
