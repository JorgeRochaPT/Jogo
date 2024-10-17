using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class Animationlist : MonoBehaviour
{
    Rigidbody rb;
    //public bool Invert=false;
    public float DOmoveDistance = 1;
    //[SerializeField] static float RamdomDODuration = 3;
    //public float  DODuration= Random.Range( 1 , RamdomDODuration);

    public float DODuration = 2;
    public float DOScaleX = 1;
    public float DOScaleZ = 1;
    public float DOstr = 1;
    public bool rbmoveY = false;
    public bool rbmoveX = false;
    public bool rbScaleX = false;
    public bool rbScaleZ = false;
    public bool rbShakePosition = false;
    public bool RamdomDuration = true;
    float RandomDODuration = 1;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();
        if (RamdomDuration)
        {
            RandomDODuration = Random.Range(1, DODuration);
        }
        else
        {
            RandomDODuration = DODuration;
        }

        if (rbmoveY)
        {
            AnimateDOMoveY();
        }
        if (rbmoveX)
        {
            AnimateDOMoveX();
        }
        if (rbScaleX)
        {
            AnimateDoScaleX();
        }
        if (rbScaleZ)
        {
            AnimateDoScaleZ();
        } if (rbShakePosition)
        {
            AnimateDoShakePosition();
        }
    }
    void AnimateDOMoveY()
    {
        transform.DOMoveY(transform.position.y + DOmoveDistance, RandomDODuration)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.InOutSine);
    }
    void AnimateDOMoveX()
    {
        transform.DOMoveX(transform.position.x +DOmoveDistance, RandomDODuration)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.InOutSine);
    }
    void AnimateDoScaleX()
    {
        transform.DOScaleX(transform.localScale.x  +DOScaleX, RandomDODuration)
                .SetLoops(-1, LoopType.Yoyo)
                .SetEase(Ease.InOutSine);
    }
    void AnimateDoScaleZ()
    {
        transform.DOScaleZ(transform.localScale.z  +DOScaleZ, RandomDODuration)
                .SetLoops(-1, LoopType.Yoyo)
                .SetEase(Ease.InOutSine);
    }
    void AnimateDoShakePosition()
    {
        transform.DOShakePosition(RandomDODuration, DOstr)
                .SetLoops(-1, LoopType.Yoyo)
                .SetEase(Ease.InOutSine);
    }


    // Update is called once per frame
    void Update()
    {
    }
}
