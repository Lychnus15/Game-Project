using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCon : MonoBehaviour
{
    private enum SwitchState
    {
        Off,
        On,
        Blink
    }

    public Collider bola;
    public ScoreManager scoreManager;
    public Material offMaterial;
    public Material onMaterial;
    public AudioManager audioManager;
    public VFXManager VFXManager;
    private SwitchState state;
    private Renderer renderer;
    public float score;

    private void Start()
    {
        renderer = GetComponent<Renderer>();

        Set(false);
        StartCoroutine(BlinkTimerStart(5));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            Toggle();

            audioManager.PlaySFX2(other.transform.position);
            
            VFXManager.PlayVFX2(other.transform.position);
            
        }
    }

    private void Set(bool active)
    {
        if (active == true)
        {
            state = SwitchState.On;
            renderer.material = onMaterial;
            StopAllCoroutines();
        }
        else
        {
            state = SwitchState.Off;
            renderer.material = offMaterial;
            StartCoroutine(BlinkTimerStart(5));
        }
    }

    private void Toggle()
    {
        scoreManager.AddScore(score);
        if (state == SwitchState.On)
        {
            Set(false);
        }
        else
        {
            Set(true);
        }
    }

    private IEnumerator Blink(int times)
    {
        state = SwitchState.Blink;

        for (int i = 0; i < times; i++)
        {
            renderer.material = onMaterial;
            yield return new WaitForSeconds(0.5f);
            renderer.material = offMaterial;
            yield return new WaitForSeconds(0.5f);
        }

        state = SwitchState.Off;
        StartCoroutine(Blink(5));
    }

    private IEnumerator BlinkTimerStart(float times)
    {
        yield return new WaitForSeconds(times);
        StartCoroutine(Blink(2));
    }
}
