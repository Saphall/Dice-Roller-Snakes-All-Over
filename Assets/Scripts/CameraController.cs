using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    public float smoothSpeed = 0.125f;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;

    }

    // Update is called once per frame
    void LateUpdate()
    {  Vector3 desiredPosition = player.transform.position + offset;
       Vector3 smoothPostion = Vector3.Lerp(transform.position,desiredPosition,smoothSpeed*Time.deltaTime);
        transform.position=smoothPostion;
       //transform.position=player.transform.position+offset;

    }
}
