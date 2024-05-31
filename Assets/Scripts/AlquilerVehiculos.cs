using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlquilerVehiculos : MonoBehaviour
{
    public GameObject[] vehiculos;
    
    // Start is called before the first frame update
    void Start()
    {
        ResetearVehiculos();
        vehiculos[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            for (int i = 0; i < vehiculos.Length; i++)
            {
                vehiculos[i].SetActive(false);
            }
            int random;
            random = Random.Range(0, vehiculos.Length);
            vehiculos[random].SetActive(true);
        }   
    }

    void ResetearVehiculos()
    {
        for (int i = 0; i < vehiculos.Length; i++)
        {
            vehiculos[i].SetActive(false);
        }
    }
}
