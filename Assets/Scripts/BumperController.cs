using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BumperController : MonoBehaviour
{
    public Collider bola;
    public float multiplier;
    public Color color;
    //public AudioManager audioManager;
    //public VFXManager vfxManager;
    //public ScoreManager scoreManager;
    public float score;

    private Renderer _renderer;
    private Animator _animator;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
        _animator = GetComponent<Animator>();

        _renderer.material.color = color;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.tag == "Player")
        //{
        //    Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
        //    bolaRig.velocity *= multiplier;
        //}

        if (collision.collider == bola)
        {
            Debug.Log("Test");
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;

            //audioManager.PlaySFX(collision.transform.position);
            //vfxManager.PlayVFX(collision.transform.position);
            //scoreManager.AddScore(score);

            _animator.SetTrigger("hit");
        }
    }
}
