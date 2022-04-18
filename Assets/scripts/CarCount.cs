using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCount : MonoBehaviour
{
    private int CarsCount;
    private int CarSelect = 0;
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {
        CarsCount = transform.childCount;
    }

    public void CarChange()
    {
        transform.GetChild(CarSelect).gameObject.SetActive(false);
        if (CarSelect < CarsCount -1 )
        {
            CarSelect++;
        }
        else
        {
            CarSelect = 0;
        }
        transform.GetChild(CarSelect).gameObject.SetActive(true);

    }
}
