using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickSprite : MonoBehaviour
{
    public Sprite[] BuildingSprites;
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.sprite = BuildingSprites[(int)Random.Range(0f,BuildingSprites.Length)];
    }

	// Use this for initialization
	private void Start () {
		
	}
	
	// Update is called once per frame
	private void Update () {
		
	}
}
