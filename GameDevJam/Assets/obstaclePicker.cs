using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclePicker : MonoBehaviour {
    public Sprite[] ObstacleSprites;
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.sprite = ObstacleSprites[(int) Random.Range(0f, ObstacleSprites.Length)];
    }
}
