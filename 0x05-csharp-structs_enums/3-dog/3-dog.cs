using System;

public enum Rating { Good, Great, Excellent };

public struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;
    public Dog(string stName, float ftAge, string stOwner, Rating rtRaiting)
    {
        name = stName;
        age = ftAge;
        owner = stOwner;
        rating = rtRaiting;
    }
    public override string ToString()
    {
        return ($"Dog Name: {name}\nAge: {age}\nOwner: {owner}\nRating: {rating}");
    }
}
