using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetTurnFrac : MonoBehaviour
{
    public void reset () {
        this.GetComponent<Slider>().value = (1 + Mathf.Sqrt(5)) / 2f;
    }
}
