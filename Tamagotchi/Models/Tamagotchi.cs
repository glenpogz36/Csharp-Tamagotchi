using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class MyTamagotchi
  {
    private string _name;
    private int _food;
    private int _sleep;
    private int _attention;
    private int _health;
    private bool _alive;
   
    private int _id;
    private static List<MyTamagotchi> _instances = new List<MyTamagotchi> {};

    public MyTamagotchi (string name)
    {
      _name = name;
      _instances.Add(this);
      _id = _instances.Count; 
      _food = 10;
      _sleep = 10;
      _attention = 10;
      _health = 10;
      _alive = true;
    }

    public string GetName()
    {
      return _name;
    }
   public int GetFood()
    {
      return _food;
    }
    public void GiveFood()
    {
      _food += 4;
    }
    public int GetSleep()
    {
      return _sleep;
    }
    public void GiveSleep()
    {
      _sleep += 4;
    }
     public int GetAttention()
    {
      return _attention;
    }
    public void GiveAttention()
    {
      _attention += 4;
    }
     public int GetHealth()
    {
      return _health;
    }
    public void GiveHealth()
    {
      _health += 4;
    }

    public void ReduceStats()
    {
      _food = _food-1;
      _sleep = _sleep-1;
      _attention = _attention-1;
      _health = _health-1;

      if(_food < 1 || _sleep < 1 || _attention < 1 || _health < 1)
      {
        Die();
      }
    }

    public bool CheckLife()
    {
      return _alive;
    }

    public void Die()
    {
      _alive = false;
    }

    public static List<MyTamagotchi> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

    public int GetId()
    {
      return _id;
    }

    public static MyTamagotchi Find(int searchId)
    {
      return _instances[searchId-1];
    }

  }
}