using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetNumPoints : MonoBehaviour
{
    public void reset () {
        this.GetComponent<Slider>().value =  300;
    }
}
