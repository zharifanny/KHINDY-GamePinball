using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public KeyCode input;
    public float springPower;

    private HingeJoint hinge;
    private float targetPressed;
    private float targetRelease;

    private void Start()
    {
        hinge = GetComponent<HingeJoint>();
        targetPressed = hinge.limits.max;
        targetRelease = hinge.limits.min;
    }

    private void Update()
    {
        ReadInput();
    }

    private void ReadInput()
    {
        JointSpring jointSpring = hinge.spring;

        if (Input.GetKey(input))
        {
            jointSpring.targetPosition = targetPressed;
            jointSpring.spring = springPower;
        }
        else
        {
            jointSpring.targetPosition = targetRelease;
            jointSpring.spring = 0;
        }

        hinge.spring = jointSpring;
    }
}