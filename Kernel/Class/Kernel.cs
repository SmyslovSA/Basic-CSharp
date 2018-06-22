using System;
using System.Collections.Generic;

namespace Class
{
    public class Kernel
    {
        private readonly Dictionary<Type, Type> _dictionary = new Dictionary<Type, Type>();
        private bool _isValid;

        public void Bind<T, K>() => _isValid = IsValid(typeof(T), typeof(K));

        public object Get<T>()
        {
            if (!_isValid || typeof(T).IsClass) return null;
            var choose = _dictionary[typeof(T)];         
            var constructParams = choose.GetConstructors()[0].GetParameters();
            return Activator.CreateInstance(choose);
        }

        private bool IsValid(Type T, Type K)
        {
            if (T.IsInterface && K.IsClass)
            {
                _dictionary[T] = K;
                return true;
            }
            return false;
        }
    }
}
