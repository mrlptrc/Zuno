using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zuno.Application.DTOs;

namespace Zuno.Application.Services {
    public interface IUserService {
        Task<IEnumerable<UserDTO>> GetAllAsync();
        Task<IEnumerable<UserDTO>> GetAsync(Guid id);
        Task CreateAsync(UserDTO dto);
        Task UpdateAsync(Guid id, UserDTO dto);
        Task DeleteAsync(Guid id);
    }
}
