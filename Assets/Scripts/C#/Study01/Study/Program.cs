using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum ITEMTYPE
{
    EQUIP,
    POTION,
    QUEST,
    NONESELECT
}

class Item
{
    private ITEMTYPE ItemType = ITEMTYPE.NONESELECT;
}

public class Player
{
    private int HP = 100;
    private int AT = 100;

    // 정적 멤버 함수
    public static void PVP(Player _Left, Player _Right)
    {
        _Left.HP -= _Right.AT;
        _Right.HP -= _Left.AT;
    }

    public static void PVE(Player _Left, Monster _Right)
    {
        _Left.HP -= _Right.GetAt();
        _Right.Damage(_Left.AT);
    }

    public void Damage(int _Damage)
    {
        HP -= _Damage;
    }

    public void Damage(Player _Other)
    {
        HP -= _Other.AT;
    }
}

public class Monster
{
    private int HP = 100;
    private int AT = 100;
    
    public int GetAt()
    {
        return this.AT;
    }

    public void Damage(int _AT)
    {
        this.HP -= _AT;
    }
    
}

class SidePlayer
{
    // 정적 멤버변수
    static public int PlayerCount;

    // 멤버변수
    public int X = 0;
    public int Y = 0;
    public int HP = 0;

    public void Gravity()
    {
        Y -= 200;
    }
}

namespace Study
{

    class Program
    {
        static void Main(string[] args)
        {
            /*
            SidePlayer NewPlayer1 = new SidePlayer();
            SidePlayer NewPlayer2 = new SidePlayer();
            SidePlayer NewPlayer3 = new SidePlayer();
            */
            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();
            Player.PVP(NewPlayer1, NewPlayer2);

            Console.WriteLine((int)ITEMTYPE.NONESELECT);
        }
    }
}
