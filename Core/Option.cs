using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace Core
{
    public class Option<T>  : IOptions<T> where T : class
    {
        private readonly T? _value;

        public T Value => _value ?? throw new InvalidOperationException();

        public bool IsNone => _value == null;

        public bool IsSome => _value != null;

        public Option(T? value)
        {
            _value = value;
        }

        public static implicit operator T(Option<T> option) => option.Value;

        public static implicit operator Option<T>(T? value) => new(value);
    }
}
