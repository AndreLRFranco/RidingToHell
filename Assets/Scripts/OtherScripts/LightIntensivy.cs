using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LightIntensivy : MonoBehaviour
{
    public Light generalLight;
    public Slider intensitySlider;

    void Update()
    {

        generalLight.intensity = intensitySlider.value;
    }


}
