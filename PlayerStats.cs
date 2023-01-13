using System;
class PlayerStats{ // not implemented in the game
// Variable declaration
  private int MaxHP;
    private int Atk;
    private int HP;
    private int Def;
    private int PL;
   	private int Exp;
    
    

    public Player(int MaxHitpoints, int Attack, int Hitpoints, int Defense, int Experience, int playerLevel){ // constructor
        MaxHP = MaxHitpoints; // how many hits the player can take at full
        Atk = Attack; // damage dealt to enemies
        HP = Hitpoints; // current amount of hits that can be taken
        Def = Defense; // Amount of damage reduced from enemy attacks
        Exp = Experience; // points gained from defeating enemies
				PL = playerLevel; // increases as player gets more exp
    }
	public Player(){ // constructor without variables
        MaxHP = 50;
        Atk = 5;
        HP = 50; 
        Def = 0;
        Exp = 0;
				PL = 1;
    }
 // getter methods
	public int getMaxHP(){
		return MaxHP;
	}
	public int getHP(){
		return HP;
	}
	public int getDef(){
		return Def;
	}
	public int getAtk(){
		return Atk;
	}
	public int getPL(){
		return PL;
	}
	public int getExp(){
		return Exp;
	}
	// setter methods
	public void setMaxHP(int m){
		MaxHP = m;
	}
	public void setHP(int h){
		HP = h;
	}
	public void setDef(int d){
		Def = d;
	}
	public void setAtk(int a){
		Atk = a;
	}
	public void setPL(int p){
		PL = p;
	}
	public void setExp(int e){
		Exp = e;
	}
          
	// instance methods
    public void HPToFull(){
       Console.WriteLine("HP is maxed.");
        HP = MaxHP;
    }
    public void changeMaxHP(int e){
       Console.WriteLine("Max HP Increased");
        MaxHP = 50 + e;
    }
    public void lostHP(int d){
       Console.WriteLine("HP has been lost");
        HP -= d;
    }

    public void gainHP(int h){
        HP += h;
        if (HP > MaxHP){
            HP = MaxHP;
        }
    }
	// increase of attack based on upgrades and base stats
    public void TotalAtkIncrease(int g){
        Atk = 5 + PL + g;
    }
		// increase of defense based on upgrades 
    public void DefIncrease(int f){
        Def = f; 
    }
    // sound effects
    public void TakeDamageSound(){ 
        // sound effect needed
       Console.WriteLine("Player took Damage sound");
    }
    public void GainHPSound(){
        // sound effect needed
       Console.WriteLine("Player got healed sound");
    }
	// Level up when player gains an amount of Exp
    public void levelUp(){
        if (Exp == 20*PL){
        PL++;
        }
        Exp = 0;
    }
}
