using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inform3 : MonoBehaviour
{

    public GameObject Inform_I;
    public static GameObject Inform_static;

    // Use this for initialization
    void Start()
    {
        Inform3.Inform_static = Inform_I;
        Inform3.Inform_static.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void show()
    {
        Inform3.Inform_static.gameObject.SetActive(true);

    }
    public static void cerrar()
    {
        Inform3.Inform_static.gameObject.SetActive(false);
    }
}
