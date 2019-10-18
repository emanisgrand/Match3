using System.Collections;
using UnityEngine;

public class AnimatedPiece : MonoBehaviour {
    private GamePiece piece;
    private IEnumerator animateCoroutine;
    private Animator animator;

    public AnimationClip animClip;
    
    private void Awake() {
        animator = GetComponent<Animator>();
        piece = GetComponent<GamePiece>();
        PlayAnim();
    }

    public void PlayAnim() {
        if (piece.IsAnimated()) {
            animator.Play(animClip.name);
        }
    }
}