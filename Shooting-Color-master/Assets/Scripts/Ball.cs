using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Spike")
        {
            Destroy(gameObject);
        }

        if(other.tag == "Corner")
        {
            
            Vector3 topRight = new Vector3(0.0f, 90.0f, 180.0f);
            Vector3 topLeft = new Vector3(270.0f, 270.0f, 0.0f);
            Vector3 botRight = new Vector3(90.0f, 270.0f, 0.0f);
            Vector3 botLeft = new Vector3(90.0f, 90.0f, 0.0f);

            Vector3 rightCannBall = new Vector3(0.0f, 0.0f, 180.0f);
            Vector3 leftCannBall = new Vector3(0.0f, 0.0f, 0.0f);
            Vector3 topCannBall = new Vector3(0.0f, 0.0f, 270.0f);
            Vector3 botCannBall = new Vector3(0.0f, 0.0f, 90.0f);

            Vector3 rotationAngle = new Vector3(0.0f, 0.0f, 90.0f);

            Debug.Log(other.transform.rotation.eulerAngles + " + " + topLeft);

            if (other.transform.rotation.eulerAngles == topRight)
            {
                if(gameObject.transform.eulerAngles == leftCannBall)
                {
                    gameObject.transform.eulerAngles -= rotationAngle;
                }
                else if(gameObject.transform.eulerAngles == botCannBall)
                {
                    gameObject.transform.eulerAngles += rotationAngle;
                }
            }
            else if(other.transform.rotation.eulerAngles == topLeft)
            {
                if (gameObject.transform.eulerAngles == rightCannBall)
                {
                    gameObject.transform.eulerAngles += rotationAngle;
                }
                else if (gameObject.transform.eulerAngles == botCannBall)
                {
                    gameObject.transform.eulerAngles -= rotationAngle;
                }
            }
            else if (other.transform.rotation.eulerAngles == botLeft)
            {
                if (gameObject.transform.eulerAngles == rightCannBall)
                {
                    gameObject.transform.eulerAngles -= rotationAngle;
                }
                else if (gameObject.transform.eulerAngles == topCannBall)
                {
                    gameObject.transform.eulerAngles += rotationAngle;
                }
            }
            else if(other.transform.rotation.eulerAngles == botRight)
            {
                if (gameObject.transform.eulerAngles == leftCannBall)
                {
                    gameObject.transform.eulerAngles += rotationAngle;
                }
                else if (gameObject.transform.eulerAngles == topCannBall)
                {
                    gameObject.transform.eulerAngles -= rotationAngle;
                }
            }
        }
    }
}
