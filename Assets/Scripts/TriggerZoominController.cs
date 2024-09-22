using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class TriggerZoominController : MonoBehaviour
{
    public Collider bola;
    public CameraController cameraController;
    public ScoreManager scoreManager;
    public float length;
    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            cameraController.FollowTarget(bola.transform, length);
            scoreManager.score = 0;

        }
    }
}
