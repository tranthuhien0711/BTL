using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace BTLHtml17.Models
{
    public class UserRoleProvider : RoleProvider
    {
        public override string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public override void AddUsersToRoles(string[] UserNames, string[] RoleNames)
        {
            throw new NotImplementedException();
        }
        public override void CreateRole(string RoleName)
        {
            throw new NotImplementedException();
        }
        public override bool DeleteRole(string RoleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }
        public override string[] FindUsersInRole(string RoleName, string UernameToMatch)
        {
            throw new NotImplementedException();
        }
        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }
        public override string[] GetRolesForUser(string UserName)
        { 
        using (var db = new QuanLyCFDbCotext())
            {
                var model = (from acc in db.accounts
                             join rol in db.Roles
                             on acc.RoleId equals rol.RoleId
                             where acc.UserName == UserName
                         select rol.RoleName).ToArray();
                return model;
            }
        }
        public override string[] GetUsersInRole(string RoleName)
        {
            throw new NotImplementedException();
        }
        public override bool IsUserInRole(string Username, string RoleName)
        {
            throw new NotImplementedException();
        }
        public override void RemoveUsersFromRoles(string[] Usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }
        public override bool RoleExists(string RoleName)
        {
            throw new NotImplementedException();
        }
    }
}



 
       
 
        
 
        

        
 
        