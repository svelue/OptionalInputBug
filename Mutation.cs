using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate;
using HotChocolate.Types;

namespace OptionalInputBug
{
    public class Mutation
    {
        public Book AddBook([GraphQLType(typeof(NonNullType<BookInputType>))] Book book)
        {
            return book;
        }
    }
}
