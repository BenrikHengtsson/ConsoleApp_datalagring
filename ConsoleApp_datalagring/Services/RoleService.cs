using ConsoleApp_datalagring.Entities;
using ConsoleApp_datalagring.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_datalagring.Services
{
    internal class RoleService
    {
        private readonly RoleRepository _roleRepository;
public RoleService(RoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }


        public RolesEntity CreateRole(string roleName)
        {
            var RoleEntity = _roleRepository.Get(x => x.RoleName == roleName);
            RoleEntity ??= _roleRepository.Create(new RolesEntity { RoleName = roleName });
            return RoleEntity;
        }

        public RolesEntity GetRoleByRoleName(string roleName)
        {

            var RoleEntity = _roleRepository.Get(x => x.RoleName == roleName);
            return RoleEntity;
        }
        public RolesEntity GetRoleById(int id)
        {

            var RoleEntity = _roleRepository.Get(x => x.Id == id);
            return RoleEntity;
        }

        public IEnumerable<RolesEntity> GetRoles()
        {
            var roles = _roleRepository.GetAll();
            return roles;
        }

        public RolesEntity UpdateRole(RolesEntity RoleEntity)
        {
            var updatedRoleEntity = _roleRepository.Update(x => x.Id == RoleEntity.Id, RoleEntity);
            return updatedRoleEntity;
        }

        public void DeleteRole(int id)
        {
            _roleRepository.Delete(x => x.Id == id);
        }
    }
}
