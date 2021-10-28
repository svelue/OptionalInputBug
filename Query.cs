using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OptionalInputBug
{
    public class Query
    {
        public Book GetBook() => new Book();
    }
}
