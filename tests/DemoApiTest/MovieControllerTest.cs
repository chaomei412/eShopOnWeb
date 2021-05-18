using System;
using System.Collections.Generic;
using System.Linq;
using demo.Controllers;
using demo.core.Domain.Entities;
using demo.core.Services;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;
using Xunit.Abstractions;

namespace DemoApiTest
{
    class TestLog : ILogger<MovieController>
    {
        public IDisposable BeginScope<TState>(TState state)
        {
            throw new NotImplementedException();
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return false;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            ;
        }
    }

    class TestMovieService : IMovieService
    {
        public IList<Movie> GetMovies()
        {
            return new Movie[]
            {
                new Movie(1){Title = "X-Man"}
            };
        }
    }

    public class MovieControllerTest
    {
        private readonly ILogger<MovieController> _logger;

        public MovieControllerTest(ITestOutputHelper output)
        {
            var mock = new Mock<ILogger<MovieController>>();
            _logger = mock.Object;
        }

        [Fact]
        public void Get()
        {
            MovieController subject = new MovieController(_logger, new TestMovieService());

            var result = subject.Get().ToArray();

            Assert.Equal(1, result[0].Id);
        }
    }
}
