using Infrastructure.Interfaces;

namespace Presentation
{
    public class UserContext : IUserContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserContext(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public int UserNo => throw new NotImplementedException();

        public string EmplId => throw new NotImplementedException();

        public string DeptId => throw new NotImplementedException();
    }
}
