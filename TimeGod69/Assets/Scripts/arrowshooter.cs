using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowshooter : MonoBehaviour
{
    private GameObject arrowPrefab;
    public Transform Cam;
    // Start is called before the first frame update
    void Start()
    {
        arrowPrefab = Resources.Load("arrow") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newArrow = Instantiate(arrowPrefab) as GameObject;
            newArrow.transform.position = transform.position;
            Rigidbody rb = newArrow.GetComponent<Rigidbody>();
            
            rb.velocity = Cam.transform.forward*30;
        }
    }
}
