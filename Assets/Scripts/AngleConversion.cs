using System;
using UnityEngine;

public class AngleConversion : MonoBehaviour
{
    public Transform Shoulder;

    private void Update()
    {
        var angle = Shoulder.rotation.eulerAngles.z;
        var radian = Math.PI * angle / 180.0;

        Debug.Log("Deg:" + angle + " Radian: " +  radian);

        

    }
}
