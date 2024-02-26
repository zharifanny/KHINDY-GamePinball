using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Color color;

    public Collider bola;
    public float multiplier;
    private Renderer renderer;
    private Animator animator;

public AudioManager audioManager;




    private void OnCollisionEnter(Collision collision)
    {
        // memastikan yang menabrak adalah bola
        if (collision.collider == bola)
        {
            // kita lakukan debug
            Debug.Log("Kena Bola");
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;

            // saat ditabrak oleh bola, kita tinggal aktifkan trigger Hit
            animator.SetTrigger("hit");
            audioManager.PlaySFX(collision.transform.position);
        }
    }

    private void Start()
    {
        // karena material ada pada component Rendered, maka kita ambil renderernya
        renderer = GetComponent<Renderer>();
        animator = GetComponent<Animator>();

        // kita akses materialnya dan kita ubah warna nya saat Start
        renderer.material.color = color;

    }

    // // Start is called before the first frame update
    // void Start()
    // {

    // }

    // Update is called once per frame
    void Update()
    {

    }
}
