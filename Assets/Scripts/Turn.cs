using DG.Tweening;
using UnityEngine;

public class Turn : MonoBehaviour
{
    private void Start()
    {
        transform.DORotate(new Vector3(0, -100, 0), 3).SetLoops(-1, LoopType.Yoyo);
    }
}
