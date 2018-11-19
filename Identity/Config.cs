using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Claims;
using IdentityServer4;
using IdentityServer4.Test;
using IdentityServer4.Models;
namespace Identity.IDP
{
    public static class Config
    {
        public static List<TestUser> GetUsers()
        {
           return new List<TestUser>{
                new TestUser {
                    SubjectId=Guid.NewGuid().ToString(),
                    Username="Frank",
                    Password="password",
                    Claims = new List<Claim> {
                            new Claim("given_name","Frank"),
                            new Claim("family_name","Underwood"),
                    }
                },
                new TestUser {
                    SubjectId=Guid.NewGuid().ToString(),
                    Username="Claire",
                    Password="password",
                    Claims = new List<Claim> {
                            new Claim("given_name","Claire"),
                            new Claim("family_name","Underwood"),
                    }
                }
            };
        }
        public static IEnumerable<IdentityResource> GetIdentityResources() {
            return new List<IdentityResource>{
             new IdentityResources.OpenId(),
             new IdentityResources.Profile()    
            };

        }
          public static IEnumerable<Client> GetClients()
          {
              return new List<Client>
              {
                  new Client
                  {
                      ClientName = "Web.API",
                      ClientId = "webapi",
                      AllowedGrantTypes = new Collection<string>() { GrantTypes.Hybrid.ToString()},
                      RedirectUris = new Collection<string>()
                      {
                          "https://localhost:44383/"
                      },
                      AllowedScopes = new Collection<string>
                      {
                          IdentityServerConstants.StandardScopes.OpenId
                      },
                      ClientSecrets = new Collection<Secret>()
                      {
                          new Secret("secret".Sha256())

                      }



                  }
                   
              };
          }
        }

    }
}