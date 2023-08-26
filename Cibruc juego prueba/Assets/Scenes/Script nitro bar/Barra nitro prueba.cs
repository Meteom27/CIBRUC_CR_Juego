using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarradeNitro : MonoBehaviour
{
    public Image barradeNitro;

    public float nitroactual;

    public float nitromaxima;


    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        barradeNitro.fillAmount = nitroactual / nitromaxima;
    }
}
