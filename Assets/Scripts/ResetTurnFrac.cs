using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetTurnFrac : MonoBehaviour
{
    public GeneratePoints controller;

    public void reset () {
        float val = (1 + Mathf.Sqrt(5)) / 2f;
        this.GetComponent<Slider>().value = val;
        controller.RefreshTurnFrac(val);
    }
}
