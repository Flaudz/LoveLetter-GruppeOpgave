using System;
using System.Collections.Generic;
using System.Text;
using LoveLetter_GruppeOpgave.Model;

namespace LoveLetter_GruppeOpgave.ViewModel
{
    public class LoginRegisterViewmodel
    {
        private int databaseInt;
        private Player myPlayerObject;

        public int DatabaseInt { get => databaseInt; set => databaseInt = value; }
        public Player MyPlayerObject { get => myPlayerObject; set => myPlayerObject = value; }

        public void Login(string name)
        {
            //Connect to database
            // Here we will need to connect to database to login ONLY with name!
            DatabaseInt = 1;
            // DatabaseInt is the id from the user you get from the database

            // If the name that the user types in exists in the database then let the player login and make a public MyPlayerPbject
            if(name == "Nicolaj")
            {
                MyPlayerObject = new Player(DatabaseInt, name);
            }
            else
            {
                // if Register then use this
                // This will set the name in the database tabel called users so that the player can login with his name
                // We also need to check if the name that the user is taken so we dont have multipel names in tabel
                // Maby login automatic after register?
            }

        }
    }
}
