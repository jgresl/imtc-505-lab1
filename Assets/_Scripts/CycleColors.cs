using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEditor;
using UnityEngine;

public class CycleColors : MonoBehaviour
{
    public Material mt;
    public Color32[] colors;

    // Start is called before the first frame update
    void Start()
    {
        mt = transform.GetComponent<MeshRenderer>().material;
        colors = new Color32[5]
        {
            new Color32(255, 255, 0, 255),  // yellow
            new Color32(255, 165, 0, 255),  // orange
            new Color32(255, 0, 0, 255),    // red
            new Color32(255, 165, 0, 255),  // orange
            new Color32(255, 255, 0, 255),  // yellow

        };
        StartCoroutine(Cycle());
    }

    public IEnumerator Cycle()
    {
        int i = 0;
        while (true)
        {
            for (float interpolant = 0f; interpolant < 1f; interpolant += 0.001f)
            {
                mt.color = Color.Lerp(colors[i % 5], colors[(i + 1) % 5], interpolant);
                yield return null;
            }
            i++;
        }
    }
}