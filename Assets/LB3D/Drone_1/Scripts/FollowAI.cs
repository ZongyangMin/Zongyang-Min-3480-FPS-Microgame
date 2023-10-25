using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FollowAI : MonoBehaviour
{
    public GameObject player;
    public Animator character;
    public bool isWalking = false;
    private float speed = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        transform.forward = player.transform.position - transform.position;
        isWalking = !isWalking;
        character.SetBool("isWalking", isWalking);
    }
}
