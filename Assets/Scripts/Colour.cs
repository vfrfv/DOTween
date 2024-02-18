using DG.Tweening;
using UnityEngine;

public class Colour : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();

        _spriteRenderer.DOColor(Color.red, 3).SetLoops(-1, LoopType.Yoyo);
    }
}
