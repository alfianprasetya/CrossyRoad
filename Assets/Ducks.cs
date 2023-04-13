using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Ducks : MonoBehaviour
{
    [SerializeField, Range(0, 1)] float moveDuration;
    void Update()
    {
        if(DOTween.IsTweening(transform))
            return;

        Vector3 direction = Vector3.zero;

        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.DOMoveZ(transform.position.z + 1, 0.5f);
        }
        if(Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.DOMoveZ(transform.position.z - 1, 0.5f);
        }
        if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.DOMoveX(transform.position.x + 1, 0.5f);
        }
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.DOMoveX(transform.position.x - 1, 0.5f);
        }

        if(direction == Vector3.zero)
            return;

        Move(direction);
    }

    public void Move(Vector3 direction)
    {
        transform.DOMove(transform.position + direction, 0.1f);
    }
}
