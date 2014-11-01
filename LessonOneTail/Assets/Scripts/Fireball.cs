using System.Runtime.Serialization.Formatters;
using UnityEngine;

public class Fireball : MonoBehaviour
{

    public float speed;
    public Transform target;
    private Transform myTransform;

    void Awake()
    {
        myTransform = transform;
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.position);

        float distance = (target.position - myTransform.position).magnitude;
        if (distance >=10)
        {
            myTransform.position += myTransform.forward * speed * Time.deltaTime;
        }
       
        
    }
}
