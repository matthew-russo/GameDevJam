﻿using UnityEngine;
using System.Collections;


namespace PrototypingKit{

    /// <summary>
    /// Makes textures scroll to simulate movement.
    /// REQUIRES TILEDBACKGROUND & PIXELPERFECTCAMERA
    /// </summary>
    public class AnimatedTexture : MonoBehaviour {

        public Vector2 speed = Vector2.zero;

        private Vector2 offset = Vector2.zero;
        private Material material;

        void Start() {
            material = GetComponent<Renderer>().material;

            offset = material.GetTextureOffset("_mainTex");
        }

        void Update() {
            offset += speed * Time.deltaTime;

            material.SetTextureOffset("_mainText", offset);
        }
    }
}
