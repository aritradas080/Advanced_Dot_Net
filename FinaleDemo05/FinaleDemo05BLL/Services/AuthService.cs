using AutoMapper;
using FinaleDemo05BLL.DTOs;
using FinaleDemo05DAL;
using FinaleDemo05DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinaleDemo05BLL.Services
{
    public class AuthService
    {
        public static TokenDTO Authenticate(string username, string password)
        {
            var result =  DataAccessFactory.AuthData().Authenticate(username, password);
            if (result)
            {
                var token = new Token();
                token.UserId = username;
                token.CreatedAt = DateTime.Now;
                token.TKey = Guid.NewGuid().ToString();
                var ret = DataAccessFactory.TokenData().Create(token);
                if(ret != null)
                {
                    var cfg = new MapperConfiguration(c =>
                    {
                        c.CreateMap<Token, TokenDTO>();    
                    });
                    var mapper = new Mapper(cfg);
                    return mapper.Map<TokenDTO>(ret);
                }
            }
            return null;
        }
        public static bool IsTokenValid(string tkey)
        {
            var extk = DataAccessFactory.TokenData().Read(tkey);
            if (extk != null && extk.DeletedAt == null)
            {
                return true;
            }return false;
        }

        public static bool Logout(string tkey)
        {
            var extk = DataAccessFactory.TokenData().Read(tkey);
            extk.DeletedAt = DateTime.Now;
            DataAccessFactory.TokenData().Update(extk);
            if(DataAccessFactory.TokenData().Update(extk) != null)
            {
                return true;
            }return false;

        }
    }
}
