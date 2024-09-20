using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    [SerializeField] KeyCode input;

    private HingeJoint _hinge;
    private float targetPressed;
    private float targetReleased;

    void Start()
    {
        _hinge = GetComponent<HingeJoint>();

        targetPressed = _hinge.limits.max;
        targetReleased = _hinge.limits.min;
    }

    // Update is called once per frame
    void Update()
    {
        ReadInput();
    }

    private void ReadInput()
    {
        JointSpring jointSpring = _hinge.spring;

        if (Input.GetKey(input))
        {
            jointSpring.targetPosition = targetPressed;
        } else
        {
            jointSpring.targetPosition = targetReleased;
        }

        _hinge.spring = jointSpring;
    }
}
