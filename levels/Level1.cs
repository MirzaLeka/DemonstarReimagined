
public class Level1 : ILevel {

    int health;
    int lives;
   
    WeaponModel playerWeapon = new WeaponModel("ak", 50, 100, 300, "yellow");

    public void StartLevel(int lvl) {

        // load level

        // load enemies

        // load player

        PlayerShip player = new PlayerShip(100, 3, playerWeapon); 

    }

}
