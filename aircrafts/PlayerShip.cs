
class PlayerShip : BattleShip {

    public int AircraftHealth {get; set;}
    public int AircraftLives {get; set;}
    public WeaponModel AircraftWeapon {get; set;}

    public PlayerShip(int health, int lives, WeaponModel weapon) {
       this.AircraftHealth = health;
       this.AircraftLives = lives;
       this.AircraftWeapon = weapon;
    }

    public string PlayerDetails() {
        return $"{this.AircraftHealth}, {this.AircraftLives}, {this.AircraftWeapon.WeaponName}";
    } 

}

    