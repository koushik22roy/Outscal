﻿using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;
    private float movement;
    private float rotation;

    [SerializeField] private Rigidbody rb;
    [SerializeField] private MeshRenderer[] mr;
    
    void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform);
        cam.transform.position = new Vector3(0f, 3f, -4f);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        if (movement != 0)
            tankController.Move(movement, tankController.GetTankModel().movementSpeed);

        if (rotation != 0)
            tankController.Rotate(rotation, tankController.GetTankModel().rotationSpeed);
    }

    private void Movement()
    {
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");
    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }

    public Rigidbody GetRigidbody()
    {
        return rb;
    }

    public void ChangeColor(Material color)
    {
        for(int i = 0; i < mr.Length; i++)
        {
            mr[i].material = color;  
        }
    }
}
