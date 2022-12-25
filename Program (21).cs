Sportsman sportsman = new Sportsman("Mike", 10, 12);
SportsmanChild sportsmanChild = new SportsmanChild("One more Mike", 10, 12, true);

Console.WriteLine($"{sportsman.name}: Q = {sportsman.Quality():F2}");
Console.WriteLine($"{sportsmanChild.name}: Q = {sportsmanChild.Quality():F2}");


class SportsmanChild : Sportsman
{
    public bool rankedFirst;

    public SportsmanChild(string name, int contestNumber, int placeSum, bool rankedFirst) : base(name, contestNumber,
        placeSum)
    {
        this.rankedFirst = rankedFirst;
    }

    public override double Quality()
    {
        return (rankedFirst ? 1.5 : 1) * base.Quality();
    }
}

class Sportsman
{
    public string name;
    public int contestNumber;
    public int placeSum;

    public Sportsman(string name, int contestNumber, int placeSum)
    {
        this.name = name;
        this.contestNumber = contestNumber;
        this.placeSum = placeSum;
    }

    public virtual double Quality()
    {
        return (double)contestNumber / placeSum;
    }
}