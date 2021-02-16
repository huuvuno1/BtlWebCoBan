using BtlWebForm.Entity;
using BtlWebForm.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BtlWebForm.Service
{
    public class UserService
    {
        UserRepository userRepository = new UserRepository();

        public UserEntity FindUserByUsername(string username)
        {
            
            List<UserEntity> users = userRepository.FindAllUser();
            foreach (UserEntity user in users)
            {
                if (user.Username.Equals(username))
                    return user;
            }
            return null;
        }
    }
}