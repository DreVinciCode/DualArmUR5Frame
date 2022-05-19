using System;
using UnityEngine;

public class AngleConversion : MonoBehaviour
{

    /*
    * rt_shoulder_pan: 2.005
    * rt_shoulder_lift: -2.10
    * rt_elbow: -1.166
    * rt_wrist_1: 3.14
    * rt_wrist_2: -0.106
    * rt_wrist_3: -1.836
    * */
    public Transform Shoulder_Pan;
    public Transform Shoulder_Tilt;
    public Transform Elbow;
    public Transform Wrist_1;
    public Transform Wrist_2;
    public Transform Wrist_3;

    private void Start()
    {
        Shoulder_Pan.localEulerAngles = new Vector3(0, 0, RadianToDegree(2.005f));
        Shoulder_Tilt.localEulerAngles = new Vector3(0, RadianToDegree(-2.10f), 0);
        Elbow.localEulerAngles = new Vector3(0, RadianToDegree(-1.166f), 0);
        Wrist_1.localEulerAngles = new Vector3(0,RadianToDegree(3.14f), 0);
        Wrist_2.localEulerAngles = new Vector3(0, 0, RadianToDegree(-0.106f));
        Wrist_3.localEulerAngles = new Vector3(0, RadianToDegree(-1.836f), 0);
    }

    private void Update()
    {
        //Debug.Log( Shoulder_Pan.localEulerAngles.z);
        //var angle = Shoulder.rotation.eulerAngles.z;
        //var radian = Math.PI * angle / 180.0;

        //Debug.Log("Deg:" + angle + " Radian: " +  radian);

    }

    private float RadianToDegree(float radian)
    {
        if (radian < 0)
            return (radian +  2 * (float)Math.PI) * (180.0f / (float)Math.PI);
        else
            return radian * (180.0f / (float)Math.PI);
    }
}
