using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class JavascriptHook : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void HelloString(string str);
    [SerializeField] private SpriteRenderer circleSpriteRenderer;

    public void TintRed()
    {
        circleSpriteRenderer.color = Color.red;
        HelloString("The circle is Red");
    }

    public void TintGreen()
    {
        circleSpriteRenderer.color = Color.green;
        HelloString("The circle is Green");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            TintRed();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            TintGreen();
        }
    }
}
