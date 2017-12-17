using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Jamminger : MonoBehaviour
{
    public Text Scoretext;
    static int score = 0;

    [SerializeField]
    GameObject mExplosionPrefab;
    public bool hitBullet;



    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.layer == LayerMask.NameToLayer("BusterBullet")) 
        {
            Instantiate(mExplosionPrefab, transform.position, Quaternion.identity);
            Destroy(col.gameObject);
            Destroy(gameObject);
            UpdateScore();
        }

      
    }
    public void UpdateScore()
    {
        score++;
        Scoretext.text = "Score:" + score;
    }



    void OnCollisionStay2D(Collision2D col)
    {
       
        if (col.gameObject.layer == LayerMask.NameToLayer("Player")) 
        {
            col.gameObject.GetComponent<MegaMan>().TakeDamage(20);
        }
    }
}
