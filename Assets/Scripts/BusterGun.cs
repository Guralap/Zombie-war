using UnityEngine;
using System.Collections;

public class BusterGun : MonoBehaviour
{
    Animator mAnimator;
    bool mShooting;

    float kShootDuration = 0.25f;
    float mTime;

    public GameObject mBulletPrefab;
    MegaMan mMegaManRef;

  

    void Start()
    {
        mAnimator = transform.parent.GetComponent<Animator>();
       
        mMegaManRef = transform.parent.GetComponent<MegaMan>();

       
       

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire"))
        {
           
            GameObject bulletObject = Instantiate(mBulletPrefab, transform.position, Quaternion.identity);       //Call instantiate
            Bullet bullet =bulletObject.GetComponent<Bullet>();

            bullet.SetDirection(mMegaManRef.GetFacingDirection());

            //       and using MegamanRef GetFacingDirection() function

           
           
            // Set animation params
            mShooting = true;
            mTime = 0.0f;
        }

        if (mShooting)
        {
            mTime += Time.deltaTime;
            if (mTime > kShootDuration)
            {
                mShooting = false;
            }
        }

        UpdateAnimator();
    }

    private void UpdateAnimator()
    {
        mAnimator.SetBool("isShooting", mShooting);
    }
}
