using BtlWebForm.Entity;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BtlWebForm.Repository
{
    public class UserRepository
    {
        FileIO fileIO = new FileIO();
        public List<UserEntity> FindAllUser()
        {
            string listUseJson = fileIO.ReadFileJson(Constant.DATA_USERS);
            if (listUseJson != null)
            {
                List<UserEntity> users = JsonConvert.DeserializeObject<List<UserEntity>>(listUseJson);
                return users;
            }
            return null;
        }

        public UserEntity FindUserByUsername(string username)
        {
            List<UserEntity> users = FindAllUser();
            foreach (UserEntity user in users)
            {
                if (user.Username.Equals(username))
                    return user;
            }
            return null;
        }
    }
}