using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Brio.Models
{
    public partial class User : IEntity
    {
        public bool InRoles(string roles)
        {
            if (string.IsNullOrWhiteSpace(roles))
            {
                return false;
            }

            var rolesArray = roles.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var role in rolesArray)
            {
                var hasRole = this.Role.RoleName.Equals(role);
                if (hasRole)
                {
                    return true;
                }
            }
            return false;
        }

        public int ID
        {
            get { return this.Id; }
        }

        public int CompanyId
        {
            get 
            {
                IInfoCardRepository infoCardRepository = (IInfoCardRepository)DependencyResolver.Current.GetService(typeof(IInfoCardRepository));
                return infoCardRepository.GetUserInfoCard(this.ID).CompanyId; 
            }
        }
    }
}