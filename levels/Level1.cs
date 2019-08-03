
public class Level1 : ILevel, BattleShip {

    int health;
    int lives;
    AmmoModel weapons;
    private readonly BattleShip _battleship;


    Level1(BattleShip b) {
        _battleship = b;
        this.health = _battleship.AircraftHealth;    
        this.lives = _battleship.AircraftLives;
        this.weapons = _battleship.AircraftWeapon;
    }


    public void StartLevel(int lvl) {

        // load level

        // load enemies

        // load player

        PlayerShip player = new PlayerShip(health, lives, weapons); 

    }

}
