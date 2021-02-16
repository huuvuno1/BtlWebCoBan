using BtlWebForm.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BtlWebForm.Repository
{
    public class UserRepository
    {
        FileIO fileIO = new FileIO();
        public List<UserEntity> FindAllUser()
        {
            string listUseJson = fileIO.ReadFileJson(Constant.DATA_USER);
            if (listUseJson != null)
            {
                List<UserEntity> users = JsonConvert.DeserializeObject<List<UserEntity>>(listUseJson);
                return users;
            }
            return null;
        }
    }
}