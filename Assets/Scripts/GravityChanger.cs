using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GravityChanger : MonoBehaviour
{
    public Rigidbody2D rb;
    public Slider SliderValue;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = SliderValue.value * 1f;

    }


    public void GravUpdate()
    {
        rb.gravityScale = SliderValue.value * 1f;
    }
    void Update()
    {
        rb.gravityScale = SliderValue.value * 1f;
    }
}
