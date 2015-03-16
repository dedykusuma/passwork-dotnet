using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var api = new Passwork.Core.Api(new Passwork.Core.Models.CoreOptionModel(){
                Url = @"https://passwork.me"
                
            });
            api.SetMasterPassword("Secret word");
            api.Login("login@email.com", "auth password");

            var data = api.GetTree();
            var cryptedGroupPassword = data.groups[0].passwordCrypted;
            var cryptedPassword = data.groups[0].passwords[0];
            var password = api.GetDecryptedPassword(cryptedPassword, cryptedGroupPassword);
        }
    }
}
