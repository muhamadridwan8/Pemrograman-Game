using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public PlayerController PlayerController; 
    public Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PlayerController.animator.SetBool("Shoot", true);
            RaycastHit hit;
            if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit))
            {
                print("Benda Yang Tertembak : " + hit.collider.gameObject.name);
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            PlayerController.animator.SetBool("Shoot", false);
        }
    }
}
