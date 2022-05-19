using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RosSharp.RosBridgeClient
{
    public class JointTrajectoryControllerStatePublisher : MonoBehaviour
    {
        private bool isMessageReceived;
        private int _jointLength;
        private double[] _positions;
        private string[] _jointNames;

        public Transform[] JointGroup;

        private void Update()
        {
            if (isMessageReceived)
                ProcessMessage();
        }

        public void Write(MessageTypes.Control.JointTrajectoryControllerState message)
        {
            _jointNames = message.joint_names;
            _positions =  message.desired.positions;
            _jointLength = _positions.Length;

            isMessageReceived = true;
        }

        private void ProcessMessage()
        {
            //positions are in radians; convert to degrees
            for (int i = 0; i < _jointLength; i++)
            {
                var radian = _positions[i];


                //Debug.Log(_jointNames[i] + " " + _positions[i]);
            }

            isMessageReceived = false;
        }
    }
}
