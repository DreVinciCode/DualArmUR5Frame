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
    public Transform Left_Shoulder_Pan;
    public Transform Left_Shoulder_Tilt;
    public Transform Left_Elbow;
    public Transform Left_Wrist_1;
    public Transform Left_Wrist_2;
    public Transform Left_Wrist_3;

    public Transform Right_Shoulder_Pan;
    public Transform Right_Shoulder_Tilt;
    public Transform Right_Elbow;
    public Transform Right_Wrist_1;
    public Transform Right_Wrist_2;
    public Transform Right_Wrist_3;

    private void Start()
    {
        Left_Shoulder_Pan.localEulerAngles = new Vector3(0, 0, RadianToDegree(2.005f));
        Left_Shoulder_Tilt.localEulerAngles = new Vector3(0, RadianToDegree(-2.10f), 0);
        Left_Elbow.localEulerAngles = new Vector3(0, RadianToDegree(-1.166f), 0);
        Left_Wrist_1.localEulerAngles = new Vector3(0,RadianToDegree(3.14f), 0);
        Left_Wrist_2.localEulerAngles = new Vector3(0, 0, RadianToDegree(-0.106f));
        Left_Wrist_3.localEulerAngles = new Vector3(0, RadianToDegree(-1.836f), 0);

        Right_Shoulder_Pan.localEulerAngles = new Vector3(0, 0, RadianToDegree(2.005f));
        Right_Shoulder_Tilt.localEulerAngles = new Vector3(0, RadianToDegree(-2.10f), 0);
        Right_Elbow.localEulerAngles = new Vector3(0, RadianToDegree(-1.166f), 0);
        Right_Wrist_1.localEulerAngles = new Vector3(0, RadianToDegree(3.14f), 0);
        Right_Wrist_2.localEulerAngles = new Vector3(0, 0, RadianToDegree(-0.106f));
        Right_Wrist_3.localEulerAngles = new Vector3(0, RadianToDegree(-1.836f), 0);
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
