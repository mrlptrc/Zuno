using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zuno.Domain.Entitites;

namespace Zuno.Application.Interfaces
{
    public interface IUserRepository {
        Task<User> GetByIdAsync(Guid id); // busca usuarios por id 
        Task<IEnumerable<User>> GetAllAsync(); // itera e mostra quantos usuarios estao cadastrados 
        Task addUser(User user); // recebe um obj User e cadastra 
        Task updateUser(User user); // recebe um obj User para atualizar o já existente 
        Task removeUser(Guid id); // remove User pelo id 
    }
}