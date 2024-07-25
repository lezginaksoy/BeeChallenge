// See https://aka.ms/new-console-template for more information
using BeeChallenge;


Console.WriteLine($"******** Hello BeeChallenge ! ******");
var beeList = new List<Bees>();

for (int i = 0; i < 10; i++)
{
    Random rnd = new Random();

    var bees = new Bees();
    var droneBee = new DroneBee();

    droneBee.Damage(rnd.Next(1, 80));
    droneBee.Damage(rnd.Next(1, 80));
    droneBee.Damage(rnd.Next(1, 80));
    droneBee.Damage(rnd.Next(1, 80));
    bees.DBee = droneBee;

    var workerBee = new WorkerBee();
    workerBee.Damage(rnd.Next(1, 80));
    workerBee.Damage(rnd.Next(1, 80));
    workerBee.Damage(rnd.Next(1, 80));
    workerBee.Damage(rnd.Next(1, 80));
    workerBee.Damage(rnd.Next(1, 80));
    workerBee.Damage(rnd.Next(1, 80));
    workerBee.Damage(rnd.Next(1, 80));
    bees.WBee = workerBee;

    var queenBee = new QueenBee();
    queenBee.Damage(rnd.Next(1, 80));
    queenBee.Damage(rnd.Next(1, 80));
    queenBee.Damage(rnd.Next(1, 80));
    queenBee.Damage(rnd.Next(1, 80));
    queenBee.Damage(rnd.Next(1, 80));
    queenBee.Damage(rnd.Next(1, 80));
    queenBee.Damage(rnd.Next(1, 80));
    queenBee.Damage(rnd.Next(1, 80));
    queenBee.Damage(rnd.Next(1, 80));
    queenBee.Damage(rnd.Next(1, 80));
    queenBee.Damage(rnd.Next(1, 80));
    queenBee.Damage(rnd.Next(1, 80));
    bees.QBee = queenBee;

    beeList.Add(bees);
}


foreach (var bees in beeList)
{
    Console.WriteLine($" DroneBee Damage level:{bees.DBee.Health}  IsDead:{bees.DBee.IsDead()}");
    Console.WriteLine($" workerBee Damage level:{bees.WBee.Health}  IsDead:{bees.WBee.IsDead()}");
    Console.WriteLine($" queenBee Damage level:{bees.QBee.Health}  IsDead:{bees.QBee.IsDead()}");
}




public class Bees
{
    public DroneBee DBee { get; set; }
    public QueenBee QBee { get; set; }
    public WorkerBee WBee { get; set; }
}