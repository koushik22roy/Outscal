using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTank : MonoBehaviour
{
    [SerializeField] TankView tankView;
    // Start is called before the first frame update
    void Start()
    {
        CreateTank(); 
    }

    private void CreateTank()
    {
        TankModel tankModel = new TankModel(20,20);
        TankController tankController = new TankController(tankModel,tankView);
    }
}
