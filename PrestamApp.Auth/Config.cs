using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace PrestamApp.Auth
{
    public class Config
    {
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("resourceApi", "API Application")
            };
        }

        // scopes define the resources in your system
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
            };
        }

        internal static IEnumerable<Client> GetClients()
        {
            return new List<Client>
          {
                new Client
                {
                    ClientId = "clientApp",
 
                    // no interactive user, use the clientid/secret for authentication
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
 
                    // secret for authentication
                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },
 
                    // scopes that client has access to
                    AllowedScopes = { "resourceApi" }
                },
                
                // OpenID Connect implicit flow client (MVC)
                new Client
                {
                    ClientId = "mvc",
                    ClientName = "MVC Client",
                    AllowedGrantTypes = GrantTypes.HybridAndClientCredentials,

                    RequireConsent = true,

                    ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },

                    RedirectUris = { "https://localhost:44395/signin-oidc" },
                    PostLogoutRedirectUris = { "https://localhost:44395/signout-callback-oidc" },

                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "resourceApi"
                    },
                    AllowOfflineAccess = true
                },
                 // OpenID Connect implicit flow client (Angular)
                  new Client
                {
                    ClientId = "ng",
                    ClientName = "Angular Client",
                    AllowedGrantTypes = GrantTypes.Implicit,
                    AllowAccessTokensViaBrowser = true,
                    RequireConsent = true,

                    RedirectUris = { "https://localhost:55137/callback" },
                    PostLogoutRedirectUris = { "https://localhost:55137/home" },
                    AllowedCorsOrigins = { "https://localhost:55137" },
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "resourceApi"
                    }
                },
                   new Client
        {
            ClientId = "xamarin",
            ClientName = "PrestamApp Xamarin OpenId Client",
            AllowedGrantTypes = GrantTypes.Hybrid,
            ClientSecrets =
            {
                new Secret("secret".Sha256())
            },
            RedirectUris = {"http://prestamapp.azurewebsites.net" },
            RequireConsent = false,
            RequirePkce = true,
            PostLogoutRedirectUris =  {"http://prestamapp.azurewebsites.net/Account/Redirecting" } ,
            AllowedCorsOrigins = { "http://eshopxamarin" },
            AllowedScopes = new List<string>
            {
                IdentityServerConstants.StandardScopes.OpenId,
                IdentityServerConstants.StandardScopes.Profile,
                IdentityServerConstants.StandardScopes.OfflineAccess,
                "resourceApi"
            },
            AllowOfflineAccess = true,
            AllowAccessTokensViaBrowser = true
        }
          };
        }
    }
}
