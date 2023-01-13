using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System;
// not implemented in game
class StatSaver{ // saves stats in a text file for a future login into the game
	public static void ReadLine(){
	 int variable = 1;
    //Pass file path and name to reader
    StreamReader sr = new StreamReader("playerSave.txt");
    // Read the first line of text
    String line = sr.ReadLine();
			  // loop for each variable within the player object as long as the next line isn't blank
		Player Player1 = new Player(); // new player object
    while (line != null)
    {
        switch(variable){ // determines the variable in player class to read
            case 1:
                Player1.setPL(int.Parse(sr.ReadLine())); // reads variable
                break;
            case 2:
                Player1.setExp(int.Parse(sr.ReadLine()));
                break;
            case 3: 
                Player1.setMaxHP(int.Parse(sr.ReadLine()));
                break;
            case 4: 
                Player1.setHP(int.Parse(sr.ReadLine()));
                break;
            case 5: 
                Player1.setAtk(int.Parse(sr.ReadLine()));
                break;
            case 6: 
                Player1.setDef(int.Parse(sr.ReadLine()));
                break;
            default:
                break;
        }
        variable++; // advances the while loop by changing the player variable that is read
			
			line = sr.ReadLine(); // read the next line
    }
    sr.Close();
	}
	
	public static async Task WriteText(){ // write text method
		String variable;
		Player Player1 = new Player();
  	string[] numbers = new string[6];
		for (int i = 1; i < numbers.Length;i++){
			switch (i){ // determines the variable in player class to write
				case 1:
					variable = Player1.getPL().ToString(); // converts int to string
					numbers[i] = variable;
					break;
				case 2:
					variable = Player1.getExp().ToString();
					numbers[i] = variable;
					break;
				case 3:
					variable = Player1.getMaxHP().ToString();
					numbers[i] = variable;
					break;
				case 4:
					variable = Player1.getHP().ToString();
					numbers[i] = variable;
					break;
				case 5:
					variable = Player1.getAtk().ToString();
					numbers[i] = variable;
					break;
			case 6:
					variable = Player1.getDef().ToString();
					numbers[i] = variable;
					break;
			}
		}

		await File.WriteAllLinesAsync("playerSave.txt", numbers); // waits for previous method to complete
		 
		
		
			}
}
