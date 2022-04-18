using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Camera Cam;
    public float SpeedX = 0.1f;
    public float SpeedY = 0.1f;
    public float CameraZ = -10f;
    public float CameraHigh = 11f;
    public float CameraLow = 5f;
    public float SpeedZoom = 0.1f;
    public float DelaySec = 5f;

    private float NewX;
    private float NewY;
    private float time = 0;

    void Start()
    {
        Cam.orthographicSize = CameraHigh;
        NewX = 0;
        NewY = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (time > DelaySec)
        {
            if (NewX != transform.position.x)
            {
                NewX = Mathf.Lerp(NewX, transform.position.x, SpeedX * Time.deltaTime);
            }
            if (NewY != transform.position.y)
            {
                NewY = Mathf.Lerp(NewY, transform.position.y, SpeedY * Time.deltaTime);
            }
            if (Cam.orthographicSize > (CameraLow + 0.2f))
            {
                Cam.orthographicSize = Mathf.Lerp(Cam.orthographicSize, CameraLow, SpeedZoom * Time.deltaTime);
            }
        }

        if (time < DelaySec)
        {
            time += Time.deltaTime;
        }
    }

    private void LateUpdate()
    {
        Cam.transform.position = new Vector3(NewX, NewY, CameraZ);
    }
}
