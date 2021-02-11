﻿// Code referenced: https://stackoverflow.com/questions/48753638/unity3d-trouble-with-ship-floating-on-water
//
//
//

using UnityEngine;

[AddComponentMenu("Rendering/SetRenderQueue")]
public class SetRenderQueue : MonoBehaviour
{

    [SerializeField]
    protected int[] m_queues = new int[] { 3000 };

    protected void Awake()
    {
        if (TryGetComponent(out Renderer renderer) == true)
        {
            Material[] materials = renderer.materials;
            for (int i = 0; i < materials.Length && i < m_queues.Length; ++i)
            {
                materials[i].renderQueue = m_queues[i];
            }
        }
    }
}