using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BlinkingTextMp : MonoBehaviour
{
    private float time = 1f;
    private float timer;
    private TMP_Text textFlicker;

    // Start is called before the first frame update
    void Start()
    {
        textFlicker = GetComponent<TMP_Text>();
        timer = time;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            textFlicker.enabled = !textFlicker.enabled;
            timer = time;
        }
    }
}
