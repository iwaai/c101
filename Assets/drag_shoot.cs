using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag_shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public float power = 10f;
    public Rigidbody2D rb;
    public Vector2 MinPower;
    public Vector2 MaxPower;
    public Transform player;
    line_maker tl;
    dosri_line dosri;
   // private Transform[] pp;




    Camera cam;
    Vector2 force;
    Vector3 startPoint;
    Vector3 EndPoint;

    //Vector3 firstpoint;
   // Vector3 secondpoint;


    void Start()
    {
        cam = Camera.main;
        tl = GetComponent<line_maker>();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPoint = player.transform.position;

            //startPoint.z = 15;

            Debug.Log(startPoint);
            

        }
        if (Input.GetMouseButton(0))
        {
            Vector3 currentPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            tl.RenderLine( currentPoint, startPoint);

            dosri.SetLine(startPoint);


        }

        if (Input.GetMouseButtonUp(0))
        {
            EndPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            EndPoint.z = 15;
            force = new Vector2(Mathf.Clamp(startPoint.x - EndPoint.x, MinPower.x, MaxPower.x), Mathf.Clamp(startPoint.y - EndPoint.y, MinPower.y, MaxPower.y));
            rb.AddForce(force * power, ForceMode2D.Impulse);
            tl.endline();

        } 

    }
}
