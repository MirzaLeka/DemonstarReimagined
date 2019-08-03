
public class AmmoModel{

    int DealingDamage;
    int FireRate;
    int[] FlightAngle;
    int OverallAmmo;
    string Color;

    public AmmoModel(int damage, int fireRate, /*int[] angles, */ int ammo, string color) {
        this.DealingDamage = damage;
        this.FireRate = fireRate;
        // this.FlightAngle = angles;
        this.OverallAmmo = ammo;
        this.Color = color;
    }

}