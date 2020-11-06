using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{

    public Transform followPlayer;
    public float distance;
    public float angle;
    private float angleRad;
    public float cameraTrackingSpeed;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        angleRad = -angle * Mathf.Deg2Rad;

        // camera position
        this.transform.position = Vector3.Lerp(this.transform.position, followPlayer.position + new Vector3(0, distance * Mathf.Cos(angleRad), distance * Mathf.Sin(angleRad)), cameraTrackingSpeed * Time.deltaTime);
        //this.transform.position = followPlayer.position + new Vector3(0, distance * Mathf.Cos(angleRad), distance * Mathf.Sin(angleRad));
        
        // camera lookat
        Vector3 relativeUp = followPlayer.TransformDirection(Vector3.forward);
        Vector3 relativePos = followPlayer.position - transform.position;
        transform.rotation = Quaternion.LookRotation(relativePos, relativeUp);


    }


}
