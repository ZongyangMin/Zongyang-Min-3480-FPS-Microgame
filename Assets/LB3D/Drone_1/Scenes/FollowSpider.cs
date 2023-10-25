using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowSpider : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public Animator spider;
    private float speed = 1.5f;

    public bool walking = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        transform.forward = player.transform.position - transform.position;
        spider.SetBool("Walking", walking);
    }
}
