using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Transform Car;
    private bool CarMoveStartPos;
    private Vector3 CarOldPos;
    private float OldZ;
    public Vector3 MovePosition;
    public float SteepOfset;
    private float Ofset;
    private float Zrotat;
    private Animator Animator;

    private void Start()
    {
        Animator = GetComponent<Animator>();
        Car.transform.position += new Vector3(0, 0, 1.8f);
        CarOldPos = Car.transform.position;
    }
    void Update()
    {   
        if (CarMoveStartPos && Car.transform.position != MovePosition)
        {
            Ofset += Time.deltaTime * SteepOfset;
            Car.transform.position = Vector3.Lerp(CarOldPos, MovePosition, Ofset);
            Zrotat = Mathf.Lerp(45, 0, Ofset);
            Car.transform.rotation = Quaternion.Euler(new Vector3(0, 0, Zrotat));
        }

        if (Ofset >= 1)
        {
            SceneManager.LoadScene(1);
        }
    }
    public void StartBt()
    {
        Animator.SetBool("StartGame",true);
    }
    public void StartGame()
    {
    }

    public void CloseGame()
    {
        Application.Quit();
    }

    public void CarMoveStart()
    {
        CarMoveStartPos = true;
    }


}
