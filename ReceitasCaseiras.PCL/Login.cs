using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ReceitasCaseiras.PCL
{
    public class Login
    {
        public bool islogged(string login, string senha)
        {
            if(login=="admin" && senha == "123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}