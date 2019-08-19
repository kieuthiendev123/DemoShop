using System;
using System.Collections.Generic;
using System.Text;

namespace DemoShop.Infrastructure.SharedKernel
{
    // đây là class base
    public abstract class DomainEntity<T>
    // T là generic động
    {
        public T Id { get; set; }
        /// <summary>
        ///  true if domain has identity
        /// </summary>
        /// <returns></returns>
        public bool IsTransient()
        {
            return Id.Equals(default(T));
        }   


    }
}
