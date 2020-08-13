using System;
using System.Collections.Generic;
using System.Text;

namespace Chaney.Blog.Application.HelloWorld.Impl
{
    public class HelloWorldAppService : BlogAppServiceBase, IHelloWorldAppService
    {
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
