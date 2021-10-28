using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate.Types;

namespace OptionalInputBug
{
    public class BookInputType : InputObjectType<Book>
    {
        protected override void Configure(IInputObjectTypeDescriptor<Book> descriptor)
        {
            base.Configure(descriptor);
            descriptor.Field(_ => _.Title).Type<NonNullType<StringType>>();
            descriptor.Field(_ => _.SomeNumber).Type<FloatType>();
        }
    }
}
