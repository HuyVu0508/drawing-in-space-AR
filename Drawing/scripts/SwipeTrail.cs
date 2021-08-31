using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeTrail : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // // Experimenting
        // if((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        // || Input.GetMouseButton(0))
        // {
        //     Plane objPlane = new Plane(Camera.main.transform.forward*= -1, this.transform.position);

        //     Ray mRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        //     float rayDistance;
        //     if (objPlane.Raycast(mRay, out rayDistance))
        //         this.transform.position = mRay.GetPoint(rayDistance);
        // }

        // Following camera
        if((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) || Input.GetMouseButton(0))
        {
            Vector3 front_camera_position = Camera.main.transform.position + 0.16f*Camera.main.transform.forward;
            this.transform.position = front_camera_position;
        }


    }
}
