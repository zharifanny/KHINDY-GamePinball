using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    public Collider bola;
    public Material offMaterial;
    public Material onMaterial;

    private bool isOn;
    private Renderer renderer;

    private enum SwitchState
    {
        Off,
        On,
        Blink
    }

    private SwitchState state;


    private void Start()
    {
        renderer = GetComponent<Renderer>();

        Set(false);
         StartCoroutine(BlinkTimerStart(5));
    }

    private void Toggle()
    {
        // dari on --> off
        if (state == SwitchState.On)
        {
            Set(false);
        }
        // dari off --> on atau blink --> on
        else
        {
            Set(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            // Set(!isOn);
            // jalankan coroutine blink
            // StartCoroutine(Blink(2));
            Toggle();
        }
    }

    // private void Set(bool active)
    // {
    //     isOn = active;
    //     if (isOn == true)
    //     {
    //         renderer.material = onMaterial;
    //     }
    //     else
    //     {
    //         renderer.material = offMaterial;
    //     }
    // }

    private void Set(bool active)
    {
        if (active == true)
        {
            state = SwitchState.On;
            renderer.material = onMaterial;

            // hentikan proses blink
            StopAllCoroutines();
        }
        else
        {
            state = SwitchState.Off;
            renderer.material = offMaterial;
            StartCoroutine(BlinkTimerStart(5));
        }
    }

    private IEnumerator Blink(int times)
    {

        int blinkTimes = times * 2;
        state = SwitchState.Blink;



        for (int i = 0; i < times; i++)
        {
            renderer.material = onMaterial;
            yield return new WaitForSeconds(0.5f);
            renderer.material = offMaterial;
            yield return new WaitForSeconds(0.5f);
        }

        // set menjadi off kembali setelah proses blink
        state = SwitchState.Off;
        StartCoroutine(BlinkTimerStart(5));
    }

    private IEnumerator BlinkTimerStart(float time)
    {
        yield return new WaitForSeconds(time);
        StartCoroutine(Blink(2));
    }






}