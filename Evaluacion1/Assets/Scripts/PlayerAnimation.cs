using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private float moveX;
    [SerializeField] Animator AnimPlayer;
    SpriteRenderer RenderSprite;
    private void FixedUpdate()
    {
        if (moveX != 0)
        {
            AnimPlayer.SetBool("IsWalking", true);
        }
        else
        {
            AnimPlayer.SetBool("IsWalking", false);
        }

        if (moveX < 0)
        {
            RenderSprite.flipX = true;
        }
        else if (moveX > 0)
        {
            RenderSprite.flipX = false;
        }

    }
}
