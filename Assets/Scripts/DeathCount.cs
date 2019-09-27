using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathCount : MonoBehaviour
{
    public Text DeathCountValue;
    public static float DeathCountNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        DeathCountValue.text = DeathCountNum.ToString();
    }
}
