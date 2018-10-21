using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inform5 : MonoBehaviour
{

    public GameObject Inform_I;
    public static GameObject Inform_static;

    // Use this for initialization
    void Start()
    {
        Inform5.Inform_static = Inform_I;
        Inform5.Inform_static.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void show()
    {
        Inform5.Inform_static.gameObject.SetActive(true);

    }
    public static void cerrar()
    {
        Inform5.Inform_static.gameObject.SetActive(false);
    }
}
