using System;
using UnityEngine;

namespace RosSharp.RosBridgeClient
{
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
            //Left_Shoulder_Pan.localEulerAngles = new Vector3(0, 0, RadianToDegree(-2.104f));
            Left_Shoulder_Pan.localEulerAngles = UpdateArmOrientation(-1 * Vector3.forward, -2.104f);
            Left_Shoulder_Tilt.localEulerAngles = UpdateArmOrientation( Vector3.up, -0.861f);
            Left_Elbow.localEulerAngles = UpdateArmOrientation(-1* Vector3.up, 1.316f);
            Left_Wrist_1.localEulerAngles = UpdateArmOrientation(-1* Vector3.up, -0.227f);
            Left_Wrist_2.localEulerAngles = UpdateArmOrientation(-1 * Vector3.forward, 0);
            Left_Wrist_3.localEulerAngles = UpdateArmOrientation(Vector3.up, -1.287f);

            /*
            Left_Shoulder_Tilt.localEulerAngles = new Vector3(0, RadianToDegree(-0.861f), 0);
            Left_Elbow.localEulerAngles = new Vector3(0, RadianToDegree(1.316f), 0);
            Left_Wrist_1.localEulerAngles = new Vector3(0,RadianToDegree(-0.227f), 0);
            Left_Wrist_2.localEulerAngles = new Vector3(0, 0, RadianToDegree(0f));
            Left_Wrist_3.localEulerAngles = new Vector3(0, RadianToDegree(-1.287f), 0);
            */


            Right_Shoulder_Pan.localEulerAngles = UpdateArmOrientation(-1 * Vector3.forward, 2.005f);
            Right_Shoulder_Tilt.InverseTransformDirection(UpdateArmOrientation(-1 * Vector3.up,(-1)* -2.104f));
            //Right_Shoulder_Tilt.localEulerAngles = UpdateArmOrientation( Vector3.up, (-1) *-2.104f);
            /*
            Right_Shoulder_Tilt.localEulerAngles = new Vector3(0, RadianToDegree(-2.10f), 0);
            Right_Elbow.localEulerAngles = new Vector3(0, RadianToDegree(-1.166f), 0);
            Right_Wrist_1.localEulerAngles = new Vector3(0, RadianToDegree(3.14f), 0);
            Right_Wrist_2.localEulerAngles = new Vector3(0, 0, RadianToDegree(-0.106f));
            Right_Wrist_3.localEulerAngles = new Vector3(0, RadianToDegree(-1.836f), 0);
            */
        }

        private void Update()
        {

        }

        private float RadianToDegree(float position)
        {
            var radian = -1 * position;
            if (radian < 0)
                return (radian + 2 * (float)Math.PI) * (180.0f / (float)Math.PI);
            else
                return radian * (180.0f / (float)Math.PI);
        }

        private Vector3 UpdateArmOrientation(Vector3 axis, float position)
        {
            if (position < 0)
                return axis * (position + 2 * (float)Math.PI) * (180.0f / (float)Math.PI);
            else
                return axis * position * (180.0f / (float)Math.PI);

        }
    }
}
