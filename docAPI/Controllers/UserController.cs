using docAPI.Helper;
using docAPI.Repository;
using System.Web.Http;

namespace docAPI.Controllers
{
    [RoutePrefix("users")]
    public class UserController : ApiController
    {
        private IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            Guard.ArgumentNotNull(userRepository, nameof(userRepository));
            _userRepository = userRepository;
        }

        [Route("")]
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            return Ok(_userRepository.GetAll());
        }
    }
}
