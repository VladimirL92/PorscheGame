using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public float SpeedCar = 3f;
    public float speedrotate = 0.3f;
    private float SpeedRotation = 0.5f;
    public float inertion = 1f;
    private float AngleRotation = -90;
    private float SpeedMove = 0;
    private float TargetBt;
    private bool IsMove;
    private float Stop;
    private bool GazBtn;
    private bool LeftBtn;
    private bool RightBtn;

    public void GazUp()
    {
        GazBtn = true;
    }
    public void GazDown()
    {

        GazBtn = false;
    }

    public void RightDown()
    {
        RightBtn = true;
    }
    public void LeftDown()
    {
        LeftBtn = true;
    }

    public void RLUp()
    {
        LeftBtn = false;
        RightBtn = false;
    }





    void Update()
    {
        Debug.Log(GazBtn);
        SpeedRotation = SpeedMove * speedrotate;
        if (Input.GetKey(KeyCode.W) || GazBtn)
        {
            IsMove = true;
            TargetBt = SpeedCar;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            IsMove = true;
            TargetBt = -SpeedCar;
        }
        else
        {
            TargetBt = 0;
        }

        if (IsMove)
        {
            if (Input.GetKey(KeyCode.D) || RightBtn)
            {
                    AngleRotation -= SpeedRotation * Time.deltaTime;
            }
            else if ( Input.GetKey(KeyCode.A) || LeftBtn)
            {
                    AngleRotation += SpeedRotation * Time.deltaTime;
            }
        }

        if (Input.GetKey (KeyCode.Space))
        {
            Stop = 3;
        }
        else
        {
            Stop = 1;
        }

        if ( SpeedMove != TargetBt)
        {
            SpeedMove = Mathf.Lerp(SpeedMove, TargetBt, (inertion + Stop) * Time.deltaTime);
        }

        transform.position += transform.up * SpeedMove * Time.deltaTime;

        transform.rotation = Quaternion.Euler(0, 0,AngleRotation);
    }

 
}
