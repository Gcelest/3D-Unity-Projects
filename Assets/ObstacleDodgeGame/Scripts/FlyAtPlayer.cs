using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    
    [SerializeField] float speed = 1f;
    [SerializeField] Transform player;
    Vector3 playerPosition;


    void Awake()
    {
        gameObject.SetActive(false);
    }
    void Start()
    {
        playerPosition = player.transform.position; 
    }

    void MoveToPlayer()
    {
       transform.position = 
       Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * speed);
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    void DestroyWhenReached()
    {
        if(transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
