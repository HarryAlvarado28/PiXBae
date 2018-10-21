using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inform2 : MonoBehaviour
{

    public GameObject Inform_I;
    public static GameObject Inform_static;

    // Use this for initialization
    void Start()
    {
        Inform2.Inform_static = Inform_I;
        Inform2.Inform_static.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void show()
    {
        Inform2.Inform_static.gameObject.SetActive(true);

    }
    public static void cerrar()
    {
        Inform2.Inform_static.gameObject.SetActive(false);
    }
}