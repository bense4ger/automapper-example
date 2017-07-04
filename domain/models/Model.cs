using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace automapper.example.domain.models
{
    public abstract class Model
    {
		public override string ToString()
		{
            var name = GetType().Name;
            var props = GetType().GetTypeInfo().DeclaredProperties;
            var builder = new StringBuilder();

            foreach(var prop in props)
            {
                builder.Append($"{prop.Name}: {prop.GetValue(this)}");
            }

            return builder.ToString();
		}
    }
}
