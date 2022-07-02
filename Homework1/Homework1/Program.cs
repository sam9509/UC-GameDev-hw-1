int health = 200;
string Name = "Hero";

int damaged = health - 20;
health = damaged;
Console.WriteLine("Damaged Health = " + health);
int boost = health + 10;
Console.WriteLine("Boosted Health = " + boost);
if (boost>damaged)

{
    Console.WriteLine(boost + " is greater than " + damaged);

}

else

{
    Console.WriteLine(damaged + " is greater than " + boost);

}