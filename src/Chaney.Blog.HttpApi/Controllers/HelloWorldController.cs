using Chaney.Blog.Application.HelloWorld;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.AspNetCore.Mvc;

namespace Chaney.Blog.HttpApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : AbpController
    {
        private readonly IHelloWorldAppService _helloWorldAppService;

        public HelloWorldController(IHelloWorldAppService helloWorldAppService)
        {
            _helloWorldAppService = helloWorldAppService;
        }

        [HttpGet]
        public string HelloWorld()
        {
            return _helloWorldAppService.HelloWorld();
        }
    }
}
