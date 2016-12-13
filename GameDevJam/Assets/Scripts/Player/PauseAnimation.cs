using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseAnimation : MonoBehaviour
{

    private Animator _animator;

    // Use this for initialization
    private void Start ()
	{
	    _animator = GetComponent<Animator>();
	}

    // Update is called once per frame
    private void Update () {
        if (GlobalPause.Instance.isPaused)
        {
            _animator.speed = 0;
        }
        else
        {
            _animator.speed = 1;
        }
	}
}
