using StackManagement.Gateway;
using StackManagement.Model;

namespace StackManagement.Manager
{
    internal class LoginManager
    {
        private LoginGateway loginGateway = new LoginGateway();

        public bool IsExistUser(Login login)
        {
            if (loginGateway.IsExistItem(login))
            {
                return true;
            }
            return false;
        }
    }
}