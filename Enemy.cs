using System;
// not implemented
public class Enemy { // base class
	// instance variables
	private string Pattern; // Enemy behaviour
	private bool Dead; // are the enemies alive or dead?
	private int Range; // radius where enemies will chase the player
	
	
	public Enemy(string AttackPattern, int EngageRange, bool isDead){ // constructor
		Pattern = AttackPattern;
		Range = EngageRange;
		Dead = isDead;
	}


	// getter methods
	
	public string getPattern(){
		return Pattern;
	}
	public void setPattern(string p){
		Pattern = p;
	}
	public void setRange(string p){
		if (p == "passive"){
			Range = 1;
		}
		if (p == "neutral"){
			Range = 7;
		}
		else{
			Range = 22;
		}
	}
	public void GetHit(){ // if plyaer attacks enemies
		Dead = true;
		}
	// sets enemy stats to 0 if they are defeated
	public void EnemyDies(){
		if (Dead == true){
		Pattern = null;
		Range = 0;
			
		}
	}
}
