using UnityEngine;
using System.Collections;

public class FollowTarget : MonoBehaviour
{
    [SerializeField]
    Transform mTarget;
    [SerializeField]
    float mFollowSpeed;
    [SerializeField]
    float mFollowRange;

    float mArriveThreshold = 0.05f;

    void Update()
    {
        if (mTarget != null)
        {
            Vector2 direction = new Vector3(mTarget.transform.position.x, transform.position.y) - transform.position;
            if (direction.magnitude <= mFollowRange)
            {
                if (direction.magnitude > mArriveThreshold)
                {
                    transform.Translate(direction.normalized * mFollowSpeed * Time.deltaTime, Space.World);
                }
                
            }
        }
    }

    public void SetTarget(Transform target)
    {
        mTarget = target;
    }
}