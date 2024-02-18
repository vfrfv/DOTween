using DG.Tweening;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private void Start()
    {
        transform.DOLocalMoveZ(-12, 8).SetLoops(-1, LoopType.Yoyo);
    }
}
