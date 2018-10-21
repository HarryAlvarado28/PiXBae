using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveGoPlanet1 : MonoBehaviour {
    //--------------
    /*
    public float movementSpeed = 1f;
    public float rotationSpeed = 1f;

    Vector3 targetPosition;
    Vector3 towerdsTarget;
    private float wanderRadius = 5f;

    void RecalculateTargetPosition(){
        targetPosition = transform.position + Random.insideUnitSphere * wanderRadius;
        targetPosition.y = 0;
    }
    */
    //-----------
    public float visionRadius;
    public float speed;

    GameObject planet;
    Vector3 initialPosition;
    // Use this for initialization
    void Start()
    {
        //RecalculateTargetPosition();
        //Simple AI

        planet = GameObject.FindGameObjectWithTag("Planet");
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        /*
         * towerdsTarget = targetPosition - transform.position;
        if(towerdsTarget.magnitude < 0.25f){
            RecalculateTargetPosition();
            transform.position += towerdsTarget.normalized * movementSpeed * Time.deltaTime;

            Debug.DrawLine(transform.position, targetPosition, Color.green);
        }
        */

        //Quaternion towardsTargetRotation = Quaternion.LookRotation(towerdsTarget, Vector3.up);
        //transform.rotation = Quaternion.Lerp(transform.rotation, towardsTargetRotation, rotationSpeed * Time.deltaTime);

        Vector3 target = initialPosition;
        float dist = Vector3.Distance(planet.transform.position, transform.position);
        if (dist < visionRadius) target = planet.transform.position;

        float fixedSpeed = speed * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, target, fixedSpeed);

        Debug.DrawLine(transform.position, target, Color.green);


    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, visionRadius);
    }
}
