using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerCollision player = collision.GetComponent<PlayerCollision>();

        if (player != null)
        {
            GameState.Instance.StopGame();
            player.DestroySelf();
        }
    }

    public void DestroySelf()
    {
        _animator.SetTrigger("Disappear");
        Destroy(transform.parent.gameObject, 1f/6f);
    }
}
