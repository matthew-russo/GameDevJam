using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudSpritePicker : MonoBehaviour {
    public Sprite[] CloudSprites;
    private SpriteRenderer _spriteRenderer;
    private float _scale;

    private void Awake()
    {
        _scale = Random.Range(2f, 3f);
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.sprite = CloudSprites[(int)Random.Range(0f, CloudSprites.Length)];
        transform.localScale = new Vector2(_scale,_scale);
    }

    // Use this for initialization
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {

    }
}
