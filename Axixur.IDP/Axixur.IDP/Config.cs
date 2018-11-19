using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Axixur.IDP
{
    public static class Config
    {
        public static List<TestUser> GetUsers()
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "542d401e-81e2-4424-9f27-5ee5e1117abc",
                    Username = "Frank",
                    Password = "password",

                    Claims = new List<Claim>
                    {
                        new Claim("given_name", "Frank"),
                        new Claim("family_name", "Underhood")
                    }
                },

                new TestUser
                {
                    SubjectId = "f795451e-9890-4d38-8554-fb726b9feeaa",
                    Username = "Claire",
                    Password = "password",

                    Claims = new List<Claim>
                    {
                        new Claim("given_name", "Claire"),
                        new Claim("family_name", "Underhood")
                    }
                }

            };

        }


        public static IEnumerable<IdentityResource> GetIdentityResources()
        {

            var customProfile = new IdentityResource(
                name: "custom.profile",
                displayName: "Custom profile",
                claimTypes: new[] { "name", "email", "status" });

            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                //new IdentityResources.Email(),
                new IdentityResources.Profile()
                //new IdentityResources.Phone(),
                //new IdentityResources.Address(),
                //customProfile
            };

        }


        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    

                }


            };
        }

    }
}
