using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fpscontador : MonoBehaviour
{

    public int avgFrameRate;
    public Text display_Text;

    public void Update()
    {
        
        avgFrameRate = (int)(1f / Time.unscaledDeltaTime);
        display_Text.text = avgFrameRate.ToString() + " FPS";
    }
}
