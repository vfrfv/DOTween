using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ChangingText : MonoBehaviour
{
    [SerializeField] private Text _text;

    void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("яёниор", 3));
        sequence.Append(_text.DOText(" vfrfv", 3).SetRelative());
        sequence.Append(_text.DOText("GameDev", 3, true, ScrambleMode.All));
    }
}
