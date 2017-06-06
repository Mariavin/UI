using System;
using System.Collections.Generic;
using WindowsFormsApplicationServer.DataAccessLayer.Domains;
using WpfApplication1.BusinessFacade.Repository;


namespace WpfApplication1.BusinessFacade.Services
{
    public class AvtorizationControl
    {
        UserRepository us = new UserRepository();
        public User Avtorize(string login, string password)
        {

            List<User> users = us.GetListOfUsers();
            foreach (var user in users)
            {
                if (user.Login == login && user.Passwod == password)
                {
                    return new User(user.Id, user.Login, user.Passwod, user.Role);
                }
            }
            return new User();
        }
    }
}
