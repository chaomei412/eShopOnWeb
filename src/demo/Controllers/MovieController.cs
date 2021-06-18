using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using demo.core.Services;
using demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly ILogger<MovieController> _logger;
        private readonly IMovieService _movieService;

        public MovieController(ILogger<MovieController> logger, IMovieService movieService)
        {
            _logger = logger;
            this._movieService = movieService;
        }

        [HttpGet]
        [Route("user")]
        public IEnumerable<MovieModel> Get()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("user/{userId}")]
        public IEnumerable<MovieModel> Getbyid(int userId)
        {
            throw new NotImplementedException();
        }

        [HttpPost("user")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Product))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult<UserEntity> AddUser([FromBody] UserEntity user)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<IActionResult> Index(NewSessionModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                await _sessionRepository.AddAsync(new BrainstormSession()
                {
                    DateCreated = DateTimeOffset.Now,
                    Name = model.SessionName
                });
            }

            return RedirectToAction(actionName: nameof(Index));
        }
    }

    public class UserEntity
    {
        public UserEntity(int id, string username)
        {
            Id = id;
            UserName = username;
            CreatedOn = DateTime.UtcNow
        }

        public int Id { get; private set; }
        public string UserName { get; private set; }
        public DateTime CreatedOn { get; private set; }

    }

    public interface IUserService
    {
        void SaveUser(UserEntity user);

        UserEntity SaveUser(int userId);
    }

    public class FileUserService : IUserService
    {
        public void SaveUser(UserEntity user)
        {
            throw new NotImplementedException();
        }

        public UserEntity SaveUser(int userId)
        {
            throw new NotImplementedException();
        }

        public void JsonSaveJson(UserEntity user)
        {
            // serialize JSON to a string and then write string to a file
            File.WriteAllText(@"c:\movie.json", JsonConvert.SerializeObject(user));

            // serialize JSON directly to a file
            using (System.IO.StreamWriter file = File.CreateText(@"c:\" + user.Id + ".json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, user);
            }
        }

        public void LoadJson()
        {
            using (StreamReader r = new StreamReader("file.json"))
            {
                string json = r.ReadToEnd();
                UserEntity user = JsonConvert.DeserializeObject<UserEntity>(json);
            }
        }

    }
}
