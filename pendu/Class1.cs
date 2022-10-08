using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Lettre
{
    public char value;  //propriétés
    public bool isHidden;

    public Lettre(char value)
    {
        this.value = value;  //réferre aux propriétés
        this.isHidden = true;
    }
}

class Pendu
{
    public int lives;
    public List<Lettre> value;


    public Pendu(string secretWord) //constructeur
    {
        lives = 5;
        this.value = new List<Lettre>();

        foreach (char c in secretWord)
        {
            this.value.Add(new Lettre(c));
        }
    }
    public override string ToString()
    {
        string ret = "";
        foreach (Lettre l in this.value)
        {
            if (l.isHidden == false)
            {
                ret += l.value;
            }
            else
            {
                ret += '_';
            }
        }
        return ret;
    }

    public bool Attempt(char input)
    {
        bool ret = false;

        foreach (Lettre c in this.value)
        {
            if (c.value == input)
            {
                c.isHidden = false;
                ret = true;
            }
        }
        if(ret == false)
        {
            this.lives -= 1;
        }
        return ret;
    }

    public bool IsLost()
    {
        return this.lives <= 0; //expression qui se traduit par un booléen (si lives 0 return true)
    }
    public bool IsFullyUnhidden()
    {
        foreach (Lettre c in this.value)
        {
            if(c.isHidden == true)
            {
                return false;
            }
           
        }
        return true;
    }
}

