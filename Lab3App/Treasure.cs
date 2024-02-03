using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    abstract class Treasure : Collectable
{
    public int Score { get; set; }

    public Treasure(string description, int score) : base(description)
    {
        Score = score;
    }

    public void UpdateTotalScore()
    {
            Board.TotalScore += Score;
            
    }

    public override void AddMe(List<Collectable> collection)
    {
        base.AddMe(collection);
        UpdateTotalScore();
            Console.WriteLine($"Total Score is updated to: {Board.TotalScore}");
        }
}
}
