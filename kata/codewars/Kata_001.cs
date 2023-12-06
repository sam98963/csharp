public class Kata_001
{
  public static string WhoseMove(string lastPlayer, bool win)
  {
    string winner = "";
    if(lastPlayer == "white" && win){
      winner = "white";
    } else if(lastPlayer == "white" && !win){
      winner = "black";
    } else if(lastPlayer == "black" && !win){
      winner = "white";
    } else if(lastPlayer == "black" && win){
      winner = "black";
    }
  return winner;
  }
}