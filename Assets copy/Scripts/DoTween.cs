using DG.Tweening;
using UnityEngine;

public class DoTween : MonoBehaviour
{
    
    private void Start()
    {
        transform.DOMove( new Vector3(10,0,0), 2).SetEase(Ease.InOutSine).SetLoops(-1,LoopType.Yoyo);
         transform.DORotate(new Vector3(0,360,0),2 * 0.5f,RotateMode.FastBeyond360).SetLoops(-1,LoopType.Restart).SetEase(Ease.Linear); 
    }   
}
