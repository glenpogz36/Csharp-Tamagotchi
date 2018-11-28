using System.Collections.Generic;

namespace Tamagotchi.Models
{
  public class MyTamagotchi
  {
    private string _picture;
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
      _picture = "https://78.media.tumblr.com/96490983d93f4d0f94712df673ea6b37/tumblr_p81ppbq9Vz1uuvqtqo1_400.gif";
    }

    public string GetPicture()
    {
      return _picture;
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
      _picture = "https://orig00.deviantart.net/de58/f/2016/058/8/5/sans_magotchi_by_fel_fisk-d9tds5g.gif";
    }
    public int GetSleep()
    {
      return _sleep;
    }
    public void GiveSleep()
    {
      _sleep += 4;
      _picture = "https://i.gifer.com/embedded/download/7j7Z.gif";
    }
     public int GetAttention()
    {
      return _attention;
    }
    public void GiveAttention()
    {
      _attention += 4;
      _picture = "https://media.giphy.com/media/UneKtrcsN9j7W/giphy.gif";
    }
     public int GetHealth()
    {
      return _health;
    }
    public void GiveHealth()
    {
      _health += 4;
      _picture = "http://rs215.pbsrc.com/albums/cc190/foxxyloveofme/Tamagotchi/tamatchi.gif~c200";
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
      _picture = "https://img.buzzfeed.com/buzzfeed-static/static/enhanced/webdr01/2013/3/5/16/anigif_enhanced-buzz-11911-1362517495-12.gif";
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