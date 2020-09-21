using System;

namespace Chessboard
{
  class Queen
  {

    public int xCoordinate { get; set; }
    public int yCoordinate { get; set; }

    public bool canAttack(int x, int y)
    {
      if (yCoordinate == y) //hor
      {
        return true;
      }
      //ver
      else if (xCoordinate == x)
      {
        return true;
      }
      else if (((xCoordinate - x) / (yCoordinate - y) == 1) || ((xCoordinate - x) / (yCoordinate - y) == -1)) //diag
      {
        return true;
      }
      else   //cant
      {
        return false;
      }
    }
    static void Main()
    {
      string userResponse;
      do
      {


        Console.WriteLine("Enter coordinates for queen, and cooridates of location to check for attack.");
        userResponse = Console.ReadLine();//  1,1 2,2
        string[] positions = userResponse.Split(" ");
        if (positions.Length > 1)
        {
          string[] queenCoordinates = positions[0].Split(",");
          string[] attackCoordinates = positions[1].Split(",");
          Queen q = new Queen();
          q.xCoordinate = int.Parse(queenCoordinates[0]);
          q.yCoordinate = int.Parse(queenCoordinates[1]);
          if (q.canAttack(int.Parse(attackCoordinates[0]), int.Parse(attackCoordinates[1])))
          {
            Console.WriteLine("Queen can attack");
          }
          else
          {
            Console.WriteLine("Queen can not attack");
          }

        }
      } while (userResponse != "x");





    }





  }
}