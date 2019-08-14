using System;
using System.Collections.Generic;
using System.Text;

namespace DemoShop.Data.Interfaces
{
    public interface IHasOwner<T>
    {
        T OwnerId { set; get; }


    }
}
