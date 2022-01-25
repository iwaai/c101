using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dosri_line : MonoBehaviour
{

    public LineRenderer lrr;
    //public Transform[] point;
    private void Awake()
    {
        lrr = GetComponent<LineRenderer>();

    }
    public void SetLine(/*Vector3 firstPoint*/ Vector3 SecondPoint)
    {
        lrr.positionCount = 1;
        Vector3[] point = new Vector3[1];
        point[0] = SecondPoint;
        //point[1] = firstPoint;
        lrr.SetPositions(point);



    }

}
