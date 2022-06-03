using UnityEngine;

public class TankSelection : MonoBehaviour
{

    public SpawnTank spwanTank;
    /*public void Selection(int c)
    {
        switch (c)
        {
            case 1: 
                spwanTank.CreateTank(TankTypes.BlueTank);
                this.gameObject.SetActive(false);
                break;
            case 2:
                spwanTank.CreateTank(TankTypes.GreenTank);
                this.gameObject.SetActive(false);
                break;
            case 3:
                spwanTank.CreateTank(TankTypes.RedTank);
                this.gameObject.SetActive(false);
                break;
        }
    }*/

    public void Bluetank()
    {
        Debug.Log("Blue");
        spwanTank.CreateTank(TankTypes.BlueTank);
        this.gameObject.SetActive(false);
    }

    public void GreenTank()
    {
        spwanTank.CreateTank(TankTypes.GreenTank);
        this.gameObject.SetActive(false);
    }

    public void RedTank()
    {
        spwanTank.CreateTank(TankTypes.RedTank);
        this.gameObject.SetActive(false);
    }
}
