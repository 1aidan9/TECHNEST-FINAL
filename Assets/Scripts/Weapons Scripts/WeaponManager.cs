using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour {

    [SerializeField]
    private WeaponHandler[] weapons;

    private int current_Weapon_Index;

	
	void Start () {
        current_Weapon_Index = 0;
        weapons[current_Weapon_Index].gameObject.SetActive(true);
	}
	
	
	void Update () {
        ChangeCurrentWeapon();


    } 

    void ChangeCurrentWeapon()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            weapons[current_Weapon_Index].gameObject.SetActive(false);
            current_Weapon_Index++;
            if (current_Weapon_Index == weapons.Length) { current_Weapon_Index = 0; }
            weapons[current_Weapon_Index].gameObject.SetActive(true);

        }
       
    }

    public WeaponHandler GetCurrentSelectedWeapon() {
        return weapons[current_Weapon_Index];
    }

} 

































