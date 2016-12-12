using UnityEngine;
using System.Collections;

namespace PrototypingKit{

    /// <summary>
    /// Scales and repeats background textures regardless of screen size.
    /// REQUIRES PIXELPERFECTCAMERA SCRIPT TO WORK
    /// </summary>
    public class TiledBackground : MonoBehaviour{

        public int textureSize = 32;
        public bool scaleHorizontally = true;
        public bool scaleVertically = true;


        void Start(){
            var newWidth = !scaleHorizontally ? 1 : Mathf.Ceil(Screen.width / (textureSize * PixelPerfectCamera.scale));
            var newHeight = !scaleVertically ? 1 : Mathf.Ceil(Screen.height / (textureSize * PixelPerfectCamera.scale));

            transform.localScale = new Vector3(newWidth * textureSize, newHeight * textureSize, 1);

            GetComponent<Renderer>().material.mainTextureScale = new Vector3(newWidth, newHeight, 1);
        }
    }
}
