using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_BGScroll : MonoBehaviour
{

    public float scroll_Speed = 0.3f;

    private MeshRenderer mesh_Renderer;

    private void Awake()
    {
        mesh_Renderer = GetComponent<MeshRenderer>();
    }

    private void LateUpdate()
    {
        Scroll();
    }

    private void Scroll()
    {
        Vector2 offset = mesh_Renderer.sharedMaterial.GetTextureOffset(NameManager.MAINTEXTURE_NAME);
        offset.y += Time.deltaTime * scroll_Speed;

        mesh_Renderer.sharedMaterial.SetTextureOffset(NameManager.MAINTEXTURE_NAME, offset);
    }

}
