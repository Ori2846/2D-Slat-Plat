using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 40;
    // Start is called before the first frame update
    void Start()
    {
      rb.velocity = transform.right * speed;
      StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.tag == "Bullet")
        {

        } else if (hitInfo.tag == "Wall")
        {
            Debug.Log(hitInfo.name);
            Destroy(gameObject);
        }
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
