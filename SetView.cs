using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public List<Material> materials;  // List of materials to switch between

    // Call this to change the material
    public void SetView(int i)
    {
        if (materials == null || materials.Count == 0) return;
        if (i < 0 || i >= materials.Count) return;

        Renderer rend = GetComponent<Renderer>();
        rend.material = materials[i];  // Switch the material
    }
}
