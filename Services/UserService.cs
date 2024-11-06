using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using Repositories;
using Repositories.Model;
using User = Repositories.Model.User;

namespace Services
{
    public class UserService
    {
        UserRepository userRepository = new UserRepository();

        public string checkRole(string userID)
        {
            return userRepository.checkRole(userID);
        }
        public string checkStatus(string userID)
        {
            return userRepository.checkStatus(userID);
        }
        public User getUser(string userID)
        {
            return userRepository.getUser(userID);
        }
        public string createUser(string password, string fullname, string gender, string email, string role)
        {
            return userRepository.createUser(password, fullname, gender, email, role);
        }
        public string updateUser(string userID, string password, string fullname, string address, string gender, byte[] avatar, string role, string status)
        {
            return userRepository.updateUser(userID, password, fullname, address, gender, avatar, role, status);    
        }
        public List<User> getManagerID()
        {
            return userRepository.getManagerID();
        }
        public List<User> getDataUser_CEO()
        {
            return userRepository.getDataUser_CEO();
        }
        public List<User> getUserID()
        {
            return userRepository.getUserID();
        }
        public int countUserActive_CEO()
        {
            return userRepository.countUserActive_CEO();
        }
        public int countUserDeActive_CEO()
        {
            return userRepository.countUserDeActive_CEO();
        }
        public bool blockUser(string userID)
        {
            return userRepository.blockUser(userID);
        }
    }
}
