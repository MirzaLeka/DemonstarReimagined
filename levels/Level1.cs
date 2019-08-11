
using System;

public class Level1 : ILevel {

    public void StartLevel(int lvl) {

        // load level

        // load enemies

        // load player

        WeaponModel playerWeapon = new WeaponModel(Weapons.ProtonCannon, 50, 100, 300, "yellow");
        
        PlayerShip player = new PlayerShip(100, 3, playerWeapon); 

        // just to check if things work
        string details = player.PlayerDetails();
        Console.WriteLine(details);

    }

}
