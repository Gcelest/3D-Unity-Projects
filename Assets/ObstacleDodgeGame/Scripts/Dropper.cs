using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 2f;

    MeshRenderer meshRenderer;
    Rigidbody rb;


    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

        meshRenderer.enabled = false;
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            meshRenderer.enabled = true;
            rb.useGravity = true;
        }
    
    }
}
