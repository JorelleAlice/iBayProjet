using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class user
{
    public int id { get; set; }
    public string email { get; set; }
    public string pseudo { get; set; }
    public string password { get; set; }
    public string role { get; set; }
    public int IdSeller { get; set; }

    public user() { }
    public user(int Id)
    {
        id = Id;
        
    }

    public void get(user user)
    {

    }
    public void create(user user)
    {

    }
    public void update(user user)
    {

    }
    public void delete(user user)
    {

    }

}

