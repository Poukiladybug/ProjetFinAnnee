using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetFireToTheBread : MonoBehaviour
{

    

    // Update is called once per frame
    public void SetFire(Image image)
    {
        image.fillAmount += 0.02f;
    }
}
