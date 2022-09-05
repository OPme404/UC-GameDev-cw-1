using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heroandvillain : MonoBehaviour
{
    //Hero
    string heroName = "superman";
    float heroHeight = 1.91f;
    int heroAge = 25;
    string heroSuperPower = "flight, superhuman strength, x-ray vision";
    //vililan
    string vililanName = "lex luthor";
    float vililanHeight = 1.88f;
    int vililanAge = 21;
    string vililanSuperPower = "above-average intelligence";

    // Start is called before the first frame update
    void Start()
    {
        int ageDifference = heroAge - vililanAge;
        print("heroName: " + heroName + ", heroHeight: " + heroHeight + "m, heroAge: " + heroAge + ", heroSuperPower: " + heroSuperPower +
          ", vililanName: " + vililanName + ", vililanHeight: " + vililanHeight + "m, vililanAge: " + vililanAge +
          ", vililanSuperPower: " + vililanSuperPower + ",age difference: " + ageDifference);

        //exter
        heroAge = heroAge + 5;
        vililanSuperPower = "None";

        print("heroName: " + heroName + ", heroHeight: " + heroHeight + "m, heroAge: " + heroAge + ", heroSuperPower: " + heroSuperPower +
         ", vililanName: " + vililanName + ", vililanHeight: " + vililanHeight + "m, vililanAge: " + vililanAge +
         ", vililanSuperPower: " + vililanSuperPower + ",age difference: " + ageDifference);




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
